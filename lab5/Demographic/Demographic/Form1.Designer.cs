namespace Demographic
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.AgeFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DeathFilePathTextBox = new System.Windows.Forms.TextBox();
            this.StartYearTextBox = new System.Windows.Forms.TextBox();
            this.FinishYearTextBox = new System.Windows.Forms.TextBox();
            this.PopulationNumberTextBox = new System.Windows.Forms.TextBox();
            this.PopulationChange = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PopulationChangeMales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PopulationChangeFemales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FemaleAgeDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MaleAgeDistribution = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChangeMales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChangeFemales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleAgeDistribution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaleAgeDistribution)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(992, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "StartModel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgeFilePathTextBox
            // 
            this.AgeFilePathTextBox.Location = new System.Drawing.Point(957, 15);
            this.AgeFilePathTextBox.Name = "AgeFilePathTextBox";
            this.AgeFilePathTextBox.Size = new System.Drawing.Size(156, 20);
            this.AgeFilePathTextBox.TabIndex = 1;
            // 
            // DeathFilePathTextBox
            // 
            this.DeathFilePathTextBox.Location = new System.Drawing.Point(957, 41);
            this.DeathFilePathTextBox.Name = "DeathFilePathTextBox";
            this.DeathFilePathTextBox.Size = new System.Drawing.Size(156, 20);
            this.DeathFilePathTextBox.TabIndex = 2;
            // 
            // StartYearTextBox
            // 
            this.StartYearTextBox.Location = new System.Drawing.Point(992, 121);
            this.StartYearTextBox.Name = "StartYearTextBox";
            this.StartYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.StartYearTextBox.TabIndex = 4;
            this.StartYearTextBox.Text = "1970";
            // 
            // FinishYearTextBox
            // 
            this.FinishYearTextBox.Location = new System.Drawing.Point(992, 162);
            this.FinishYearTextBox.Name = "FinishYearTextBox";
            this.FinishYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.FinishYearTextBox.TabIndex = 5;
            this.FinishYearTextBox.Text = "2021";
            // 
            // PopulationNumberTextBox
            // 
            this.PopulationNumberTextBox.Location = new System.Drawing.Point(992, 205);
            this.PopulationNumberTextBox.Name = "PopulationNumberTextBox";
            this.PopulationNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.PopulationNumberTextBox.TabIndex = 6;
            this.PopulationNumberTextBox.Text = "130";
            // 
            // PopulationChange
            // 
            chartArea1.Name = "ChartArea1";
            this.PopulationChange.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PopulationChange.Legends.Add(legend1);
            this.PopulationChange.Location = new System.Drawing.Point(28, 12);
            this.PopulationChange.Name = "PopulationChange";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PopulationChange.Series.Add(series1);
            this.PopulationChange.Size = new System.Drawing.Size(583, 317);
            this.PopulationChange.TabIndex = 7;
            this.PopulationChange.Text = "chart1";
            // 
            // PopulationChangeMales
            // 
            chartArea2.Name = "ChartArea1";
            this.PopulationChangeMales.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.PopulationChangeMales.Legends.Add(legend2);
            this.PopulationChangeMales.Location = new System.Drawing.Point(617, 12);
            this.PopulationChangeMales.Name = "PopulationChangeMales";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.PopulationChangeMales.Series.Add(series2);
            this.PopulationChangeMales.Size = new System.Drawing.Size(334, 317);
            this.PopulationChangeMales.TabIndex = 8;
            this.PopulationChangeMales.Text = "chart2";
            // 
            // PopulationChangeFemales
            // 
            chartArea3.Name = "ChartArea1";
            this.PopulationChangeFemales.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.PopulationChangeFemales.Legends.Add(legend3);
            this.PopulationChangeFemales.Location = new System.Drawing.Point(28, 335);
            this.PopulationChangeFemales.Name = "PopulationChangeFemales";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.PopulationChangeFemales.Series.Add(series3);
            this.PopulationChangeFemales.Size = new System.Drawing.Size(368, 247);
            this.PopulationChangeFemales.TabIndex = 9;
            this.PopulationChangeFemales.Text = "chart3";
            // 
            // FemaleAgeDistribution
            // 
            chartArea4.Name = "ChartArea1";
            this.FemaleAgeDistribution.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.FemaleAgeDistribution.Legends.Add(legend4);
            this.FemaleAgeDistribution.Location = new System.Drawing.Point(752, 335);
            this.FemaleAgeDistribution.Name = "FemaleAgeDistribution";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.FemaleAgeDistribution.Series.Add(series4);
            this.FemaleAgeDistribution.Size = new System.Drawing.Size(320, 247);
            this.FemaleAgeDistribution.TabIndex = 10;
            this.FemaleAgeDistribution.Text = "chart4";
            // 
            // MaleAgeDistribution
            // 
            chartArea5.Name = "ChartArea1";
            this.MaleAgeDistribution.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.MaleAgeDistribution.Legends.Add(legend5);
            this.MaleAgeDistribution.Location = new System.Drawing.Point(416, 335);
            this.MaleAgeDistribution.Name = "MaleAgeDistribution";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.MaleAgeDistribution.Series.Add(series5);
            this.MaleAgeDistribution.Size = new System.Drawing.Size(311, 247);
            this.MaleAgeDistribution.TabIndex = 11;
            this.MaleAgeDistribution.Text = "chart5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 627);
            this.Controls.Add(this.MaleAgeDistribution);
            this.Controls.Add(this.FemaleAgeDistribution);
            this.Controls.Add(this.PopulationChangeFemales);
            this.Controls.Add(this.PopulationChangeMales);
            this.Controls.Add(this.PopulationChange);
            this.Controls.Add(this.PopulationNumberTextBox);
            this.Controls.Add(this.FinishYearTextBox);
            this.Controls.Add(this.StartYearTextBox);
            this.Controls.Add(this.DeathFilePathTextBox);
            this.Controls.Add(this.AgeFilePathTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChangeMales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PopulationChangeFemales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FemaleAgeDistribution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaleAgeDistribution)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AgeFilePathTextBox;
        private System.Windows.Forms.TextBox DeathFilePathTextBox;
        private System.Windows.Forms.TextBox StartYearTextBox;
        private System.Windows.Forms.TextBox FinishYearTextBox;
        private System.Windows.Forms.TextBox PopulationNumberTextBox;
        public System.Windows.Forms.DataVisualization.Charting.Chart PopulationChange;
        public System.Windows.Forms.DataVisualization.Charting.Chart PopulationChangeMales;
        public System.Windows.Forms.DataVisualization.Charting.Chart PopulationChangeFemales;
        private System.Windows.Forms.DataVisualization.Charting.Chart FemaleAgeDistribution;
        private System.Windows.Forms.DataVisualization.Charting.Chart MaleAgeDistribution;
    }
}

