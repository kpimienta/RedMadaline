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

namespace RNAMulticapa
{
    public partial class TrainData : Form
    {
        Network _network;
        public TrainData()
        {
            InitializeComponent();
        }
        public TrainData(Network network)
        {
            InitializeComponent();
            _network = network;
            FillDataGridTrainData(_network);
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void FillDataGridTrainData(Network network)
        {
            int totalColumns = network.NoInputs + network.NoOutputs;
            dgDatos.ColumnCount = totalColumns;
            for (int i = 0; i < network.NoInputs; i++)
            {
                dgDatos.Columns[i].Name = "X" + (i + 1);
            }
            for (int i = network.NoInputs; i < totalColumns; i++)
            {
                dgDatos.Columns[i].Name = "YR" + (i - (network.NoInputs - 1));
            }
            dgDatos.Rows.Clear();
            int n = 0;
            for (int i = 0; i < network.NoPatterns; i++)
            {
                dgDatos.Rows.Add();
                for (int j = 0; j < network.NoInputs; j++)
                {
                    Console.WriteLine("i: " + i + " j: " + j);
                    dgDatos.Rows[i].Cells[j].Value = network.InputsPatterns[i, j];
                }
                for (int k = network.NoInputs; k < totalColumns; k++)
                {
                    Console.WriteLine("total: " + totalColumns + " k: " + k);
                    dgDatos.Rows[i].Cells[k].Value = network.OutputsPatterns[i, (k - (network.NoInputs))];
                }
            }
        }
    }
}
