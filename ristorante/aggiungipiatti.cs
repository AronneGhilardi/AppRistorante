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
    public partial class aggiungipiatti : Form
    {
        public aggiungipiatti()
        {
            InitializeComponent();
        }
        public string piatto;
        public string portata;
        public string ingrediente1;
        public string ingrediente2;
        public string ingrediente3;
        public string ingrediente4;
        public string prezzo; 

        private void button1_Click(object sender, EventArgs e)
        {
            piatto = textBox1.Text;
            portata=textBox2.Text;
            ingrediente1=textBox3.Text;
            ingrediente2=textBox4.Text;
            ingrediente3=textBox5.Text;
            ingrediente4=textBox6.Text;
            prezzo = textBox7.Text;
            if (portata == "Primo" || portata == "Secondo" || portata == "Contorno" || portata == "Dolce")
            {
                StreamWriter sw = new StreamWriter($@".\data\piatti\{portata}.txt");
                sw.WriteLine(piatto + ";" + prezzo + ";" + ingrediente1 + ";" + ingrediente2 + ";" + ingrediente3 + ";" + ingrediente4+";True") ;
                sw.Close();
                MessageBox.Show("Piatto inserito nel menù!");
                proprietario form6 = new proprietario(); 
                this.Visible = false; form6.ShowDialog(); 
                this.Visible = true;
            }
            else 
            {
                MessageBox.Show("Errore!");
            }
        }
    }
}
