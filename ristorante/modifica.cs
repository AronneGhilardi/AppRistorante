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
    public partial class modifica : Form
    {
        public modifica()
        {
            InitializeComponent();
        }
        public string nome;
        public string prezzo;
        public string ingrediente1;
        public string ingrediente2;
        public string ingrediente3;
        public string ingrediente4;
        private void button1_Click(object sender, EventArgs e)
        {
            int p = 0;
            nome = textBox1.Text;
            prezzo = textBox2.Text;
            ingrediente1 = textBox5.Text;
            ingrediente2 = textBox6.Text;
            ingrediente3 = textBox7.Text;
            ingrediente4 = textBox3.Text;
            string[] filename = new string[] { @".\data\piatti\Primo.txt", @".\data\piatti\Secondo.txt", @".\data\piatti\Contorno.txt", @".\data\piatti\Dolce.txt" };
            for (int i = 0; i < filename.Length; i++)
            {
                StreamReader sr = new StreamReader(filename[i]);
                StreamWriter sw = new StreamWriter(@".\data\piatti\temp.txt");
                string drone = sr.ReadLine();

                while (drone != null)
                {
                    if (nome == drone.Split(';')[0])
                    {
                        if (prezzo == "")
                        {
                            prezzo = drone.Split(';')[1];
                        }
                        if (ingrediente1 == "")
                        {
                            ingrediente1 = drone.Split(';')[2];
                        }
                        if (ingrediente2 == "")
                        {
                            ingrediente2 = drone.Split(';')[3];
                        }
                        if (ingrediente3 == "")
                        {
                            ingrediente3 = drone.Split(';')[4];
                        }
                        if (ingrediente4 == "")
                        {
                            ingrediente4 = drone.Split(';')[5];
                        }
                        sw.WriteLine(nome + ";" + prezzo + ";" + ingrediente1 + ";" + ingrediente2 + ";" + ingrediente3 + ";" + ingrediente4 + ";True");
                        p = 1;
                    }
                    else
                    {
                        sw.WriteLine(drone);
                    }
                    drone = sr.ReadLine();

                }
                sr.Close();
                sw.Close();
                System.IO.File.Delete(filename[i]);
                System.IO.File.Move(@".\data\piatti\temp.txt", filename[i]);
            }
            if (p == 0)
            {
                MessageBox.Show("Errore! Impossibile trovare il piatto.");
            }
            else
            {
                MessageBox.Show("Il piatto è stato modificato!");
                this.Hide();
                proprietario ag = new proprietario();
                ag.ShowDialog();
                this.Close();
            }
        }
    }
}
