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
    public partial class Form2 : Form
    {
        public String S;

        public Form2(String s)
        {
            this.S = s;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = this.S;
        }
    }
}
