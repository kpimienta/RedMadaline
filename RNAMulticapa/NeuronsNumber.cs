using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RNAMulticapa
{
    public partial class NeuronsNumber : Form
    {
        IReceptorNeuronsNumber receptorNeuronsNumber;
        int _currentLayer;
        public NeuronsNumber()
        {
            InitializeComponent();
        }
        public NeuronsNumber(int currentLayer, IReceptorNeuronsNumber receptor)
        {
            InitializeComponent();
            lblHiddenLayer.Text = $"CAPA OCULTA {currentLayer+1}";
            receptorNeuronsNumber = receptor;
            _currentLayer = currentLayer;
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            int neuronNumber=0;
            try
            {
                neuronNumber = Int32.Parse(txtNoNeurons.Text);
            }
            catch (Exception)
            {

            }
            if (neuronNumber > 0) {
                if (comboBox1.SelectedItem!=null)
                {
                    receptorNeuronsNumber.receive(_currentLayer, neuronNumber, comboBox1.SelectedItem.ToString());
                    this.Close();
                }
            }
        }

        private void NeuronsNumber_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
