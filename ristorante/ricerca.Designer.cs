
namespace ristorante
{
    partial class ricerca
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
            this.button2 = new System.Windows.Forms.Button();
            this.godo = new System.Windows.Forms.TextBox();
            this.GestioneMenù = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.button2.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(472, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 40);
            this.button2.TabIndex = 27;
            this.button2.Text = "Cerca";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // godo
            // 
            this.godo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.godo.Location = new System.Drawing.Point(325, 84);
            this.godo.Name = "godo";
            this.godo.Size = new System.Drawing.Size(247, 30);
            this.godo.TabIndex = 25;
            // 
            // GestioneMenù
            // 
            this.GestioneMenù.BackColor = System.Drawing.SystemColors.Menu;
            this.GestioneMenù.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GestioneMenù.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GestioneMenù.Location = new System.Drawing.Point(12, 12);
            this.GestioneMenù.Name = "GestioneMenù";
            this.GestioneMenù.Size = new System.Drawing.Size(560, 69);
            this.GestioneMenù.TabIndex = 28;
            this.GestioneMenù.Text = "Ricercare Piatto";
            this.GestioneMenù.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 34);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nome del PIATTO da CERCARE:";
            // 
            // ricerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.GestioneMenù);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.godo);
            this.Controls.Add(this.label1);
            this.Name = "ricerca";
            this.Text = "ricerca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox godo;
        private System.Windows.Forms.TextBox GestioneMenù;
        private System.Windows.Forms.Label label1;
    }
}