using System;
using System.Windows.Forms;

namespace GestionareMagazieFructe
{
    partial class Stergere
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stergere));
            this.txtTara = new System.Windows.Forms.TextBox();
            this.btnSterge = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblTara = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTara
            // 
            this.txtTara.Location = new System.Drawing.Point(376, 131);
            this.txtTara.Name = "txtTara";
            this.txtTara.Size = new System.Drawing.Size(596, 30);
            this.txtTara.TabIndex = 1;
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.Color.Yellow;
            this.btnSterge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSterge.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSterge.ForeColor = System.Drawing.Color.Black;
            this.btnSterge.Location = new System.Drawing.Point(457, 294);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(170, 65);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.DarkOrange;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblResult.Location = new System.Drawing.Point(23, 131);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(360, 30);
            this.lblResult.TabIndex = 3;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTara
            // 
            this.lblTara.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTara.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTara.Location = new System.Drawing.Point(122, 131);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(171, 30);
            this.lblTara.TabIndex = 0;
            this.lblTara.Text = "Introdu Produsul :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(395, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 43);
            this.label3.TabIndex = 9;
            this.label3.Text = "S.C. KohCiui Agro S.R.L.";
            // 
            // Stergere
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1119, 526);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.txtTara);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.lblResult);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Stergere";
            this.Text = "Ștergere Produse";
            this.Load += new System.EventHandler(this.Stergere_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtTara;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.Label lblResult;
        private Label lblTara;
        private Label label3;
    }
}