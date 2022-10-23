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
    public partial class proprietario : Form
    {
        public proprietario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            aggiungipiatti ag = new aggiungipiatti();
            ag.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            visualizza form6 = new visualizza(); 
            this.Visible = false; form6.ShowDialog(); 
            this.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifica form6 = new modifica(); 
            this.Visible = false; form6.ShowDialog(); 
            this.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ricerca form6 = new ricerca(); 
            this.Visible = false; 
            form6.ShowDialog(); this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            elimina form6 = new elimina(); 
            this.Visible = false; form6.ShowDialog(); 
            this.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            recupera form6 = new recupera(); 
            this.Visible = false; form6.ShowDialog(); 
            this.Visible = true;
        }
    }
}
