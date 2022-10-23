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
    public partial class mam : Form
    {
        public mam()
        {
            InitializeComponent();
        }

        public string utente;
        public string password;
        public int based;
        private void accedi_Click(object sender, EventArgs e)
        {
            utente = textBox1.Text;
            password = textBox2.Text;

            leggi($@".\data\staff\{utente}.txt",password,based);
            if (based != 1)
            {
                this.Hide();
                proprietario ag = new proprietario();
                ag.ShowDialog();
                this.Close();
            }
        }

        public static void leggi(string filename, string password,int x)
        {
            StreamReader sr = new StreamReader(filename);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                if (password == line)
                {
                    x = 1;
                    return;
                }
                else
                {
                    MessageBox.Show("Password o utente errati!");
                }
                sr.Close();
            }
        }
    }
}
