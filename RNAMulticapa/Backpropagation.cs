using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;
using BLL;
using System.Threading;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace RNAMulticapa
{
    public partial class Backpropagation : Form, IReceptorNeuronsNumber
    {
        Network _network;
        NetworkService networkService;
        List<double[]> InputPatterns;
        List<double[]> OutputPatterns;
        Perceptron perceptron;

        public Backpropagation()
        {
            InitializeComponent();
            networkService = new NetworkService();
        }

        private List<double[]> ConvertoList(double [,] s) {
            List<double[]> b = new List<double[]>();
            for (int i = 0; i < s.GetLength(0); i++)
            {
                double[] a = new double[s.GetLength(1)];
                for (int j = 0; j < s.GetLength(1); j++)
                {
                    a[j] = s[i, j];
                }
                b.Add(a);
            }
            return b;
        }
        void resetChart1() {
            chart1.Series["Series1"].Points.Clear();
        }
        public void SaveFile(string fileName, Perceptron perceptron)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                // Escritura sobre el archivo binario `ArchivoBinario.bin` usando un 
                // objeto de la clase `BinaryWriter`:
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, perceptron);
                fs.Close();
            }
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            resetChart1();
            double ra = 0;
            double ermsAllowed = 0;
            int noIterations = 0;
            int currentIteration = 1;
            try
            {
                ra = double.Parse(txtLearningRat.Text);
                ermsAllowed = double.Parse(txtERMSAllowed.Text);
                noIterations = int.Parse(txtNoIterations.Text);
                currentIteration = int.Parse(txtCurrentIteration.Text);
                    }
            catch (Exception)
            {
                
                currentIteration = 1;
            }
            if (_network != null)
            {
                
                resetChart1();
                //TrainNetwork(_network, noIterations, ra,ermsAllowed);
               Thread thread = new Thread(new ThreadStart(() => perceptron.Learn(InputPatterns, OutputPatterns, ra, ermsAllowed, noIterations, this)));
               thread.IsBackground = true;
               thread.Start();
                //perceptron.Learn(InputPatterns, OutputPatterns, ra, ermsAllowed,noIterations,this);

            }
        }
        public void DrawChart1(int currentIteration, double currentErms) {
           
            chart1.Series["Series1"].Points.AddXY(currentIteration, currentErms);
            txtCurrentIteration.Text = currentIteration.ToString();
            txtCurrentERMS.Text = currentErms.ToString();
        }
        public void receive(int currentLayer, int noNeurons, string activationFunction)
        {
            _network.HiddenLayers[currentLayer] = new HiddenLayer(noNeurons, activationFunction);
            txtConfig.Text = txtConfig.Text + $"Capa: {currentLayer + 1} No.Neuronas: {_network.HiddenLayers[currentLayer].NoNeurons}\r\n";
        }
        private void TrainNetwork(Network network, int noIterations,double learningRat, double ERMSAllowed)
        {
            //numero de matrices de peso=noCapasOcultas+1;
            double erms = 9999;
            printCurrentValues(network);
            int currentIteration = 0;
            while (currentIteration < noIterations && erms > ERMSAllowed)
            {
                Console.WriteLine($"--------------iteracion {currentIteration + 1}--------------");
                int indexCurrentPattern = 0;
                var ep = new double[network.NoPatterns];
                double[] newPatterns = new double[1];

                while (indexCurrentPattern < network.NoPatterns)
                {
                    //presento nuevo patron
                    var el = new double[network.NoOutputs];
                    int currentHiddenLayer = 0;
                    List<double[]> hiddenLayerOutputs = new List<double[]>();
                    List<double[]> hiddenLayerDerivadaFAOutput = new List<double[]>();
                    while (currentHiddenLayer < network.NoHiddenLayers)
                    {
                        double[] auxPattern = new double[network.TrainParams[currentHiddenLayer].Weights.GetLength(0)];
                        double[] derivateFA = new double[auxPattern.Length];
                        for (int i = 0; i < network.TrainParams[currentHiddenLayer].Weights.GetLength(0); i++)
                        {
                            var limit = 0;
                            if (currentHiddenLayer == 0)
                            {
                                limit = network.NoInputs;
                            }
                            else
                            {
                                limit = network.TrainParams[currentHiddenLayer].Weights.GetLength(1);
                            }
                            for (int j = 0; j < limit; j++)
                            {
                                double xj = 0;
                                if (currentHiddenLayer == 0)
                                {
                                    xj = network.InputsPatterns[indexCurrentPattern, j];
                                }
                                else
                                {
                                    xj = newPatterns[j];
                                }
                                // Console.WriteLine($"x{j + 1}: " + xj);
                                var wji = network.TrainParams[currentHiddenLayer].Weights[i, j];
                                //Console.WriteLine($"Operation aux: {auxPattern[i]} xj: {xj}  wji: {wji}");
                                auxPattern[i] = auxPattern[i] + (xj * wji);
                            }
                            auxPattern[i] = auxPattern[i] - network.TrainParams[currentHiddenLayer].Threshold[i];
                            //Console.WriteLine($"H{currentHiddenLayer + 1}({i + 1}): " + auxPattern[i]);
                            auxPattern[i] = network.HiddenLayers[currentHiddenLayer].ApplicateFA(auxPattern[i],false);
                            derivateFA[i] = network.HiddenLayers[currentHiddenLayer].ApplicateFA(auxPattern[i], true);
                            //Console.WriteLine($"H{currentHiddenLayer + 1}({i + 1}): " + auxPattern[i]);
                        }
                        hiddenLayerDerivadaFAOutput.Add(derivateFA);
                        hiddenLayerOutputs.Add(auxPattern);
                        newPatterns = auxPattern;
                        currentHiddenLayer++;
                    }
                    double[] yr = new double[network.NoOutputs];
                    for (int i = 0; i < network.NoOutputs; i++)
                    {
                        for (int j = 0; j < newPatterns.Length; j++)
                        {
                            var xj = newPatterns[j];
                            var wji = network.TrainParams[currentHiddenLayer].Weights[i, j];
                            //Console.WriteLine($"Operation yr: {yr[i]} xj: {xj}  wji: {wji}");
                            yr[i] = yr[i] + (xj * wji);
                        }
                        yr[i] = yr[i] - network.TrainParams[currentHiddenLayer].Threshold[i];
                        //Console.WriteLine($"YR{i + 1}: " + yr[i]);
                        yr[i] = CalculateSigmodea(yr[i]);
                        //Console.WriteLine($"YR{i + 1}: " + yr[i]);
                        //Console.WriteLine($"YD: " + network.OutputsPatterns[indexCurrentPattern, i]);
                        el[i] = network.OutputsPatterns[indexCurrentPattern, i] - yr[i];
                        //Console.WriteLine($"el{i + 1}: " + el[i]);
                    }
                    //COmienzo backpropagation
                    var EN=StartBackpropagation(network, el);
                    ep[indexCurrentPattern] = calculatePatternError(network.NoOutputs, el);
                    //Console.WriteLine($"ep{indexCurrentPattern + 1}: " + ep[indexCurrentPattern]);
                    calculateNewParams(network, el, ep, indexCurrentPattern, learningRat, hiddenLayerOutputs,EN, hiddenLayerDerivadaFAOutput);
                    indexCurrentPattern++;
                }
                erms = CalculateERMS(network.NoPatterns, ep);
                string messageERMS = "ERMS: " + erms;
                Console.WriteLine(messageERMS);
                currentIteration++;
            }
        }
        private double CalculateSigmodea(double value)
        {
            double result;
            result = 1 / (1 + Math.Exp(-value));
            return result;
        }
        private List<double[]> StartBackpropagation(Network network, double[] el) {
            List<double[]> EN = new List<double[]>();
            // Console.WriteLine("Cuantos parametros tengo?: "+network.TrainParams.Length);
            int l = network.TrainParams.Length - 1;
            int tamaño = l;

            //Recorre las matrices de peso desde la capa de salida hasta la capa 1
            while (l > 0) {
                //Console.WriteLine($"l: {l}, el: {el.Length}");
                // Console.WriteLine($"La matriz deber ser de {network.TrainParams[l].Weights.GetLength(0)}, {network.TrainParams[l].Weights.GetLength(1)}");
                double[] a = new double[network.TrainParams[l].Weights.GetLength(1)];
                for (int i = 0; i < network.TrainParams[l].Weights.GetLength(0); i++)
                {
                    for (int j = 0; j < network.TrainParams[l].Weights.GetLength(1); j++)
                    {
                        if (l == network.TrainParams.Length - 1)
                        {
                            a[j] = a[j] + (el[i] * network.TrainParams[l].Weights[i, j]);
                        }
                        else {

                            a[j] = a[j] + (EN[tamaño-(l+1)][i] * network.TrainParams[l].Weights[i, j]);
                        }
                    }

                }
                EN.Add(a);
                l--;
            }
            //Console.WriteLine("ENNNN: " + EN.Count);
            return EN;
        }
        private double CalculateDerivatedSigmodea(double value) {
            double result;
            result = Math.Exp(-value) / ((Math.Exp(-value) + 1)* (Math.Exp(-value) + 1));
            return result;
        }
        private void calculateNewParams(Network network, double[] el, double[] ep, int indexCurrentParttern, double learningRat, List<double[]> h,List<double[]> EN, List<double[]> hprima)
        {
            int currentArray = 0;
            List<double[]> invertEN = InvertArray(EN);
            //Console.WriteLine("En: " + EN.Count);
            //Console.WriteLine(network.TrainParams.Length - 1);
            //Console.WriteLine(hprima.Count);
            while (currentArray < network.TrainParams.Length - 1)
            {
                for (int i = 0; i < network.TrainParams[currentArray].Weights.GetLength(0); i++)
                {
                    for (int j = 0; j < network.TrainParams[currentArray].Weights.GetLength(1); j++)
                    {
                        double xj = 0;
                        if (currentArray == 0)
                        {
                            xj = network.InputsPatterns[indexCurrentParttern, j];
                        }
                        else
                        {
                            xj = hprima[currentArray][i];
                        }
                        //W1(j,i)=W1(j,i)+RA*EP*X(j) 
                        //Console.WriteLine($"Soy la capa {currentArray + 1} tengo {network.HiddenLayers[currentArray].NoNeurons} y segun el peso tengo {network.TrainParams[currentArray].Weights.GetLength(0)}");
                        //Console.WriteLine(invertEN[currentArray].Length);
                        if (currentArray == 0) { 
                            network.TrainParams[currentArray].Weights[i, j] = network.TrainParams[currentArray].Weights[i, j] + (2*learningRat * invertEN[currentArray][i] * xj* hprima[currentArray][i]);
                         }else {
                            network.TrainParams[currentArray].Weights[i, j] = network.TrainParams[currentArray].Weights[i, j] + (2 * learningRat * invertEN[currentArray][i] * xj );
                        }
                        //Console.WriteLine($" W{currentArray+1}({i+1},{j+1}): " + network.TrainParams[currentArray].Weights[i, j]);
                    }
                    network.TrainParams[currentArray].Threshold[i] = network.TrainParams[currentArray].Threshold[i] + (2*learningRat * invertEN[currentArray][i] * 1);
                    // Console.WriteLine(i + " U: " + network.TrainParams[currentArray].Threshold[i]);
                }
                currentArray++;
            }
            for (int i = 0; i < network.NoOutputs; i++)
            {
                for (int j = 0; j < network.TrainParams[currentArray].Weights.GetLength(1); j++)
                {
                    var newWeight = network.TrainParams[currentArray].Weights[i, j] + (2*learningRat * el[i] * h[currentArray-1][i]);
                    network.TrainParams[currentArray].Weights[i, j] = newWeight;
                    //Console.WriteLine($" W{currentArray + 1}({i + 1},{j + 1}): " + network.TrainParams[currentArray].Weights[i, j]);
                }
                network.TrainParams[currentArray].Threshold[i] = network.TrainParams[currentArray].Threshold[i] + (learningRat * el[i] * 1);
                //Console.WriteLine(i + " U: " + network.TrainParams[currentArray].Threshold[i]);
            }
        }
        List<double[]> InvertArray(List<double[]> EN) {
            List<double[]> newEN = new List<double[]>();
            int i = EN.Count-1;
            while (i >= 0) {
                newEN.Add(EN[i]);
                i--;
            }
            return newEN;
        }
        private int calculateEscalon(double value)
        {
            return value >= 0 ? 1 : -1;
        }
        private double calculatePatternError(int noOutputs, double[] el)
        {
            double result = 0;
            for (int i = 0; i < noOutputs; i++)
            {
                result = result + Math.Abs(el[i]);
            }
            return result / noOutputs;
        }
        private double CalculateERMS(int noPatterns, double[] ep)
        {
            double rms = 0;
            for (int i = 0; i < noPatterns; i++)
            {
                rms = rms + ep[i];
                //Console.WriteLine("epi: " + ep[i]);
            }
            rms = rms / noPatterns;
            return rms;
        }
        private void printCurrentValues(Network network)
        {
            for (int i = 0; i < network.TrainParams.Length; i++)
            {
                for (int j = 0; j < network.TrainParams[i].Weights.GetLength(0); j++)
                {
                    for (int k = 0; k < network.TrainParams[i].Weights.GetLength(1); k++)
                    {
                        Console.Write(" " + network.TrainParams[i].Weights[j, k]);
                    }
                    Console.WriteLine("\n");
                }
            }
        }

        private void cargarDatosEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private bool AreDefinedHiddenLayers()
        {
            if (cbxNoHiddenLayers.SelectedItem == null)
            {
                MessageBox.Show("Debe definir el numero de capas ocultas");
                return false;
            }
            else
            {
                return true;
            }
        }
        private void DefineLengths(Network network)
        {
            //Lleno un array Para definir el tamaño de los pesos de forma dinamica 
            network.TrainParams = new TrainParams[_network.NoHiddenLayers + 1];
            int[] v = new int[5];
            v[0] = network.NoInputs;
            int i = 0;
            while (i < network.NoHiddenLayers)
            {
                v[i + 1] = network.HiddenLayers[i].NoNeurons;
                i++;
            }
            v[i + 1] = network.NoOutputs;
            for (int j = 0; j < network.TrainParams.Length; j++)
            {
                network.TrainParams[j] = new TrainParams();
                network.TrainParams[j].Weights = new double[v[j + 1], v[j]];
                network.TrainParams[j].Threshold = new double[v[j + 1]];
            }
        }
        private void loadWeightsThreshold_Click(object sender, EventArgs e)
        {
            if (_network != null)
            {
                if (AreDefinedHiddenLayers())
                {
                    DefineLengths(_network);
                    TrainParams AuxParams;
                    for (int i = 0; i < _network.TrainParams.Length; i++)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Title = $"Carge W{i + 1} y U{i + 1}";
                        if (openFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            AuxParams = networkService.ReadNetworkTrainParams(openFileDialog.FileName);
                            if (AuxParams.Weights.GetLength(0) == _network.TrainParams[i].Weights.GetLength(0) && AuxParams.Weights.GetLength(1) == _network.TrainParams[i].Weights.GetLength(1))
                            {
                                _network.TrainParams[i] = AuxParams;
                            }
                            else
                            {
                                MessageBox.Show("incoherencia entre los datos de entrenamiento y los pesos o umbrales");
                            }
                        }
                    }
                }
            }
        }

        private void btnShowDataTrain_Click(object sender, EventArgs e)
        {
            if (_network != null)
            {
                TrainData trainData = new TrainData(_network);
                trainData.Show();
            }
        }

        private void cbxNoHiddenLayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_network != null)
            {
                _network.NoHiddenLayers = Int16.Parse(cbxNoHiddenLayers.SelectedItem.ToString());
                _network.HiddenLayers = new HiddenLayer[_network.NoHiddenLayers];
                for (int i = 0; i < Int16.Parse(cbxNoHiddenLayers.SelectedItem.ToString()); i++)
                {
                    NeuronsNumber neuronsNumber = new NeuronsNumber(i, this);
                    neuronsNumber.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Debe cargar los datos de entrenamiento");
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void LoadTrainData()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _network = networkService.ReadDataTrain(openFile.FileName);

                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el archivo");
                }
            }
            if (_network != null)
            {
                txtInputs.Text = _network.NoInputs.ToString();
                txtOutputs.Text = _network.NoOutputs.ToString();
                txtPatterns.Text = _network.NoPatterns.ToString();
                //FillDataGridWeights(weights);
            }
        }

        private void cargarEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTrainData();
        }

        private void btnInitializateTrainParams_Click(object sender, EventArgs e)
        {
            if (_network != null)
            {
                if (AreDefinedHiddenLayers())
                {

                    DefineLengths(_network);
                    AleatorizateWeightsAndThreshold(_network);
                }
            }
        }
        private void AleatorizateWeightsAndThreshold(Network network)
        {
            for (int i = 0; i < network.TrainParams.Length; i++)
            {
                txtWeigths.Text = txtWeigths.Text + $"W{i + 1}[ {network.TrainParams[i].Weights.GetLength(0)}" +
                    $",{network.TrainParams[i].Weights.GetLength(1)} ]\r\n\r\n";
                AleatorizateArrayValues(network.TrainParams[i].Weights);
                txtWeigths.Text = txtWeigths.Text + $"U{i + 1}[ {network.TrainParams[i].Threshold.GetLength(0)} ]\r\n\r\n";
                AleatorizateArrayValues(network.TrainParams[i].Threshold);
                txtWeigths.Text = txtWeigths.Text + "\r\n\r\n";
            }
        }

        private void AleatorizateArrayValues(double[,] m)
        {
            Random random = new Random();

            txtWeigths.Text = txtWeigths.Text + "[\r\n";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    double randomNumber = ((double)random.Next(0, 90)) / 100;
                    m[i, j] = Math.Round(randomNumber, 1);
                    txtWeigths.Text = txtWeigths.Text + $"      {m[i, j]}   ;";
                }
                txtWeigths.Text = txtWeigths.Text + "|*\r\n ";
            }
            txtWeigths.Text = txtWeigths.Text + "]";
            txtWeigths.Text = txtWeigths.Text + "\r\n";
        }
        private void AleatorizateArrayValues(double[] m)
        {
            Random random = new Random();
            txtWeigths.Text = txtWeigths.Text + "[ \r\n";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                double randomNumber = ((double)random.Next(0, 90)) / 100;
                m[i] = Math.Round(randomNumber, 1);
                txtWeigths.Text = txtWeigths.Text + $"  {m[i]} |* \r\n";

            }
            txtWeigths.Text = txtWeigths.Text + "]";
            txtWeigths.Text = txtWeigths.Text + "\r\n ";
        }





        

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void btnInitializateNetwork_Click(object sender, EventArgs e)
        {

            InputPatterns = new List<double[]>();
            OutputPatterns = new List<double[]>();
            InputPatterns = ConvertoList(_network.InputsPatterns);
            OutputPatterns = ConvertoList(_network.OutputsPatterns);
            List<int> vector = new List<int>();
            vector.Add(InputPatterns[0].Length);
            for (int i = 0; i < _network.HiddenLayers.Length; i++)
            {
                vector.Add(_network.HiddenLayers[i].NoNeurons);
            }
            vector.Add(OutputPatterns[0].Length);
            if (_network != null) { 
                 perceptron = new Perceptron(vector.ToArray());
                MessageBox.Show("Se inicializó");
            }


        }
        [Serializable]
        public class Perceptron
        {
            List<Layer> layers;

            public Perceptron(int[] neuronsPerlayer)
            {
                layers = new List<Layer>();
                Random r = new Random();

                for (int i = 0; i < neuronsPerlayer.Length; i++)
                {
                    layers.Add(new Layer(neuronsPerlayer[i], i == 0 ? neuronsPerlayer[i] : neuronsPerlayer[i - 1], r));
                }
            }
            public double[] Activate(double[] inputs)
            {
                double[] outputs = new double[0];
                for (int i = 0; i < layers.Count; i++)
                {
                    outputs = layers[i].Activate(inputs);
                    inputs = outputs;
                }
                return outputs;
            }
            double IndividualError(double[] realOutput, double[] desiredOutput)
            {
                double err = 0;
                for (int i = 0; i < realOutput.Length; i++)
                {
                    err += Math.Pow(realOutput[i] - desiredOutput[i], 2);
                }
                return err;
            }
            double GeneralError(List<double[]> input, List<double[]> desiredOutput)
            {
                double err = 0;
                for (int i = 0; i < input.Count; i++)
                {
                    err += IndividualError(Activate(input[i]), desiredOutput[i]);
                }
                return err;
            }
            List<string> log;
            public void Learn(List<double[]> input, List<double[]> desiredOutput, double alpha, double maxError, int noIterations, Backpropagation back)
            {
                double err = 99999;
                log = new List<string>();
                CheckForIllegalCrossThreadCalls = false;
                int currentIteration = 1;
                while (err > maxError && currentIteration <= noIterations)
                {
                    ApplyBackPropagation(input, desiredOutput, alpha);
                    err = GeneralError(input, desiredOutput);
                    log.Add(err.ToString());
                    Console.WriteLine(err +"--------"+currentIteration);
                    if (back.chart1.IsHandleCreated && back.txtCurrentIteration.IsHandleCreated)
                    {
                        back.Invoke((MethodInvoker)delegate { back.DrawChart1(currentIteration, err); });
                    }
                    currentIteration++;

                }
            }

            List<double[]> sigmas;
            List<double[,]> deltas;

            void SetSigmas(double[] desiredOutput)
            {
                sigmas = new List<double[]>();
                for (int i = 0; i < layers.Count; i++)
                {
                    sigmas.Add(new double[layers[i].numberOfNeurons]);
                }
                for (int i = layers.Count - 1; i >= 0; i--)
                {
                    for (int j = 0; j < layers[i].numberOfNeurons; j++)
                    {
                        if (i == layers.Count - 1)
                        {
                            double y = layers[i].neurons[j].lastActivation;
                            sigmas[i][j] = (Neuron.Sigmoid(y) - desiredOutput[j]) * Neuron.SigmoidDerivated(y);
                        }
                        else
                        {
                            double sum = 0;
                            for (int k = 0; k < layers[i + 1].numberOfNeurons; k++)
                            {
                                sum += layers[i + 1].neurons[k].weights[j] * sigmas[i + 1][k];
                            }
                            sigmas[i][j] = Neuron.SigmoidDerivated(layers[i].neurons[j].lastActivation) * sum;
                        }
                    }
                }
            }
            void SetDeltas()
            {
                deltas = new List<double[,]>();
                for (int i = 0; i < layers.Count; i++)
                {
                    deltas.Add(new double[layers[i].numberOfNeurons, layers[i].neurons[0].weights.Length]);
                }
            }
            void AddDelta()
            {
                for (int i = 1; i < layers.Count; i++)
                {
                    for (int j = 0; j < layers[i].numberOfNeurons; j++)
                    {
                        for (int k = 0; k < layers[i].neurons[j].weights.Length; k++)
                        {
                            deltas[i][j, k] += sigmas[i][j] * Neuron.Sigmoid(layers[i - 1].neurons[k].lastActivation);
                        }
                    }
                }
            }
            void UpdateBias(double alpha)
            {
                for (int i = 0; i < layers.Count; i++)
                {
                    for (int j = 0; j < layers[i].numberOfNeurons; j++)
                    {
                        layers[i].neurons[j].bias -= alpha * sigmas[i][j];
                    }
                }
            }
            void UpdateWeights(double alpha)
            {
                for (int i = 0; i < layers.Count; i++)
                {
                    for (int j = 0; j < layers[i].numberOfNeurons; j++)
                    {
                        for (int k = 0; k < layers[i].neurons[j].weights.Length; k++)
                        {
                            layers[i].neurons[j].weights[k] -= alpha * deltas[i][j, k];
                        }
                    }
                }
            }
            void ApplyBackPropagation(List<double[]> input, List<double[]> desiredOutput, double alpha)
            {
                SetDeltas();
                for (int i = 0; i < input.Count; i++)
                {
                    Activate(input[i]);
                    SetSigmas(desiredOutput[i]);
                    UpdateBias(alpha);
                    AddDelta();
                }
                UpdateWeights(alpha);

            }
        }
        [Serializable]
        public class Layer
        {
            public List<Neuron> neurons;
            public int numberOfNeurons;
            public double[] output;

            public Layer(int _numberOfNeurons, int numberOfInputs, Random r)
            {
                numberOfNeurons = _numberOfNeurons;
                neurons = new List<Neuron>();
                for (int i = 0; i < numberOfNeurons; i++)
                {
                    neurons.Add(new Neuron(numberOfInputs, r));
                }
            }

            public double[] Activate(double[] inputs)
            {
                List<double> outputs = new List<double>();
                for (int i = 0; i < numberOfNeurons; i++)
                {
                    outputs.Add(neurons[i].Activate(inputs));
                }
                output = outputs.ToArray();
                return outputs.ToArray();
            }

        }
        [Serializable]
        public class Neuron
        {
            public double[] weights;
            public double lastActivation;
            public double bias;

            public Neuron(int numberOfInputs, Random r)
            {
                bias = 10 * r.NextDouble() - 5;
                weights = new double[numberOfInputs];
                for (int i = 0; i < numberOfInputs; i++)
                {
                    weights[i] = 10 * r.NextDouble() - 5;

                }
            }
            public double Activate(double[] inputs)
            {
                double activation = bias;

                for (int i = 0; i < weights.Length; i++)
                {
                    activation += weights[i] * inputs[i];
                }

                lastActivation = activation;
                return Sigmoid(activation);
            }
            public static double Sigmoid(double input)
            {
                return 1 / (1 + Math.Exp(-input));
            }
            public static double SigmoidDerivated(double input)
            {
                double y = Sigmoid(input);
                return y * (1 - y);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (perceptron != null) { 
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK) {
                    SaveFile(saveFileDialog.FileName, perceptron);
                }
            }
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SimulateBackpropagation simulateBackpropagation = new SimulateBackpropagation(this);
            simulateBackpropagation.Show();
        }

        private void txtInputs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeigths_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
