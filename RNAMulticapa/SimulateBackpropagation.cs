using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace RNAMulticapa
{
    public partial class SimulateBackpropagation : Form
    {
        NetworkService networkService;
        Backpropagation.Perceptron perceptron;
        double[,] simulationPatterns;
        public SimulateBackpropagation()
        {
            InitializeComponent();
            networkService = new NetworkService();
        }
        public SimulateBackpropagation(Backpropagation backpropagation)
        {
            InitializeComponent();
            networkService = new NetworkService();
        }
        public Backpropagation.Perceptron LoadFile(string fileName)
        {
            FileStream fileStream = null;
            Backpropagation.Perceptron p = null;
            try
            {
                fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryFormatter deserializer = new BinaryFormatter();
                p = (Backpropagation.Perceptron)deserializer.Deserialize(fileStream);
            }
            catch (Exception e)
            {
                Console.WriteLine("There's been an error. Here is the message: " + e.Message);
            }
            finally
            {
                if (fileStream != null)
                {
                    fileStream.Close();
                }
            }
            return p;
        }
        private void btnLoadDataSimulation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    simulationPatterns = networkService.ReadSimulationPatterns(openFileDialog.FileName);
                    FillDataGridSP(simulationPatterns);
                }
                catch (Exception)
                {
                    MessageBox.Show("No se pudo cargar el archivo");
                }

            }
        }
        private List<double[]> convertToList(double [,] a) {
            List<double[]> lista = new List<double[]>();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                double[] b = new double[a.GetLength(1)];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    b[j] = a[i, j];
                }
                lista.Add(b);
            }
            return lista;
        }
        void CalculateOutputs() {
            if (perceptron != null) { 
                var patterns = convertToList(simulationPatterns);
                dgOutputs.Rows.Clear();
                dgOutputs.ColumnCount = patterns.Count;
                for (int i = 0; i < patterns.Count; i++)
                {
                    dgOutputs.Rows.Add();
                    var d= perceptron.Activate(patterns[i]);
                    for (int j = 0; j < d.Length; j++)
                    {
                        dgOutputs.Rows[i].Cells[j].Value = d[j];
                    }
                    
                }
            }
        }
        //public void FillDataGridOutput()
        //{
        //    dgOutputs.Rows.Clear();
        //    dgOutputs.ColumnCount = trainParams.Threshold.Length;
        //    for (int i = 0; i < simulationPatterns.GetLength(0); i++)
        //    {
        //        dgOutputs.Rows.Add();
        //        double[] res = networkService.simulateNetwork(trainParams, GetVector(simulationPatterns, i));
        //        for (int j = 0; j < res.Length; j++)
        //        {
        //            dgOutputs.Rows[i].Cells[j].Value = res[j];
        //        }
        //    }
        //}
        private void FillDataGridSP(double[,] a)
        {
            int totalColumns = a.GetLength(1);
            int totalRows = a.GetLength(0);
            dgSP.ColumnCount = totalColumns;
            for (int i = 0; i < totalColumns; i++)
            {
                dgSP.Columns[i].Name = "X" + (i + 1);
            }

            dgSP.Rows.Clear();
            int n = 0;
            for (int i = 0; i < totalRows; i++)
            {
                dgSP.Rows.Add();
                for (int j = 0; j < totalColumns; j++)
                {
                    Console.WriteLine("i: " + i + " j: " + j);
                    dgSP.Rows[i].Cells[j].Value = a[i, j];
                    Console.WriteLine(a[i, j]);
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                perceptron = LoadFile(openFileDialog.FileName);
                if (LoadFile(openFileDialog.FileName) == null) {
                    MessageBox.Show("fuck");
                }
            }
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            CalculateOutputs();
        }
    }
}
