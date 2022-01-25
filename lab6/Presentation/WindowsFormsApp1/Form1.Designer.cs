namespace PresentationApp
{
    partial class UserInterface
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.VisitorIdTB = new System.Windows.Forms.TextBox();
            this.VisitorNameTB = new System.Windows.Forms.TextBox();
            this.VisitorDiscountTB = new System.Windows.Forms.TextBox();
            this.ExhibitionIdTb = new System.Windows.Forms.TextBox();
            this.ExhibitionNameTb = new System.Windows.Forms.TextBox();
            this.ExhibitionDateTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TicketIdTB = new System.Windows.Forms.TextBox();
            this.TicketVisitorIdTB = new System.Windows.Forms.TextBox();
            this.TicketPriceTB = new System.Windows.Forms.TextBox();
            this.TicketExhinbitonIdTB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.AnalysisIdTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AnalysisResultTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add new visitor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisitorIdTB
            // 
            this.VisitorIdTB.Location = new System.Drawing.Point(12, 88);
            this.VisitorIdTB.Name = "VisitorIdTB";
            this.VisitorIdTB.Size = new System.Drawing.Size(51, 23);
            this.VisitorIdTB.TabIndex = 1;
            this.VisitorIdTB.Text = "0";
            this.VisitorIdTB.TextChanged += new System.EventHandler(this.VisitorIdTB_TextChanged);
            // 
            // VisitorNameTB
            // 
            this.VisitorNameTB.Location = new System.Drawing.Point(96, 54);
            this.VisitorNameTB.Name = "VisitorNameTB";
            this.VisitorNameTB.Size = new System.Drawing.Size(55, 23);
            this.VisitorNameTB.TabIndex = 2;
            // 
            // VisitorDiscountTB
            // 
            this.VisitorDiscountTB.Location = new System.Drawing.Point(184, 54);
            this.VisitorDiscountTB.Name = "VisitorDiscountTB";
            this.VisitorDiscountTB.Size = new System.Drawing.Size(52, 23);
            this.VisitorDiscountTB.TabIndex = 3;
            // 
            // ExhibitionIdTb
            // 
            this.ExhibitionIdTb.Location = new System.Drawing.Point(411, 88);
            this.ExhibitionIdTb.Name = "ExhibitionIdTb";
            this.ExhibitionIdTb.Size = new System.Drawing.Size(51, 23);
            this.ExhibitionIdTb.TabIndex = 1;
            this.ExhibitionIdTb.Text = "0";
            // 
            // ExhibitionNameTb
            // 
            this.ExhibitionNameTb.Location = new System.Drawing.Point(486, 42);
            this.ExhibitionNameTb.Name = "ExhibitionNameTb";
            this.ExhibitionNameTb.Size = new System.Drawing.Size(55, 23);
            this.ExhibitionNameTb.TabIndex = 2;
            // 
            // ExhibitionDateTb
            // 
            this.ExhibitionDateTb.Location = new System.Drawing.Point(578, 42);
            this.ExhibitionDateTb.Name = "ExhibitionDateTb";
            this.ExhibitionDateTb.Size = new System.Drawing.Size(73, 23);
            this.ExhibitionDateTb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(253, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Id =\"0\"  for auto generation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(488, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add new Exhibition";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 275);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(94, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "DIsplay Table";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(96, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "Remove Visitor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(501, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(590, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(488, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 30);
            this.button5.TabIndex = 11;
            this.button5.Text = "Remove Exhibition";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(488, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 38);
            this.button6.TabIndex = 10;
            this.button6.Text = "DIsplay Table";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(775, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 33);
            this.button7.TabIndex = 15;
            this.button7.Text = "Add new Ticket";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(775, 132);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(141, 27);
            this.button8.TabIndex = 16;
            this.button8.Text = "Remove Ticket";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(776, 211);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(140, 37);
            this.button9.TabIndex = 17;
            this.button9.Text = "Display Table";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(690, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(741, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "VisitorId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(812, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "ExhibitionId";
            // 
            // TicketIdTB
            // 
            this.TicketIdTB.Location = new System.Drawing.Point(690, 88);
            this.TicketIdTB.Name = "TicketIdTB";
            this.TicketIdTB.Size = new System.Drawing.Size(47, 23);
            this.TicketIdTB.TabIndex = 21;
            // 
            // TicketVisitorIdTB
            // 
            this.TicketVisitorIdTB.Location = new System.Drawing.Point(753, 41);
            this.TicketVisitorIdTB.Name = "TicketVisitorIdTB";
            this.TicketVisitorIdTB.Size = new System.Drawing.Size(38, 23);
            this.TicketVisitorIdTB.TabIndex = 22;
            // 
            // TicketPriceTB
            // 
            this.TicketPriceTB.Location = new System.Drawing.Point(888, 42);
            this.TicketPriceTB.Name = "TicketPriceTB";
            this.TicketPriceTB.Size = new System.Drawing.Size(64, 23);
            this.TicketPriceTB.TabIndex = 23;
            // 
            // TicketExhinbitonIdTB
            // 
            this.TicketExhinbitonIdTB.Location = new System.Drawing.Point(817, 41);
            this.TicketExhinbitonIdTB.Name = "TicketExhinbitonIdTB";
            this.TicketExhinbitonIdTB.Size = new System.Drawing.Size(52, 23);
            this.TicketExhinbitonIdTB.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(908, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Price";
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(96, 174);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(142, 38);
            this.button10.TabIndex = 26;
            this.button10.Text = "Edit Table";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(776, 165);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(138, 40);
            this.button11.TabIndex = 27;
            this.button11.Text = "Edit Table";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(488, 165);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(144, 40);
            this.button12.TabIndex = 28;
            this.button12.Text = "Edit Table";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(590, 281);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(241, 88);
            this.button13.TabIndex = 29;
            this.button13.Text = "Сколько билетов продано на выставку с указанным идентификатором?";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(590, 375);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(241, 76);
            this.button14.TabIndex = 30;
            this.button14.Text = "На сколько уникальных выставок сходил посетитель с заданным идентификатором?";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(590, 470);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(241, 69);
            this.button15.TabIndex = 31;
            this.button15.Text = "Какой средний процент скидки (Discount) был у посетителей выставки с заданным иде" +
    "нтификатором?";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // AnalysisIdTB
            // 
            this.AnalysisIdTB.Location = new System.Drawing.Point(888, 375);
            this.AnalysisIdTB.Name = "AnalysisIdTB";
            this.AnalysisIdTB.Size = new System.Drawing.Size(100, 23);
            this.AnalysisIdTB.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(924, 354);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 15);
            this.label12.TabIndex = 33;
            this.label12.Text = "Id";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(913, 426);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 15);
            this.label13.TabIndex = 34;
            this.label13.Text = "Result";
            // 
            // AnalysisResultTB
            // 
            this.AnalysisResultTB.Location = new System.Drawing.Point(888, 454);
            this.AnalysisResultTB.Name = "AnalysisResultTB";
            this.AnalysisResultTB.Size = new System.Drawing.Size(100, 23);
            this.AnalysisResultTB.TabIndex = 35;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 568);
            this.Controls.Add(this.AnalysisResultTB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.AnalysisIdTB);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TicketExhinbitonIdTB);
            this.Controls.Add(this.TicketPriceTB);
            this.Controls.Add(this.TicketVisitorIdTB);
            this.Controls.Add(this.TicketIdTB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExhibitionDateTb);
            this.Controls.Add(this.ExhibitionNameTb);
            this.Controls.Add(this.ExhibitionIdTb);
            this.Controls.Add(this.VisitorDiscountTB);
            this.Controls.Add(this.VisitorNameTB);
            this.Controls.Add(this.VisitorIdTB);
            this.Controls.Add(this.button1);
            this.Name = "UserInterface";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox VisitorIdTB;
        private System.Windows.Forms.TextBox VisitorNameTB;
        private System.Windows.Forms.TextBox VisitorDiscountTB;
        private System.Windows.Forms.TextBox ExhibitionIdTb;
        private System.Windows.Forms.TextBox ExhibitionNameTb;
        private System.Windows.Forms.TextBox ExhibitionDateTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TicketIdTB;
        private System.Windows.Forms.TextBox TicketVisitorIdTB;
        private System.Windows.Forms.TextBox TicketPriceTB;
        private System.Windows.Forms.TextBox TicketExhinbitonIdTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.TextBox AnalysisIdTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AnalysisResultTB;
    }
}

