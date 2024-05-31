namespace GestionareMagazieFructe
{
    partial class Autentificare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Autentificare));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUtilizator = new System.Windows.Forms.ComboBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.btnAutentificare = new System.Windows.Forms.Button();
            this.btnInregistrare = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(90, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Magazioner";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(90, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola Acces";
            // 
            // cmbUtilizator
            // 
            this.cmbUtilizator.FormattingEnabled = true;
            this.cmbUtilizator.Location = new System.Drawing.Point(415, 90);
            this.cmbUtilizator.Name = "cmbUtilizator";
            this.cmbUtilizator.Size = new System.Drawing.Size(545, 24);
            this.cmbUtilizator.TabIndex = 2;
            // 
            // txtParola
            // 
            this.txtParola.BackColor = System.Drawing.SystemColors.Window;
            this.txtParola.Location = new System.Drawing.Point(415, 209);
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '*';
            this.txtParola.Size = new System.Drawing.Size(545, 22);
            this.txtParola.TabIndex = 3;
            // 
            // btnAutentificare
            // 
            this.btnAutentificare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutentificare.Location = new System.Drawing.Point(94, 370);
            this.btnAutentificare.Name = "btnAutentificare";
            this.btnAutentificare.Size = new System.Drawing.Size(212, 63);
            this.btnAutentificare.TabIndex = 4;
            this.btnAutentificare.Text = "Autentificare";
            this.btnAutentificare.UseVisualStyleBackColor = false;
            this.btnAutentificare.Click += new System.EventHandler(this.btnAutentificare_Click);
            // 
            // btnInregistrare
            // 
            this.btnInregistrare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInregistrare.Location = new System.Drawing.Point(415, 370);
            this.btnInregistrare.Name = "btnInregistrare";
            this.btnInregistrare.Size = new System.Drawing.Size(212, 63);
            this.btnInregistrare.TabIndex = 5;
            this.btnInregistrare.Text = "Inregistrare";
            this.btnInregistrare.UseVisualStyleBackColor = false;
            this.btnInregistrare.Click += new System.EventHandler(this.btnInregistrare_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIesire.Location = new System.Drawing.Point(748, 370);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(212, 63);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = false;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(375, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "S.C. KohCiui Agro S.R.L.";
            // 
            // Autentificare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1061, 499);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnInregistrare);
            this.Controls.Add(this.btnAutentificare);
            this.Controls.Add(this.txtParola);
            this.Controls.Add(this.cmbUtilizator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Autentificare";
            this.Text = "Autentificare";
            this.Load += new System.EventHandler(this.Autentificare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUtilizator;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.Button btnAutentificare;
        private System.Windows.Forms.Button btnInregistrare;
        private System.Windows.Forms.Button btnIesire;
        private System.Windows.Forms.Label label3;
    }
}

