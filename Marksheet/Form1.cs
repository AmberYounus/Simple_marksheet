using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marksheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();

            int vp, coa, dbms, urdu, dsa, de;
            int n;
            double p;

            vp = Convert.ToInt32(textBox2.Text);
            coa = Convert.ToInt32(textBox3.Text);
            dbms = Convert.ToInt32(textBox4.Text);
            urdu = Convert.ToInt32(textBox5.Text);
            dsa = Convert.ToInt32(textBox6.Text);
            de = Convert.ToInt32(textBox7.Text);

            n = vp + coa + dbms + urdu + dsa + de;

            p =n / 600 * 100;

            a.label2.Text = textBox2.Text + "\n" + textBox3.Text + "\n" + textBox4.Text + "\n" + textBox5.Text + "\n" + textBox6.Text + "\n" + textBox7.Text + "\n";
            a.textBox1.Text = n.ToString();
            a.textBox2.Text = p.ToString();
           


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
