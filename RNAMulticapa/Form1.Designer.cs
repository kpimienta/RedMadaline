namespace RNAMulticapa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnTrain = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosEntrenamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backpropagationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reiniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.cbxNoHiddenLayers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeigths = new System.Windows.Forms.TextBox();
            this.btnInitializateTrainParams = new System.Windows.Forms.Button();
            this.txtConfig = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadWeightsThreshold = new System.Windows.Forms.Button();
            this.txtCurrentERMS = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCurrentIteration = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSave = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxFA = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrain
            // 
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrain.Location = new System.Drawing.Point(555, 440);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(102, 53);
            this.btnTrain.TabIndex = 0;
            this.btnTrain.Text = "Entrenar";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(864, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosEntrenamientoToolStripMenuItem,
            this.backpropagationToolStripMenuItem,
            this.reiniciarToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            this.archivoToolStripMenuItem.Click += new System.EventHandler(this.archivoToolStripMenuItem_Click);
            // 
            // cargarDatosEntrenamientoToolStripMenuItem
            // 
            this.cargarDatosEntrenamientoToolStripMenuItem.Name = "cargarDatosEntrenamientoToolStripMenuItem";
            this.cargarDatosEntrenamientoToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.cargarDatosEntrenamientoToolStripMenuItem.Text = "Cargar datos entrenamiento";
            this.cargarDatosEntrenamientoToolStripMenuItem.Click += new System.EventHandler(this.cargarDatosEntrenamientoToolStripMenuItem_Click);
            // 
            // backpropagationToolStripMenuItem
            // 
            this.backpropagationToolStripMenuItem.Name = "backpropagationToolStripMenuItem";
            this.backpropagationToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.backpropagationToolStripMenuItem.Text = "Madaline";
            this.backpropagationToolStripMenuItem.Click += new System.EventHandler(this.backpropagationToolStripMenuItem_Click);
            // 
            // reiniciarToolStripMenuItem
            // 
            this.reiniciarToolStripMenuItem.Name = "reiniciarToolStripMenuItem";
            this.reiniciarToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.reiniciarToolStripMenuItem.Text = "Reiniciar";
            this.reiniciarToolStripMenuItem.Click += new System.EventHandler(this.reiniciarToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(445, 32);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 44;
            this.label8.Text = "No. Iteraciones";
            // 
            // txtNoIterations
            // 
            this.txtNoIterations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoIterations.Location = new System.Drawing.Point(472, 53);
            this.txtNoIterations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoIterations.Name = "txtNoIterations";
            this.txtNoIterations.Size = new System.Drawing.Size(77, 26);
            this.txtNoIterations.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(594, 32);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "ERMS Permitido";
            // 
            // txtERMSAllowed
            // 
            this.txtERMSAllowed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtERMSAllowed.Location = new System.Drawing.Point(626, 53);
            this.txtERMSAllowed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtERMSAllowed.Name = "txtERMSAllowed";
            this.txtERMSAllowed.Size = new System.Drawing.Size(77, 26);
            this.txtERMSAllowed.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 32);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 40;
            this.label4.Text = "RA";
            // 
            // txtLearningRat
            // 
            this.txtLearningRat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLearningRat.Location = new System.Drawing.Point(342, 53);
            this.txtLearningRat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLearningRat.Name = "txtLearningRat";
            this.txtLearningRat.Size = new System.Drawing.Size(77, 26);
            this.txtLearningRat.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 32);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Patrones";
            // 
            // txtPatterns
            // 
            this.txtPatterns.Enabled = false;
            this.txtPatterns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPatterns.Location = new System.Drawing.Point(230, 53);
            this.txtPatterns.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPatterns.Name = "txtPatterns";
            this.txtPatterns.Size = new System.Drawing.Size(77, 26);
            this.txtPatterns.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Salidas";
            // 
            // txtOutputs
            // 
            this.txtOutputs.Enabled = false;
            this.txtOutputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputs.Location = new System.Drawing.Point(116, 53);
            this.txtOutputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOutputs.Name = "txtOutputs";
            this.txtOutputs.Size = new System.Drawing.Size(74, 26);
            this.txtOutputs.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Entradas";
            // 
            // txtInputs
            // 
            this.txtInputs.Enabled = false;
            this.txtInputs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputs.Location = new System.Drawing.Point(18, 53);
            this.txtInputs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputs.Name = "txtInputs";
            this.txtInputs.Size = new System.Drawing.Size(73, 26);
            this.txtInputs.TabIndex = 33;
            // 
            // cbxNoHiddenLayers
            // 
            this.cbxNoHiddenLayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNoHiddenLayers.FormattingEnabled = true;
            this.cbxNoHiddenLayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbxNoHiddenLayers.Location = new System.Drawing.Point(18, 130);
            this.cbxNoHiddenLayers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxNoHiddenLayers.Name = "cbxNoHiddenLayers";
            this.cbxNoHiddenLayers.Size = new System.Drawing.Size(48, 28);
            this.cbxNoHiddenLayers.TabIndex = 47;
            this.cbxNoHiddenLayers.SelectedIndexChanged += new System.EventHandler(this.cbxNoHiddenLayers_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "No. Capas Ocultas";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtWeigths
            // 
            this.txtWeigths.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeigths.Location = new System.Drawing.Point(9, 289);
            this.txtWeigths.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtWeigths.Multiline = true;
            this.txtWeigths.Name = "txtWeigths";
            this.txtWeigths.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWeigths.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtWeigths.Size = new System.Drawing.Size(361, 209);
            this.txtWeigths.TabIndex = 45;
            // 
            // btnInitializateTrainParams
            // 
            this.btnInitializateTrainParams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInitializateTrainParams.Location = new System.Drawing.Point(9, 224);
            this.btnInitializateTrainParams.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInitializateTrainParams.Name = "btnInitializateTrainParams";
            this.btnInitializateTrainParams.Size = new System.Drawing.Size(151, 46);
            this.btnInitializateTrainParams.TabIndex = 49;
            this.btnInitializateTrainParams.Text = "Inicializar Pesos y Umbrales";
            this.btnInitializateTrainParams.UseVisualStyleBackColor = true;
            this.btnInitializateTrainParams.Click += new System.EventHandler(this.btnInitializateTrainParams_Click);
            // 
            // txtConfig
            // 
            this.txtConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfig.Location = new System.Drawing.Point(172, 107);
            this.txtConfig.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtConfig.Multiline = true;
            this.txtConfig.Name = "txtConfig";
            this.txtConfig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConfig.Size = new System.Drawing.Size(198, 113);
            this.txtConfig.TabIndex = 50;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 173);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 46);
            this.button1.TabIndex = 51;
            this.button1.Text = "Ver datos de entrenamiento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadWeightsThreshold
            // 
            this.loadWeightsThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadWeightsThreshold.Location = new System.Drawing.Point(199, 224);
            this.loadWeightsThreshold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadWeightsThreshold.Name = "loadWeightsThreshold";
            this.loadWeightsThreshold.Size = new System.Drawing.Size(151, 46);
            this.loadWeightsThreshold.TabIndex = 52;
            this.loadWeightsThreshold.Text = "Cargar Pesos y Umbrales";
            this.loadWeightsThreshold.UseVisualStyleBackColor = true;
            this.loadWeightsThreshold.Click += new System.EventHandler(this.loadWeightsThreshold_Click);
            // 
            // txtCurrentERMS
            // 
            this.txtCurrentERMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentERMS.Location = new System.Drawing.Point(675, 121);
            this.txtCurrentERMS.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentERMS.Name = "txtCurrentERMS";
            this.txtCurrentERMS.Size = new System.Drawing.Size(142, 26);
            this.txtCurrentERMS.TabIndex = 82;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(688, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 81;
            this.label11.Text = "ERMS Actual";
            // 
            // txtCurrentIteration
            // 
            this.txtCurrentIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentIteration.Location = new System.Drawing.Point(542, 122);
            this.txtCurrentIteration.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCurrentIteration.Name = "txtCurrentIteration";
            this.txtCurrentIteration.Size = new System.Drawing.Size(77, 26);
            this.txtCurrentIteration.TabIndex = 80;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(521, 99);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 20);
            this.label10.TabIndex = 79;
            this.label10.Text = "Iteración Actual";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(539, 152);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(278, 204);
            this.chart1.TabIndex = 78;
            this.chart1.Text = "chart1";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(675, 440);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 53);
            this.btnSave.TabIndex = 83;
            this.btnSave.Text = "Guardar pesos y umbrales actuales";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 107);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 85;
            this.label6.Text = "FA Capa Salida";
            // 
            // cbxFA
            // 
            this.cbxFA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFA.FormattingEnabled = true;
            this.cbxFA.Items.AddRange(new object[] {
            "SIGMOIDE",
            "GAUSIANA",
            "TANH"});
            this.cbxFA.Location = new System.Drawing.Point(377, 130);
            this.cbxFA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbxFA.Name = "cbxFA";
            this.cbxFA.Size = new System.Drawing.Size(89, 28);
            this.cbxFA.TabIndex = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(864, 509);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbxFA);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrentERMS);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCurrentIteration);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.loadWeightsThreshold);
            this.Controls.Add(this.button1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosEntrenamientoToolStripMenuItem;
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
        private System.Windows.Forms.ComboBox cbxNoHiddenLayers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWeigths;
        private System.Windows.Forms.Button btnInitializateTrainParams;
        private System.Windows.Forms.TextBox txtConfig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button loadWeightsThreshold;
        private System.Windows.Forms.ToolStripMenuItem backpropagationToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCurrentERMS;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCurrentIteration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxFA;
        private System.Windows.Forms.ToolStripMenuItem reiniciarToolStripMenuItem;
    }
}

