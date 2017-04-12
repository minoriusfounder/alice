using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static int[] getCurrentArray(String s)
        {
            String[] arr = s.Split(',');
            int[] res = new int[arr.Length];
            
            for(int i = 0; i < arr.Length; ++i)
            {
                res[i] = Convert.ToInt32(arr[i]);
            }

            return res;
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int n = rnd.Next(2, 20);

            String result = "";

            for (int i = 0; i < n; ++i)
            {
                result += rnd.Next(-10000, 10000);
                if (i < n - 1) result += ",";
            }
            source.Text = result;
        }

        private void текстовыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void бинарныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog2.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
            writer.WriteLine(result.Text);
            writer.Close();

            MessageBox.Show("Сохранено!");
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            FileStream fs = new FileStream(saveFileDialog2.FileName, FileMode.Create);
            BinaryWriter writer = new BinaryWriter(fs);

            int[] arr = Form1.getCurrentArray(result.Text);

            foreach(int n in arr)
            {
                writer.Write(n);
            }

            writer.Close();
        }

        private void преобразоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] source_array = Form1.getCurrentArray(source.Text);

            int mx = source_array.Max();
            int mn = source_array.Min();

            if (Math.Abs(mx) < Math.Abs(mn)) mx = Math.Abs(mn);

            int nm = 0;
            foreach (int n in source_array)
            {
                if (Math.Abs(n) % 2 == 0) nm++;
            }

            String result = "";

            for(int i = 0; i < source_array.Length; ++i)
            {
                if (Math.Abs(source_array[i]) == mx) source_array[i] = nm;
                result += source_array[i].ToString();
                if (i < source_array.Length - 1) result += ",";
            }

            this.result.Text = result;
        }

        private void текстовыйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void бинарныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamReader reader = new StreamReader(openFileDialog1.FileName);

            string res = "";
            string s;
            while( (s = reader.ReadLine()) != null)
            {
                res += s;
            }

            reader.Close();

            source.Text = res;
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            String res = "";

            try
            {
                  FileStream fs = new FileStream(openFileDialog2.FileName, FileMode.Open);
                 BinaryReader reader = new BinaryReader(fs);
                

                while (true)
                {
                    res += reader.ReadInt32() + ",";
                }

                reader.Close();
                fs.Close();
              
            }
            catch(EndOfStreamException ex)
            {
                res = res.Remove(res.Length - 1, 1);
               
                source.Text = res;
            }
        }
    }
}
