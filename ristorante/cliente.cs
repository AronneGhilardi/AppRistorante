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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
            listView1.Columns.Add("Nome");
            listView1.Columns.Add("Prezzo");
            listView1.Columns.Add("Ingredienti");
            listView1.Columns.Add("Ingredienti");
            listView1.Columns.Add("Ingredienti");
            listView1.Columns.Add("Ingredienti");
            listView1.Columns.Add("Portata");
        }

        double last = 0;

        private void cliente_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            
            string[] filename = new string[] { @".\data\piatti\Primo.txt", @".\data\piatti\Secondo.txt", @".\data\piatti\Contorno.txt", @".\data\piatti\Dolce.txt" };
            for (int i = 0; i < filename.Length; i++)
            {
                StreamReader sr = new StreamReader(filename[i]);
                string z = sr.ReadLine();
                while (z != null)
                {
                    string[] cose = z.Split(';');
                    string[] items2 = new string[cose.Length];
                    for (int j = 0; j < items2.Length; j++)
                        items2[j] = cose[j];
                    if (i == 0)
                        items2[6] = "Primo";
                    if (i == 1)
                        items2[6] = "Secondo";
                    if (i == 2)
                        items2[6] = "Contorno";
                    if (i == 3)
                        items2[6] = "Dolce";

                    ListViewItem item = new ListViewItem(items2);
                    listView1.Items.Add(item);

                    z = sr.ReadLine();
                }
                sr.Close();
            }

        }

        private void aggiungiallordine_Click(object sender, EventArgs e)
        {
            string x = Ricerca(@".\data\piatti\Primo.txt");
            if (x == "")
            {
                x = Ricerca(@".\data\piatti\Secondo.txt");
                if (x == "")
                {
                    x = Ricerca(@".\data\piatti\Contorno.txt");
                    if (x == "")
                    {
                        x = Ricerca(@".\data\piatti\Dolce.txt");
                    }
                }
            }
            if (x == "")
            {
                MessageBox.Show("Piatto non trovato");
            }
            else
            {
                if (x.Split(';')[6] == "True")
                {
                    last += double.Parse(x.Split(';')[1]);
                }
            }
            MessageBox.Show("Piatto aggiuto.");
            textBox1.Text = "";

        }
        private void completaordine_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{last}"+"$");

            last = 0;
            this.Hide();
            Form1 ag = new Form1();
            ag.ShowDialog();
            this.Close();
        }

        public string Ricerca(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string z = sr.ReadLine();
            while (z != null)
            {
                if (textBox1.Text == z.Split(';')[0])
                {
                    return z;
                }
                z = sr.ReadLine();
            }
            return "";
        }
    }
}
