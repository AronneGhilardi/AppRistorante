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

namespace ristorante
{
    public partial class elimina : Form
    {
        public elimina()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            int y = 0;
            Ricerca(@".\data\piatti\Primo.txt", ref y);
            Ricerca(@".\data\piatti\Secondo.txt", ref y);
            Ricerca(@".\data\piatti\Contorno.txt", ref y);
            Ricerca(@".\data\piatti\Dolce.txt", ref y);
            if (y == 0)
            {
                MessageBox.Show("Errore! Impossibile trovare il piatto.");
            }
            else
            {
                MessageBox.Show("Piatto eliminato!");
            }

        }
        public void Ricerca(string filename, ref int y)
        {
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
            string z = sr.ReadLine();
            while (z != null)
            {
                if (godo.Text == z.Split(';')[0])
                {
                    sw.WriteLine(z.Split(';')[0] + ";" + z.Split(';')[1] + ";" + z.Split(';')[2] + ";" + z.Split(';')[3] + ";" + z.Split(';')[4] + ";" + z.Split(';')[5] + ";False");
                    y++;
                }
                else
                {
                    sw.WriteLine(z);
                }
                z = sr.ReadLine();

            }
            sr.Close();
            sw.Close();
            System.IO.File.Delete(filename);
            System.IO.File.Move(@".\data\piatti\temp.txt", filename);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filename = new string[] { @".\data\piatti\Primo.txt", @".\data\piatti\Secondo.txt", @".\data\piatti\Contorno.txt", @".\data\piatti\Dolce.txt" };
            for (int i = 0; i < filename.Length; i++)
            {
                StreamReader sr = new StreamReader(filename[i]);
                StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
                string z = sr.ReadLine();
                while (z != null)
                {
                    if (z.Split(';')[6] != "False"&& z.Split(';')[0]!=godo.Text)
                    {
                        sw.WriteLine(z);
                    }
                    else
                    {
                        MessageBox.Show("Il piatto è stato eliminato!");
                    }
                    z = sr.ReadLine();
                }
                sr.Close();
                sw.Close();
                System.IO.File.Delete(filename[i]);
                System.IO.File.Move(@".\data\piatti\temp.txt", filename[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            proprietario ag = new proprietario();
            ag.ShowDialog();
            this.Close();
        }
    }
}
