namespace pso_ai_
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nudParcacik = new System.Windows.Forms.NumericUpDown();
            this.nudJenerasyon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudC1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudC2 = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcacik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJenerasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parçacık Sayısı :";
            // 
            // nudParcacik
            // 
            this.nudParcacik.Location = new System.Drawing.Point(287, 46);
            this.nudParcacik.Name = "nudParcacik";
            this.nudParcacik.Size = new System.Drawing.Size(161, 31);
            this.nudParcacik.TabIndex = 1;
            this.nudParcacik.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudJenerasyon
            // 
            this.nudJenerasyon.Location = new System.Drawing.Point(287, 88);
            this.nudJenerasyon.Name = "nudJenerasyon";
            this.nudJenerasyon.Size = new System.Drawing.Size(161, 31);
            this.nudJenerasyon.TabIndex = 3;
            this.nudJenerasyon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenerasyon Sayısı :";
            // 
            // nudC1
            // 
            this.nudC1.Location = new System.Drawing.Point(620, 46);
            this.nudC1.Name = "nudC1";
            this.nudC1.Size = new System.Drawing.Size(161, 31);
            this.nudC1.TabIndex = 5;
            this.nudC1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "C1 : ";
            // 
            // nudC2
            // 
            this.nudC2.Location = new System.Drawing.Point(620, 89);
            this.nudC2.Name = "nudC2";
            this.nudC2.Size = new System.Drawing.Size(161, 31);
            this.nudC2.TabIndex = 7;
            this.nudC2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(489, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 25);
            this.label.TabIndex = 6;
            this.label.Text = "C2 : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.SlateGray;
            this.btnHesapla.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHesapla.FlatAppearance.BorderSize = 3;
            this.btnHesapla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btnHesapla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnHesapla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHesapla.Location = new System.Drawing.Point(54, 153);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(723, 41);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Silver;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(50, 387);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Uygunluk";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(863, 433);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "....";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(81, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Amaç Fonksiyon Değeri : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.nudC1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudParcacik);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHesapla);
            this.groupBox1.Controls.Add(this.nudJenerasyon);
            this.groupBox1.Controls.Add(this.nudC2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(59, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 272);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GİRİŞ DEĞERLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(969, 869);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Parçacık Sürü Optimizasyonu ";
            ((System.ComponentModel.ISupportInitialize)(this.nudParcacik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJenerasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudParcacik;
        private System.Windows.Forms.NumericUpDown nudJenerasyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudC2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

