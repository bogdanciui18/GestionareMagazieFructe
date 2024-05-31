namespace GestionareMagazieFructe
{
    partial class AdaugareImagini
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareImagini));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipProdus = new System.Windows.Forms.TextBox();
            this.txtImagine = new System.Windows.Forms.TextBox();
            this.btnImagine = new System.Windows.Forms.Button();
            this.btnAdaugaImagine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(407, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 14;
            this.label1.Text = "S.C. KohCiui Agro S.R.L.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(389, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 43);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adaugare Imagini Produs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(127, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tip Produs";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(127, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Imagine";
            // 
            // txtTipProdus
            // 
            this.txtTipProdus.Enabled = false;
            this.txtTipProdus.Location = new System.Drawing.Point(397, 141);
            this.txtTipProdus.Name = "txtTipProdus";
            this.txtTipProdus.Size = new System.Drawing.Size(584, 22);
            this.txtTipProdus.TabIndex = 17;
            // 
            // txtImagine
            // 
            this.txtImagine.Location = new System.Drawing.Point(397, 265);
            this.txtImagine.Name = "txtImagine";
            this.txtImagine.Size = new System.Drawing.Size(478, 22);
            this.txtImagine.TabIndex = 18;
            // 
            // btnImagine
            // 
            this.btnImagine.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImagine.Location = new System.Drawing.Point(896, 265);
            this.btnImagine.Name = "btnImagine";
            this.btnImagine.Size = new System.Drawing.Size(85, 23);
            this.btnImagine.TabIndex = 19;
            this.btnImagine.Text = "...img";
            this.btnImagine.UseVisualStyleBackColor = false;
            this.btnImagine.Click += new System.EventHandler(this.btnImagine_Click);
            // 
            // btnAdaugaImagine
            // 
            this.btnAdaugaImagine.BackColor = System.Drawing.Color.Yellow;
            this.btnAdaugaImagine.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdaugaImagine.Location = new System.Drawing.Point(415, 402);
            this.btnAdaugaImagine.Name = "btnAdaugaImagine";
            this.btnAdaugaImagine.Size = new System.Drawing.Size(302, 66);
            this.btnAdaugaImagine.TabIndex = 20;
            this.btnAdaugaImagine.Text = "Adauga Imagine";
            this.btnAdaugaImagine.UseVisualStyleBackColor = false;
            this.btnAdaugaImagine.Click += new System.EventHandler(this.btnAdaugaImagine_Click);
            // 
            // AdaugareImagini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1115, 532);
            this.Controls.Add(this.btnAdaugaImagine);
            this.Controls.Add(this.btnImagine);
            this.Controls.Add(this.txtImagine);
            this.Controls.Add(this.txtTipProdus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "AdaugareImagini";
            this.Text = "AdaugareImagini";
            this.Load += new System.EventHandler(this.AdaugareImagini_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTipProdus;
        private System.Windows.Forms.TextBox txtImagine;
        private System.Windows.Forms.Button btnImagine;
        private System.Windows.Forms.Button btnAdaugaImagine;
    }
}