using ConsoleApp6;
using System;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Formula_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Step_TextChanged(object sender, EventArgs e)
        {

        }
        private void First_TextChanged(object sender, EventArgs e)
        {

        }
        private void Second_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            X rool = new X();
            Random rand = new Random();

            double first = double.Parse(First.Text);
            double second = double.Parse(Second.Text);
    
            double step = double.Parse(Step.Text);
           
            string formula = Formula.Text;
            string[] _formula = formula.Split(' ');

            string[] err = new string[_formula.Length + 4];
            for (int i = 0; i < err.Length; i++)
            {
                if (i < 2 || i > _formula.Length + 1)
                    err[i] = "0";
                else
                    err[i] = _formula[i - 2];
            }
            
            err[0] = "0";
            err[1] = "+";
            err[err.Length - 1] = "0";
            err[err.Length - 2] = "+";
            string[] err2 = err.ToArray();

            double fff = rand.NextDouble() * 453.3453346;
            double y = fff;

            listBox1.Items.Add("x\t||\ty");

            for (double xx = first; xx < second + step; xx += step)
            {

                double yy = rool.sect(err, xx);


                listBox1.Items.Add(xx.ToString("F3") + "\t||\t" + yy.ToString("F3"));

                if (xx == 0)
                {
                    y = yy;
                }

                for (int g = 0; g < err.Length; g++)
                {
                    err[g] = err2[g];
                }
            }
            if (y == fff)
            {
                y = rool.sect(err, 0);
            }

        }

        

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Доступные символы: ");
            listBox1.Items.Add("+ , - , / , * , cos , sin , tg , ctg , ^ , log , sqrt, abs");
            listBox1.Items.Add("Как их использовать написано в README");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}