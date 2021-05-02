namespace RNAMulticapa
{
    partial class SimulateBackpropagation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadDataSimulation = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgSP = new System.Windows.Forms.DataGridView();
            this.dgOutputs = new System.Windows.Forms.DataGridView();
            this.btnSimular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadDataSimulation
            // 
            this.btnLoadDataSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadDataSimulation.Location = new System.Drawing.Point(291, 25);
            this.btnLoadDataSimulation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadDataSimulation.Name = "btnLoadDataSimulation";
            this.btnLoadDataSimulation.Size = new System.Drawing.Size(135, 40);
            this.btnLoadDataSimulation.TabIndex = 0;
            this.btnLoadDataSimulation.Text = "Cargar Datos Para Simulacion";
            this.btnLoadDataSimulation.UseVisualStyleBackColor = true;
            this.btnLoadDataSimulation.Click += new System.EventHandler(this.btnLoadDataSimulation_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(62, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cargar Red";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Patrones para la Simulación";
            // 
            // dgSP
            // 
            this.dgSP.AllowUserToAddRows = false;
            this.dgSP.AllowUserToDeleteRows = false;
            this.dgSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSP.Location = new System.Drawing.Point(9, 109);
            this.dgSP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgSP.Name = "dgSP";
            this.dgSP.RowHeadersWidth = 51;
            this.dgSP.RowTemplate.Height = 24;
            this.dgSP.Size = new System.Drawing.Size(298, 214);
            this.dgSP.TabIndex = 28;
            // 
            // dgOutputs
            // 
            this.dgOutputs.AllowUserToAddRows = false;
            this.dgOutputs.AllowUserToDeleteRows = false;
            this.dgOutputs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOutputs.Location = new System.Drawing.Point(483, 109);
            this.dgOutputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgOutputs.Name = "dgOutputs";
            this.dgOutputs.RowHeadersWidth = 51;
            this.dgOutputs.RowTemplate.Height = 24;
            this.dgOutputs.Size = new System.Drawing.Size(225, 210);
            this.dgOutputs.TabIndex = 30;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(320, 353);
            this.btnSimular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(124, 40);
            this.btnSimular.TabIndex = 31;
            this.btnSimular.Text = "Simulación";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // SimulateBackpropagation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(748, 431);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.dgOutputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgSP);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLoadDataSimulation);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SimulateBackpropagation";
            this.Text = "SimulateMadaline";
            ((System.ComponentModel.ISupportInitialize)(this.dgSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOutputs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadDataSimulation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgSP;
        private System.Windows.Forms.DataGridView dgOutputs;
        private System.Windows.Forms.Button btnSimular;
    }
}