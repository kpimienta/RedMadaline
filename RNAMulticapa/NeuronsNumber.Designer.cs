namespace RNAMulticapa
{
    partial class NeuronsNumber
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoNeurons = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHiddenLayer = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de neuronas";
            // 
            // txtNoNeurons
            // 
            this.txtNoNeurons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoNeurons.Location = new System.Drawing.Point(62, 80);
            this.txtNoNeurons.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoNeurons.Name = "txtNoNeurons";
            this.txtNoNeurons.Size = new System.Drawing.Size(105, 26);
            this.txtNoNeurons.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(136, 194);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(82, 34);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Función de Activación";
            // 
            // lblHiddenLayer
            // 
            this.lblHiddenLayer.AutoSize = true;
            this.lblHiddenLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiddenLayer.Location = new System.Drawing.Point(36, 15);
            this.lblHiddenLayer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHiddenLayer.Name = "lblHiddenLayer";
            this.lblHiddenLayer.Size = new System.Drawing.Size(51, 20);
            this.lblHiddenLayer.TabIndex = 5;
            this.lblHiddenLayer.Text = "Capa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SIGMOIDE",
            "GAUSIANA",
            "TANH"});
            this.comboBox1.Location = new System.Drawing.Point(62, 154);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(105, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // NeuronsNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(230, 245);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblHiddenLayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtNoNeurons);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NeuronsNumber";
            this.Text = "NeuronsNumber";
            this.Load += new System.EventHandler(this.NeuronsNumber_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNoNeurons;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHiddenLayer;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}