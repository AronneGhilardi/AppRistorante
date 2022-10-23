namespace ristorante
{
    partial class mam
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
            this.accedi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.TRATTORIAdaKEKKO = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accedi
            // 
            this.accedi.BackColor = System.Drawing.SystemColors.MenuBar;
            this.accedi.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accedi.Location = new System.Drawing.Point(472, 309);
            this.accedi.Name = "accedi";
            this.accedi.Size = new System.Drawing.Size(100, 40);
            this.accedi.TabIndex = 0;
            this.accedi.Text = "Login";
            this.accedi.UseVisualStyleBackColor = false;
            this.accedi.Click += new System.EventHandler(this.accedi_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(107, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 30);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(107, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(465, 30);
            this.textBox2.TabIndex = 4;
            // 
            // TRATTORIAdaKEKKO
            // 
            this.TRATTORIAdaKEKKO.BackColor = System.Drawing.SystemColors.Menu;
            this.TRATTORIAdaKEKKO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TRATTORIAdaKEKKO.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TRATTORIAdaKEKKO.Location = new System.Drawing.Point(12, 12);
            this.TRATTORIAdaKEKKO.Name = "TRATTORIAdaKEKKO";
            this.TRATTORIAdaKEKKO.Size = new System.Drawing.Size(560, 69);
            this.TRATTORIAdaKEKKO.TabIndex = 14;
            this.TRATTORIAdaKEKKO.Text = "Area Staff";
            this.TRATTORIAdaKEKKO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(12, 123);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(101, 34);
            this.PasswordText.TabIndex = 15;
            this.PasswordText.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 34);
            this.label3.TabIndex = 16;
            this.label3.Text = "Utente:";
            // 
            // mam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.TRATTORIAdaKEKKO);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.accedi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordText);
            this.Name = "mam";
            this.Text = "mam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button accedi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox TRATTORIAdaKEKKO;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Label label3;
    }
}