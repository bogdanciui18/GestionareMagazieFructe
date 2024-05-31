namespace GestionareMagazieFructe
{
    partial class AdaugareProdus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdaugareProdus));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumarPaleti = new System.Windows.Forms.TextBox();
            this.txtTipProdus = new System.Windows.Forms.TextBox();
            this.txtRaion = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(428, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adaugare Produs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(393, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 10;
            this.label1.Text = "S.C. KohCiui Agro S.R.L.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(118, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Numar Paleti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(118, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tip Produs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(118, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Raion";
            // 
            // txtNumarPaleti
            // 
            this.txtNumarPaleti.Location = new System.Drawing.Point(401, 144);
            this.txtNumarPaleti.Name = "txtNumarPaleti";
            this.txtNumarPaleti.Size = new System.Drawing.Size(489, 22);
            this.txtNumarPaleti.TabIndex = 14;
            // 
            // txtTipProdus
            // 
            this.txtTipProdus.Location = new System.Drawing.Point(401, 248);
            this.txtTipProdus.Name = "txtTipProdus";
            this.txtTipProdus.Size = new System.Drawing.Size(489, 22);
            this.txtTipProdus.TabIndex = 15;
            // 
            // txtRaion
            // 
            this.txtRaion.Location = new System.Drawing.Point(401, 355);
            this.txtRaion.Name = "txtRaion";
            this.txtRaion.Size = new System.Drawing.Size(489, 22);
            this.txtRaion.TabIndex = 16;
            // 
            // btnAdauga
            // 
            this.btnAdauga.BackColor = System.Drawing.Color.Yellow;
            this.btnAdauga.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdauga.Location = new System.Drawing.Point(401, 446);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(284, 54);
            this.btnAdauga.TabIndex = 17;
            this.btnAdauga.Text = "Adauga Produs";
            this.btnAdauga.UseVisualStyleBackColor = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // AdaugareProdus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 531);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.txtRaion);
            this.Controls.Add(this.txtTipProdus);
            this.Controls.Add(this.txtNumarPaleti);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "AdaugareProdus";
            this.Text = "AdaugareProdus";
            this.Load += new System.EventHandler(this.AdaugareProdus_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumarPaleti;
        private System.Windows.Forms.TextBox txtTipProdus;
        private System.Windows.Forms.TextBox txtRaion;
        private System.Windows.Forms.Button btnAdauga;
    }
}