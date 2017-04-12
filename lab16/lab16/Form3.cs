using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab16
{
    public partial class Form3 : Form
    {
        public String S;
        public int result_id = -1;

        public Form3(String s)
        {
            this.S = s;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.S;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.result_id = Convert.ToInt32(textBox2.Text);
            this.Close();
        }
    }
}
