namespace IrisVisualisationApp
{
    partial class IrisApp
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.FilePathTextBox = new System.Windows.Forms.TextBox();
            this.sepal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.sepal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_length = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.petal_width = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PieDist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieDist)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(428, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 109);
            this.textBox1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(330, 494);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(113, 42);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // FilePathTextBox
            // 
            this.FilePathTextBox.Location = new System.Drawing.Point(624, 12);
            this.FilePathTextBox.Name = "FilePathTextBox";
            this.FilePathTextBox.Size = new System.Drawing.Size(272, 20);
            this.FilePathTextBox.TabIndex = 2;
            this.FilePathTextBox.Text = "D:\\labs(sem3)\\lab4\\lab3\\LinearAlgebra\\iris.csv";
            // 
            // sepal_length
            // 
            chartArea6.Name = "ChartArea1";
            this.sepal_length.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.sepal_length.Legends.Add(legend6);
            this.sepal_length.Location = new System.Drawing.Point(6, 49);
            this.sepal_length.Name = "sepal_length";
            this.sepal_length.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.sepal_length.Series.Add(series6);
            this.sepal_length.Size = new System.Drawing.Size(292, 246);
            this.sepal_length.TabIndex = 3;
            this.sepal_length.Text = "chart1";
            // 
            // sepal_width
            // 
            chartArea7.Name = "ChartArea1";
            this.sepal_width.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.sepal_width.Legends.Add(legend7);
            this.sepal_width.Location = new System.Drawing.Point(665, 75);
            this.sepal_width.Name = "sepal_width";
            this.sepal_width.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.sepal_width.Series.Add(series7);
            this.sepal_width.Size = new System.Drawing.Size(308, 239);
            this.sepal_width.TabIndex = 4;
            this.sepal_width.Text = "chart2";
            this.sepal_width.Click += new System.EventHandler(this.chart2_Click);
            // 
            // petal_length
            // 
            chartArea8.Name = "ChartArea1";
            this.petal_length.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.petal_length.Legends.Add(legend8);
            this.petal_length.Location = new System.Drawing.Point(6, 314);
            this.petal_length.Name = "petal_length";
            this.petal_length.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.petal_length.Series.Add(series8);
            this.petal_length.Size = new System.Drawing.Size(292, 209);
            this.petal_length.TabIndex = 5;
            this.petal_length.Text = "chart3";
            // 
            // petal_width
            // 
            chartArea9.Name = "ChartArea1";
            this.petal_width.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.petal_width.Legends.Add(legend9);
            this.petal_width.Location = new System.Drawing.Point(665, 341);
            this.petal_width.Name = "petal_width";
            this.petal_width.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.petal_width.Series.Add(series9);
            this.petal_width.Size = new System.Drawing.Size(308, 209);
            this.petal_width.TabIndex = 6;
            this.petal_width.Text = "chart4";
            // 
            // PieDist
            // 
            this.PieDist.AllowDrop = true;
            chartArea10.Name = "ChartArea1";
            this.PieDist.ChartAreas.Add(chartArea10);
            legend10.MaximumAutoSize = 100F;
            legend10.Name = "Legend1";
            this.PieDist.Legends.Add(legend10);
            this.PieDist.Location = new System.Drawing.Point(321, 145);
            this.PieDist.Name = "PieDist";
            this.PieDist.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series10.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            series10.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            this.PieDist.Series.Add(series10);
            this.PieDist.Size = new System.Drawing.Size(322, 299);
            this.PieDist.TabIndex = 7;
            this.PieDist.Text = "chart1";
            // 
            // IrisApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 562);
            this.Controls.Add(this.PieDist);
            this.Controls.Add(this.petal_width);
            this.Controls.Add(this.petal_length);
            this.Controls.Add(this.sepal_width);
            this.Controls.Add(this.sepal_length);
            this.Controls.Add(this.FilePathTextBox);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.textBox1);
            this.Name = "IrisApp";
            this.Text = "IrisApp";
            this.Load += new System.EventHandler(this.IrisApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sepal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petal_width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PieDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.TextBox FilePathTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart sepal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart petal_length;
        private System.Windows.Forms.DataVisualization.Charting.Chart petal_width;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieDist;
    }
}

