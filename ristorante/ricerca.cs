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
    public partial class ricerca : Form
    {
        public ricerca()
        {
            InitializeComponent();
        }
        public string Ricerca(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            string drone=sr.ReadLine();
            while (drone != null)
            {
                if (godo.Text==drone.Split(';')[0])
                {
                    return drone;
                }
                drone = sr.ReadLine();
            }
            return "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string linea = Ricerca(@".\data\piatti\Primo.txt");
            if (linea == "")
            {
                linea = Ricerca(@".\data\piatti\Secondo.txt");
                if (linea == "")
                {
                    linea = Ricerca(@".\data\piatti\Contorno.txt");
                    if (linea == "")
                    {
                        linea = Ricerca(@".\data\piatti\Dolce.txt");
                    }
                }
            }
            if (linea == "")
            {
                MessageBox.Show("Errore! Piatto non trovato.");
            }
            else
            {
                if (linea.Split(';')[6]=="True")
                {
                    string n = $"Nome: {linea.Split(';')[0]}\nPrezzo: {linea.Split(';')[1]}\nPortata: {linea.Split(';')[2]}\nIngredienti: {linea.Split(';')[3]}\nIngredienti: {linea.Split(';')[4]}\nIngredienti: {linea.Split(';')[5]}\n";
                    string stampa = null;
                    stampa += n + "\n\n";
                    MessageBox.Show(stampa);
                    this.Hide();
                    mam ag = new mam();
                    ag.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Il piatto è stato spostato nel cestino.");
                }
                
            }
        }
    }
}
