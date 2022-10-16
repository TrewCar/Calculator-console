namespace WinFormsApp5
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Formula = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Element = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.StepText = new System.Windows.Forms.TextBox();
            this.Step = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(293, 379);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Formula
            // 
            this.Formula.Location = new System.Drawing.Point(119, 12);
            this.Formula.Name = "Formula";
            this.Formula.Size = new System.Drawing.Size(440, 23);
            this.Formula.TabIndex = 1;
            this.Formula.Tag = "";
            this.Formula.TextChanged += new System.EventHandler(this.Formula_TextChanged);
            // 
            // First
            // 
            this.First.Location = new System.Drawing.Point(349, 84);
            this.First.Name = "First";
            this.First.Size = new System.Drawing.Size(109, 23);
            this.First.TabIndex = 2;
            this.First.Text = "-10";
            this.First.TextChanged += new System.EventHandler(this.First_TextChanged);
            // 
            // Second
            // 
            this.Second.Location = new System.Drawing.Point(349, 113);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(109, 23);
            this.Second.TabIndex = 3;
            this.Second.Text = "10";
            this.Second.TextChanged += new System.EventHandler(this.Second_TextChanged);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(497, 84);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(204, 250);
            this.Start.TabIndex = 4;
            this.Start.Text = "Вычислить";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(349, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 23);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Введите диапазон";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(316, 84);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 23);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "От:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox3.Location = new System.Drawing.Point(316, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(27, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "До:";
            // 
            // Element
            // 
            this.Element.Location = new System.Drawing.Point(565, 12);
            this.Element.Name = "Element";
            this.Element.Size = new System.Drawing.Size(143, 23);
            this.Element.TabIndex = 8;
            this.Element.Text = "Доступные символы";
            this.Element.UseVisualStyleBackColor = true;
            this.Element.Click += new System.EventHandler(this.Element_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(565, 41);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(143, 22);
            this.clear.TabIndex = 9;
            this.clear.Text = "Очистить ";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // StepText
            // 
            this.StepText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StepText.ForeColor = System.Drawing.SystemColors.Info;
            this.StepText.Location = new System.Drawing.Point(316, 142);
            this.StepText.Name = "StepText";
            this.StepText.Size = new System.Drawing.Size(27, 23);
            this.StepText.TabIndex = 10;
            this.StepText.Text = "Шаг";
            // 
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(349, 142);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(109, 23);
            this.Step.TabIndex = 11;
            this.Step.Text = "1";
            this.Step.TextChanged += new System.EventHandler(this.Step_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Black;
            this.textBox4.ForeColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(4, 12);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(109, 23);
            this.textBox4.TabIndex = 12;
            this.textBox4.Text = "Введите формулу";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.StepText);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Element);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Second);
            this.Controls.Add(this.First);
            this.Controls.Add(this.Formula);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox Formula;
        private TextBox First;
        private TextBox Second;
        private Button Start;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Element;
        private Button clear;
        private TextBox StepText;
        private TextBox Step;
        private TextBox textBox4;
    }
}