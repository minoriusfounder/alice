using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static String CONV(String s, bool isLast = false)
        {
            int size = isLast ? s.Length - 1 : s.Length;
        
            if ( (size % 2 == 1)) s = s.Remove((int)size/ 2, 1);
            return s;
        }

        public static bool isCorrect(String s)
        {
           return s.Length >= 2 && s.Length <= 10;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void исходныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sourceText.Focus();
        }

        private void обработкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string [] arr = sourceText.Text.Split(',');
            //arr[arr.Length - 1] = arr[arr.Length - 1].Replace(".", "");

            string result = "";
            
            try
            {
                for (int i = 0; i < arr.Length - 1; ++i)
                {
                    if (!Form1.isCorrect(arr[i])) throw new Exception("FUCK YOU BITCH SOSI KIRPITCH");
                    result += Form1.CONV(arr[i]) + ",";
                }

                string last_word = arr[arr.Length - 1];

                if (last_word[last_word.Length - 1] != '.') throw new Exception("DA, SUKA. GTE TOCHKA BLYAT?");
                if(!Form1.isCorrect(last_word)) throw new Exception("FUCK YOU BITCH SOSI KIRPITCH");


                result += Form1.CONV(last_word, true);
                resultBox.Text += result + "\r\n";
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }



          
        }

        private void sourceText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char cur = e.KeyChar;
           //97 - 122
           if ( !(((97 <= (int)cur && (int)cur <= 122)) || (cur == '.' || cur == ',' || (int)cur == 8)))
            e.Handled = true;
        }
    }
}
