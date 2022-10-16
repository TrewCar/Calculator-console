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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Formula = new System.Windows.Forms.TextBox();
            this.First = new System.Windows.Forms.TextBox();
            this.Second = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.Element = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.Step = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
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
            // Step
            // 
            this.Step.Location = new System.Drawing.Point(349, 150);
            this.Step.Name = "Step";
            this.Step.Size = new System.Drawing.Size(109, 23);
            this.Step.TabIndex = 11;
            this.Step.Text = "1";
            this.Step.TextChanged += new System.EventHandler(this.Step_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(349, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите диапазон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(323, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "От:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "До:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Шаг:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите формулу:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Step);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.Element);
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
        private Button Element;
        private Button clear;
        private TextBox Step;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
    }
}