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
    public partial class visualizza : Form
    {
        public visualizza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

                StreamReader sr = new StreamReader("./data/piatti/Primo.txt"); ;
                string y = sr.ReadLine();
                string stampa = null;
                while (y != null)
                {
                    if (y.Split(';')[6] == "True")
                    {
                        string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\ningredienti: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}\nIngredienti: {y.Split(';')[4]}\nIngredienti: {y.Split(';')[5]}\n";
                        stampa += n + "\n\n";
                    }
                    y = sr.ReadLine();
                }
                sr.Close();
                MessageBox.Show(stampa);
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./data/piatti/Secondo.txt"); ;
            string y = sr.ReadLine();
            string stampa = null;
            while (y != null)
            {
                if (y.Split(';')[6] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nPortata: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}\nIngredienti: {y.Split(';')[4]}\nIngredienti: {y.Split(';')[5]}\n";
                    stampa += n + "\n\n";
                }
                y = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(stampa);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./data/piatti/Contorno.txt"); ;
            string y = sr.ReadLine();
            string stampa = null;
            while (y != null)
            {
                if (y.Split(';')[6] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nIngredienti: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}\nIngredienti: {y.Split(';')[4]}\nIngredienti: {y.Split(';')[5]}\n";
                    stampa += n + "\n\n";
                }
                y = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(stampa);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("./data/piatti/Dolce.txt"); ;
            string y = sr.ReadLine();
            string stampa = null;
            while (y != null)
            {
                if (y.Split(';')[6] == "True")
                {
                    string n = $"Nome: {y.Split(';')[0]}\nPrezzo: {y.Split(';')[1]}\nPortata: {y.Split(';')[2]}\nIngredienti: {y.Split(';')[3]}\nIngredienti: {y.Split(';')[4]}\nIngredienti: {y.Split(';')[5]}\n";
                    stampa += n + "\n\n";
                }
                y = sr.ReadLine();
            }
            sr.Close();
            MessageBox.Show(stampa);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            proprietario ag = new proprietario();
            ag.ShowDialog();
            this.Close();
        }
    }
}
