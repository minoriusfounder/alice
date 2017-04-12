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
      
    public partial class Form1 : Form
    {
        class Circler
        {
            private int r;

            public int R
            {
                get { return r; }
                set { r = value; }
            }

            public Circler(int r)
            {
                this.r = r;
            }

            public virtual String info() { return ""; }
            public virtual double Square() { return Math.PI * Math.Pow(this.r, 2); }

        }

        class Sphere : Circler
        {
            public Sphere(int r) : base(r)
            {

            }

            public override String info()
            {
                return "Сфера с радиусом " + this.R + ".";
            }

            public override double Square()
            {
                return 4 * Math.PI * Math.Pow(this.R, 2);
            }
        }

        class Torus : Circler
        {

            private int h;

            public int H
            {
                get { return h; }
                set { h = value; }
            }

            public Torus(int r, int h) : base(r)
            {
                this.H = h;
            }

            public override String info()
            {
                return "Конус с радиусом " + this.R + " и высотой + ." + this.h;
            }

            public override double Square()
            {
                return Math.PI * this.R * (this.R + Math.Sqrt(Math.Pow(this.H, 2) + Math.Pow(this.R, 2)));
            }

        }


        private List<Circler> list = new List<Circler>();


        public String getTextInfo()
        {

            String s = "";


            int i = 0;
            foreach (Circler ci in this.list)
            {
                s += i.ToString() + "." + ci.info() + "\r\n";
                i++;
            }

            return s;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circler new_Element;

            Random rnd = new Random();

           if(comboBox1.Text == "Конус")
            {
                new_Element = new Torus(rnd.Next(1,20), rnd.Next(1,20));
            }else
            {
                new_Element = new Sphere(rnd.Next(1, 20));
            }

            textBox1.Text += "Создано: " + new_Element.info() + "\r\n";
            list.Add(new_Element);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this.getTextInfo());
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this.getTextInfo());
            form3.ShowDialog();

            textBox1.Text += "Площадь: " + this.list[form3.result_id].Square().ToString() + "\r\n"; 
        }
    }
}
