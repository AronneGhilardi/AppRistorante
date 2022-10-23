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
    public partial class recupera : Form
    {
        public recupera()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                MessageBox.Show("Recupero effettuato!");
                this.Hide();
                mam ag = new mam();
                ag.ShowDialog();
                this.Close();
            }

        }
        public void Ricerca(string filename, ref int y)
        {
            StreamReader sr = new StreamReader(filename);
            StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
            string z = sr.ReadLine();
            while (z != null)
            {
                if (textBox1.Text == z.Split(';')[0])
                {
                    sw.WriteLine(z.Split(';')[0] + ";" + z.Split(';')[1] + ";" + z.Split(';')[2] + ";" + z.Split(';')[3] + ";" + z.Split(';')[4] + ";" + z.Split(';')[5] + ";True");
                    y++;
                }
                else
                {
                    sw.WriteLine(y);
                }
                z = sr.ReadLine();

            }
            sr.Close();
            sw.Close();
            System.IO.File.Delete(filename);
            System.IO.File.Move(@".\data\piatti\temp.txt", filename);
            
        }
    }
}
