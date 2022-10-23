
namespace ristorante
{
    partial class cliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.aggiungiallordine = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.completaordine = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TRATTORIAdaKEKKO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // aggiungiallordine
            // 
            this.aggiungiallordine.BackColor = System.Drawing.SystemColors.MenuBar;
            this.aggiungiallordine.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiungiallordine.Location = new System.Drawing.Point(472, 12);
            this.aggiungiallordine.Name = "aggiungiallordine";
            this.aggiungiallordine.Size = new System.Drawing.Size(100, 30);
            this.aggiungiallordine.TabIndex = 7;
            this.aggiungiallordine.Text = "Aggiungi";
            this.aggiungiallordine.UseVisualStyleBackColor = false;
            this.aggiungiallordine.Click += new System.EventHandler(this.aggiungiallordine_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(316, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 10;
            // 
            // completaordine
            // 
            this.completaordine.BackColor = System.Drawing.SystemColors.MenuBar;
            this.completaordine.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completaordine.Location = new System.Drawing.Point(316, 52);
            this.completaordine.Name = "completaordine";
            this.completaordine.Size = new System.Drawing.Size(256, 29);
            this.completaordine.TabIndex = 12;
            this.completaordine.Text = "Conferma ordine!";
            this.completaordine.UseVisualStyleBackColor = false;
            this.completaordine.Click += new System.EventHandler(this.completaordine_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 87);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(560, 262);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // TRATTORIAdaKEKKO
            // 
            this.TRATTORIAdaKEKKO.BackColor = System.Drawing.SystemColors.Menu;
            this.TRATTORIAdaKEKKO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRATTORIAdaKEKKO.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRATTORIAdaKEKKO.Location = new System.Drawing.Point(12, 12);
            this.TRATTORIAdaKEKKO.Name = "TRATTORIAdaKEKKO";
            this.TRATTORIAdaKEKKO.Size = new System.Drawing.Size(298, 69);
            this.TRATTORIAdaKEKKO.TabIndex = 15;
            this.TRATTORIAdaKEKKO.Text = "Ordinazione";
            this.TRATTORIAdaKEKKO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TRATTORIAdaKEKKO);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.completaordine);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.aggiungiallordine);
            this.Name = "cliente";
            this.Text = "cliente";
            this.Load += new System.EventHandler(this.cliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button aggiungiallordine;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button completaordine;
        private System.Windows.Forms.Button visualizzamenu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox TRATTORIAdaKEKKO;
    }
}