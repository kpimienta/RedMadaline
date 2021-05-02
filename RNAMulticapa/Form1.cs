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
namespace RNAMulticapa
{
    public partial class Form1 : Form, IReceptorNeuronsNumber
    {
        Network _network;
        int iterations;
        Thread thread;
        NetworkService networkService = new NetworkService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void resetChart1()
        {
            chart1.Series["Series1"].Points.Clear();
        }
        public void DrawChart1(int currentIteration, double currentErms)
        {

            chart1.Series["Series1"].Points.AddXY(currentIteration, currentErms);
            txtCurrentIteration.Text = currentIteration.ToString();
            txtCurrentERMS.Text = currentErms.ToString();
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            

            resetChart1();
            double ra = 0;
            double ermsAllowed = 0;
            int noIterations = 0;
            try
            {
                ra = double.Parse(txtLearningRat.Text);
                ermsAllowed = double.Parse(txtERMSAllowed.Text);
                noIterations = int.Parse(txtNoIterations.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error en los parametros");
                 ra = 0;
                 ermsAllowed = 0;
                 noIterations = 0;
            }
            if (_network != null)
            {
                if (thread != null) { 
                    thread.Abort();
                }
                
                thread = new Thread(new ThreadStart(() => TrainNetwork(_network, noIterations, ermsAllowed, ra)));
                thread.IsBackground = true;
                thread.Start();
            }
           
        }

        private void TrainNetwork(Network network, int noIterations, double ERMSAllowed, double ra)
        {
            //numero de matrices de peso=noCapasOcultas+1;
            double erms = 9999;
            printCurrentValues(network);
            CheckForIllegalCrossThreadCalls = false;
            int currentIteration = 0;
            while (currentIteration < noIterations && erms > ERMSAllowed)
            {
                Console.WriteLine($"--------------iteracion {currentIteration+1}--------------");
                int indexCurrentPattern = 0;
                var ep = new double[network.NoPatterns];
                double[] newPatterns = new double[1];

                while (indexCurrentPattern < network.NoPatterns)
                {
                   // Console.WriteLine("presento nuevo patron");
                    var el = new double[network.NoOutputs];
                    int currentHiddenLayer = 0;
                    List<double[]> hiddenLayerOutputs = new List<double[]>();
                    while (currentHiddenLayer < network.NoHiddenLayers)
                    {
                        double[] auxPattern = new double[network.TrainParams[currentHiddenLayer].Weights.GetLength(0)];
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
                               // Console.WriteLine(currentHiddenLayer); 
                                //Console.WriteLine(limit);
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
                              //  Console.WriteLine($"x{j + 1}: " + xj);
                                var wji = network.TrainParams[currentHiddenLayer].Weights[i, j];
                                //Console.WriteLine($"Operation aux: {auxPattern[i]} xj: {xj}  wji: {wji}");
                                auxPattern[i] = auxPattern[i] + (xj * wji);
                            }
                            //Console.WriteLine($"H{currentHiddenLayer + 1}({i + 1}): " + auxPattern[i]+$" - {network.TrainParams[currentHiddenLayer].Threshold[i]}");
                            auxPattern[i] = auxPattern[i] - network.TrainParams[currentHiddenLayer].Threshold[i];
                           // Console.WriteLine($"H{currentHiddenLayer + 1}({i + 1}): " + auxPattern[i]);
                            auxPattern[i] = network.HiddenLayers[currentHiddenLayer].ApplicateFA(auxPattern[i],false);
                           // Console.WriteLine($"H{currentHiddenLayer + 1}({i + 1}): " + auxPattern[i]);
                        }
                        
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
                           // Console.WriteLine($"Operation yr: {yr[i]} xj: {xj}  wji: {wji}");
                            yr[i] = yr[i] + (xj * wji);
                        }
                        yr[i] = yr[i] - network.TrainParams[currentHiddenLayer].Threshold[i];
                        //Console.WriteLine($"YR{i + 1}: " + yr[i]);
                        if (cbxFA.IsHandleCreated)
                        {
                            yr[i] = chooseFA(yr[i]);
                        }
                        else {
                            yr[i] = CalculateSigmodea(yr[i]);
                        }
                       // Console.WriteLine($"YR{i + 1}: " + yr[i]);
                      //  Console.WriteLine($"YD: " + network.OutputsPatterns[indexCurrentPattern, i]);
                        el[i] = network.OutputsPatterns[indexCurrentPattern, i] - yr[i];
                       // Console.WriteLine($"el{i + 1}: " + el[i]);
                    }
                    ep[indexCurrentPattern] = calculatePatternError(network.NoOutputs, el);
                    //Console.WriteLine($"ep{indexCurrentPattern + 1}: " + ep[indexCurrentPattern]);
                    calculateNewParams(network, el, ep, indexCurrentPattern, ra, hiddenLayerOutputs);
                    indexCurrentPattern++;
                }
                erms = CalculateERMS(network.NoPatterns, ep);
                if (chart1.IsHandleCreated && txtCurrentERMS.IsHandleCreated && txtCurrentIteration.IsHandleCreated) {
                    this.Invoke((MethodInvoker)delegate { DrawChart1(currentIteration+1, erms); });
                }
                string messageERMS = "ERMS: " + erms;
                Console.WriteLine(messageERMS);
                currentIteration++;
            }
        }
        private double CalculateSigmodea(double value) {
            double result;
            result = 1 / (1 + Math.Exp(-value));
            return result;
        }
        private void calculateNewParams(Network network, double[] el, double[] ep, int indexCurrentParttern, double learningRat, List<double[]> a)
        {
            int currentArray = 0;
            while (currentArray < network.TrainParams.Length-1) {
                for (int i = 0; i < network.TrainParams[currentArray].Weights.GetLength(0); i++)
                {
                    for (int j = 0; j < network.TrainParams[currentArray].Weights.GetLength(1); j++)
                    {
                        double xj = 0;
                        if (currentArray == 0)
                        {
                            xj = network.InputsPatterns[indexCurrentParttern, j];
                        }
                        else {
                            xj = a[currentArray-1][j];
                        }
                        //W1(j,i)=W1(j,i)+RA*EP*X(j) 
                        network.TrainParams[currentArray].Weights[i, j] = network.TrainParams[currentArray].Weights[i, j] + (learningRat * ep[indexCurrentParttern] * xj);
                       // Console.WriteLine($" W{currentArray+1}({i+1},{j+1}): " + network.TrainParams[currentArray].Weights[i, j]);
                    }
                    network.TrainParams[currentArray].Threshold[i] = network.TrainParams[currentArray].Threshold[i] + (learningRat * ep[indexCurrentParttern] * 1);
                   // Console.WriteLine(i + " U: " + network.TrainParams[currentArray].Threshold[i]);
                }
                currentArray++;
            }
            for (int i = 0; i < network.NoOutputs; i++)
            {
                for (int j = 0; j < network.TrainParams[currentArray].Weights.GetLength(1); j++)
                {
                    var newWeight = network.TrainParams[currentArray].Weights[i, j] + (learningRat * el[i] * a[currentArray-1][j]);
                    network.TrainParams[currentArray].Weights[i, j] = newWeight;
                    //Console.WriteLine($" W{currentArray + 1}({i + 1},{j + 1}): " + network.TrainParams[currentArray].Weights[i, j]);
                }
                network.TrainParams[currentArray].Threshold[i] = network.TrainParams[currentArray].Threshold[i] + (learningRat * el[i] * 1);
               // Console.WriteLine(i + " U: " + network.TrainParams[currentArray].Threshold[i]);
            }
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
        private double CalculateERMS(int noPatterns, double[] ep)
        {
            double rms = 0;
            for (int i = 0; i < noPatterns; i++)
            {
                rms = rms + ep[i];
               // Console.WriteLine("epi: " + ep[i]);
            }
            rms = rms / noPatterns;
            return rms;
        }
        private void printCurrentValues(Network network) {
            for (int i = 0; i < network.TrainParams.Length; i++)
            {
                for (int j = 0; j < network.TrainParams[i].Weights.GetLength(0); j++)
                {
                    for (int k = 0; k < network.TrainParams[i].Weights.GetLength(1); k++)
                    {
                        Console.Write(" "+ network.TrainParams[i].Weights[j, k]);
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        private void AleatorizateWeightsAndThreshold(Network network) {
            for (int i = 0; i < network.TrainParams.Length; i++)
            {
                txtWeigths.Text = txtWeigths.Text + $"W{i+1}[ {network.TrainParams[i].Weights.GetLength(0)}" +
                    $",{network.TrainParams[i].Weights.GetLength(1)} ]\r\n\r\n";
                AleatorizateArrayValues(network.TrainParams[i].Weights);
                txtWeigths.Text = txtWeigths.Text + $"U{i + 1}[ {network.TrainParams[i].Threshold.GetLength(0)} ]\r\n\r\n";
                AleatorizateArrayValues(network.TrainParams[i].Threshold);
                txtWeigths.Text = txtWeigths.Text + "\r\n\r\n";
            }
        }

        private void AleatorizateArrayValues(double[,] m) {
            Random random = new Random();
            
            txtWeigths.Text = txtWeigths.Text + "[\r\n";
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    double randomNumber = ((double)random.Next(0, 90)) / 100;
                    m[i, j] =Math.Round(randomNumber,1) ;
                    txtWeigths.Text = txtWeigths.Text+$"      {m[i, j]}   ;";
                }
                txtWeigths.Text = txtWeigths.Text + "|*\r\n ";
            }
            txtWeigths.Text = txtWeigths.Text + "]";
            txtWeigths.Text = txtWeigths.Text + "\r\n";
        }
        private void AleatorizateArrayValues(double[] m)
        {
            Random random = new Random();
            txtWeigths.Text = txtWeigths.Text + "[ \r\n" ;
            for (int i = 0; i < m.GetLength(0); i++)
            {
                    double randomNumber = ((double)random.Next(0, 90)) / 100;
                    m[i] = Math.Round(randomNumber, 1);
                    txtWeigths.Text = txtWeigths.Text + $"  {m[i]} |* \r\n";

            }
            txtWeigths.Text = txtWeigths.Text + "]";
            txtWeigths.Text = txtWeigths.Text + "\r\n ";
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
        private bool FieldsVerified()
        {
            if (txtLearningRat.Text != "" && txtNoIterations.Text != "" && txtERMSAllowed.Text != "")
            {
                return true;
            }
            return false;
        }

        private void cargarDatosEntrenamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadTrainData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private bool AreDefinedHiddenLayers() {
            if (cbxNoHiddenLayers.SelectedItem==null)
            {
                MessageBox.Show("Debe definir el numero de capas ocultas");
                return false;
            }
            else {
                return true;
            }
        }
        private void btnInitializateTrainParams_Click(object sender, EventArgs e)
        {
            resetChart1();
            txtWeigths.Text = "";
            if (_network != null)
            {
                if (AreDefinedHiddenLayers()) {
                   
                    DefineLengths(_network);
                    AleatorizateWeightsAndThreshold(_network);
                }
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
            else {
                MessageBox.Show("Debe cargar los datos de entrenamiento");
            }
        }

        public void receive(int currentLayer,int noNeurons, string activationFunction)
        {
            _network.HiddenLayers[currentLayer] = new HiddenLayer(noNeurons,activationFunction);
            txtConfig.Text = txtConfig.Text+$"Capa: {currentLayer+1} No.Neuronas: {_network.HiddenLayers[currentLayer].NoNeurons}\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_network != null) { 
                TrainData trainData = new TrainData(_network);
                trainData.Show();
            }
        }

        private void loadWeightsThreshold_Click(object sender, EventArgs e)
        {
            if (_network != null) {
                if (AreDefinedHiddenLayers())
                {
                    DefineLengths(_network);
                    TrainParams AuxParams;
                    for (int i = 0; i < _network.TrainParams.Length; i++)
                    {
                        OpenFileDialog openFileDialog = new OpenFileDialog();
                        openFileDialog.Title = $"Carge W{i+1} y U{i+1}";
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

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backpropagationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backpropagation backpropagation = new Backpropagation();
            backpropagation.Show();
        }
        private void SaveCurrentParams()
        {
            for (int i = 0; i < _network.TrainParams.Length; i++)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    networkService.SaveNetworkTrainParams(saveFileDialog.FileName + $"W{i+1} y U{i+1}.txt", CreateParamsList(_network.TrainParams[i]));
                }
            }
        }
        private List<string> CreateParamsList(TrainParams trainParams)
        {
            string delimiter = "/";
            List<string> data = new List<string>();
            string a = "";
            for (int i = 0; i < trainParams.Weights.GetLength(0); i++)
            {
                for (int j = 0; j < trainParams.Weights.GetLength(1); j++)
                {
                    if (j == trainParams.Weights.GetLength(1) - 1)
                    {
                        a = a + trainParams.Weights[i, j] + ";";
                    }
                    else
                    {
                        a = a + trainParams.Weights[i, j] + delimiter;
                    }
                }
                a = a + trainParams.Threshold[i];
                data.Add(a);
            }
            return data;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_network != null)
            {
                if (double.Parse(txtCurrentERMS.Text) <= double.Parse(txtERMSAllowed.Text))
                {
                    SaveCurrentParams();

                }
                else
                {
                    MessageBox.Show("No son optimos");
                }
            }
        }
        private double chooseFA(double value) {
            

            if (cbxFA.SelectedItem == null)
            {
                return CalculateSigmodea(value);
            }
            else {
                if (cbxFA.SelectedItem.ToString().Equals("SIGMOIDE"))
                {
                    return CalculateSigmodea(value);
                }
                else {
                    if (cbxFA.SelectedItem.ToString().Equals("GAUSIANA"))
                    {
                        return CalculateGaussian(value);
                    }
                    else {
                        return CalculateTanH(value);
                    }

                }
            
            }
        
        }
        
        public double CalculateTanH(double value)
        {
            var result = Math.Tanh(value);
            return result;
        }
        
        public double CalculateGaussian(double value)
        {
            double finalValue = value * value;
            double a = Math.Exp(-finalValue);
            return a;
        }
        private void Restart()
        {
            _network = null;
            chart1.Series["Series1"].Points.Clear();
            txtInputs.Text = "";
            txtOutputs.Text = "";
            txtPatterns.Text = "";
            txtWeigths.Text = "";
            txtConfig.Text = "";
            cbxNoHiddenLayers.SelectedItem = null;
        }
        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart();
        }
    }
}
