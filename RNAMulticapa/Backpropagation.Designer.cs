namespace RNAMulticapa
{
    partial class Backpropagation
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnShowDataTrain = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxNoHiddenLayers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoIterations = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtERMSAllowed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLearningRat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatterns = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputs = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCurrentERMS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrentIteration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInitializateNetwork = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInitializateTrainParams = new System.Windows.Forms.Button();
            this.loadWeightsThreshold = new System.Windows.Forms.Button();
            this.txtWeigths = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(667, 505);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(106, 49);
            this.btnTrain.TabIndex = 1;
            this.btnTrain.Text = "Entrenar";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnShowDataTrain
            // 
            this.btnShowDataTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDataTrain.Location = new System.Drawing.Point(9, 182);
            this.btnShowDataTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDataTrain.Name = "btnShowDataTrain";
            this.btnShowDataTrain.Size = new System.Drawing.Size(151, 46);
            this.btnShowDataTrain.TabIndex = 70;
            this.btnShowDataTrain.Text = "Ver datos de entrenamiento";
            this.btnShowDataTrain.UseVisualStyleBackColor = true;
            this.btnShowDataTrain.Click += new System.EventHandler(this.btnShowDataTrain_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfig.Location = new System.Drawing.Point(172, 116);
            this.txtConfig.Margin = new System.Windows.Forms.Padding(2);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfig.Size = new System.Drawing.Size(198, 113);
            this.txtConfig.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "No. Capas Ocultas";
            // 
            // cbxNoHiddenLayers
            // 
            this.cbxNoHiddenLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNoHiddenLayers.FormattingEnabled = true;
            this.cbxNoHiddenLayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxNoHiddenLayers.Location = new System.Drawing.Point(18, 139);
            this.cbxNoHiddenLayers.Margin = new System.Windows.Forms.Padding(2);
            this.cbxNoHiddenLayers.Name = "cbxNoHiddenLayers";
            this.cbxNoHiddenLayers.Size = new System.Drawing.Size(48, 28);
            this.cbxNoHiddenLayers.TabIndex = 66;
            this.cbxNoHiddenLayers.SelectedIndexChanged += new System.EventHandler(this.cbxNoHiddenLayers_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(448, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 20);
            this.label8.TabIndex = 64;
            this.label8.Text = "No. Iteraciones";
            // 
            // txtNoIterations
            // 
            this.txtNoIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoIterations.Location = new System.Drawing.Point(451, 62);
            this.txtNoIterations.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoIterations.Name = "txtNoIterations";
            this.txtNoIterations.Size = new System.Drawing.Size(77, 26);
            this.txtNoIterations.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(562, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "ERMS Permitido";
            // 
            // txtERMSAllowed
            // 
            this.txtERMSAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtERMSAllowed.Location = new System.Drawing.Point(566, 62);
            this.txtERMSAllowed.Margin = new System.Windows.Forms.Padding(2);
            this.txtERMSAllowed.Name = "txtERMSAllowed";
            this.txtERMSAllowed.Size = new System.Drawing.Size(77, 26);
            this.txtERMSAllowed.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(340, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "RA";
            // 
            // txtLearningRat
            // 
            this.txtLearningRat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRat.Location = new System.Drawing.Point(342, 62);
            this.txtLearningRat.Margin = new System.Windows.Forms.Padding(2);
            this.txtLearningRat.Name = "txtLearningRat";
            this.txtLearningRat.Size = new System.Drawing.Size(77, 26);
            this.txtLearningRat.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Patrones";
            // 
            // txtPatterns
            // 
            this.txtPatterns.Enabled = false;
            this.txtPatterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatterns.Location = new System.Drawing.Point(230, 62);
            this.txtPatterns.Margin = new System.Windows.Forms.Padding(2);
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(77, 26);
            this.txtPatterns.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Salidas";
            // 
            // txtOutputs
            // 
            this.txtOutputs.Enabled = false;
            this.txtOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputs.Location = new System.Drawing.Point(125, 62);
            this.txtOutputs.Margin = new System.Windows.Forms.Padding(2);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.Size = new System.Drawing.Size(74, 26);
            this.txtOutputs.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 54;
            this.label1.Text = "Entradas";
            // 
            // txtInputs
            // 
            this.txtInputs.Enabled = false;
            this.txtInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputs.Location = new System.Drawing.Point(18, 62);
            this.txtInputs.Margin = new System.Windows.Forms.Padding(2);
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(73, 26);
            this.txtInputs.TabIndex = 53;
            this.txtInputs.TextChanged += new System.EventHandler(this.txtInputs_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarEntrenamientoToolStripMenuItem,
            this.simularToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cargarEntrenamientoToolStripMenuItem
            // 
            this.cargarEntrenamientoToolStripMenuItem.Name = "cargarEntrenamientoToolStripMenuItem";
            this.cargarEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.cargarEntrenamientoToolStripMenuItem.Text = "Cargar entrenamiento";
            this.cargarEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.cargarEntrenamientoToolStripMenuItem_Click);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(466, 164);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(364, 283);
            this.chart1.TabIndex = 73;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // txtCurrentERMS
            // 
            this.txtCurrentERMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentERMS.Location = new System.Drawing.Point(602, 135);
            this.txtCurrentERMS.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentERMS.Name = "txtCurrentERMS";
            this.txtCurrentERMS.Size = new System.Drawing.Size(228, 26);
            this.txtCurrentERMS.TabIndex = 77;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(598, 112);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 76;
            this.label11.Text = "ERMS Actual";
            // 
            // txtCurrentIteration
            // 
            this.txtCurrentIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentIteration.Location = new System.Drawing.Point(488, 135);
            this.txtCurrentIteration.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentIteration.Name = "txtCurrentIteration";
            this.txtCurrentIteration.Size = new System.Drawing.Size(77, 26);
            this.txtCurrentIteration.TabIndex = 75;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(468, 112);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Iteración Actual";
            // 
            // btnInitializateNetwork
            // 
            this.btnInitializateNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializateNetwork.Location = new System.Drawing.Point(496, 505);
            this.btnInitializateNetwork.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitializateNetwork.Name = "btnInitializateNetwork";
            this.btnInitializateNetwork.Size = new System.Drawing.Size(112, 49);
            this.btnInitializateNetwork.TabIndex = 78;
            this.btnInitializateNetwork.Text = "Inicializar entrenamiento";
            this.btnInitializateNetwork.UseVisualStyleBackColor = true;
            this.btnInitializateNetwork.Click += new System.EventHandler(this.btnInitializateNetwork_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(667, 452);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 79;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInitializateTrainParams
            // 
            this.btnInitializateTrainParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializateTrainParams.Location = new System.Drawing.Point(9, 233);
            this.btnInitializateTrainParams.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitializateTrainParams.Name = "btnInitializateTrainParams";
            this.btnInitializateTrainParams.Size = new System.Drawing.Size(151, 46);
            this.btnInitializateTrainParams.TabIndex = 68;
            this.btnInitializateTrainParams.Text = "Inicializar Pesos y Umbrales";
            this.btnInitializateTrainParams.UseVisualStyleBackColor = true;
            this.btnInitializateTrainParams.Click += new System.EventHandler(this.btnInitializateTrainParams_Click);
            // 
            // loadWeightsThreshold
            // 
            this.loadWeightsThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWeightsThreshold.Location = new System.Drawing.Point(172, 233);
            this.loadWeightsThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.loadWeightsThreshold.Name = "loadWeightsThreshold";
            this.loadWeightsThreshold.Size = new System.Drawing.Size(151, 46);
            this.loadWeightsThreshold.TabIndex = 71;
            this.loadWeightsThreshold.Text = "Cargar Pesos y Umbrales";
            this.loadWeightsThreshold.UseVisualStyleBackColor = true;
            this.loadWeightsThreshold.Click += new System.EventHandler(this.loadWeightsThreshold_Click);
            // 
            // txtWeigths
            // 
            this.txtWeigths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeigths.Location = new System.Drawing.Point(9, 292);
            this.txtWeigths.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeigths.Multiline = true;
            this.txtWeigths.Name = "txtWeigths";
            this.txtWeigths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWeigths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWeigths.Size = new System.Drawing.Size(361, 209);
            this.txtWeigths.TabIndex = 65;
            this.txtWeigths.TextChanged += new System.EventHandler(this.txtWeigths_TextChanged);
            // 
            // Backpropagation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(838, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnInitializateNetwork);
            this.Controls.Add(this.txtCurrentERMS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurrentIteration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.loadWeightsThreshold);
            this.Controls.Add(this.btnShowDataTrain);
            this.Controls.Add(this.txtConfig);
            this.Controls.Add(this.btnInitializateTrainParams);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxNoHiddenLayers);
            this.Controls.Add(this.txtWeigths);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoIterations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtERMSAllowed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLearningRat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPatterns);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInputs);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Backpropagation";
            this.Text = "Madaline";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnShowDataTrain;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxNoHiddenLayers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoIterations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtERMSAllowed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLearningRat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatterns;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputs;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarEntrenamientoToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox txtCurrentERMS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrentIteration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInitializateNetwork;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.Button btnInitializateTrainParams;
        private System.Windows.Forms.Button loadWeightsThreshold;
        private System.Windows.Forms.TextBox txtWeigths;
    }
}