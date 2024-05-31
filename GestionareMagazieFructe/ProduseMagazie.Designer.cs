namespace GestionareMagazieFructe
{
    partial class ProduseMagazie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProduseMagazie));
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGWProduse = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCautare = new System.Windows.Forms.TextBox();
            this.btnCautare = new System.Windows.Forms.Button();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnAdaugareInfo = new System.Windows.Forms.Button();
            this.btnAdaugareImagini = new System.Windows.Forms.Button();
            this.btnVizualizareProdus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(415, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "PRODUSE MAGAZIE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Teko", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(390, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 9;
            this.label1.Text = "S.C. KohCiui Agro S.R.L.";
            // 
            // dGWProduse
            // 
            this.dGWProduse.BackgroundColor = System.Drawing.Color.Yellow;
            this.dGWProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWProduse.Location = new System.Drawing.Point(159, 181);
            this.dGWProduse.Name = "dGWProduse";
            this.dGWProduse.RowHeadersWidth = 51;
            this.dGWProduse.RowTemplate.Height = 24;
            this.dGWProduse.Size = new System.Drawing.Size(745, 244);
            this.dGWProduse.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrange;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(154, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cautare";
            // 
            // txtCautare
            // 
            this.txtCautare.BackColor = System.Drawing.SystemColors.Window;
            this.txtCautare.Location = new System.Drawing.Point(270, 128);
            this.txtCautare.Name = "txtCautare";
            this.txtCautare.Size = new System.Drawing.Size(466, 22);
            this.txtCautare.TabIndex = 12;
            // 
            // btnCautare
            // 
            this.btnCautare.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCautare.Location = new System.Drawing.Point(767, 118);
            this.btnCautare.Name = "btnCautare";
            this.btnCautare.Size = new System.Drawing.Size(137, 43);
            this.btnCautare.TabIndex = 13;
            this.btnCautare.Text = "Cautare";
            this.btnCautare.UseVisualStyleBackColor = false;
            this.btnCautare.Click += new System.EventHandler(this.btnCautare_Click);
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdaugare.Location = new System.Drawing.Point(159, 443);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(115, 41);
            this.btnAdaugare.TabIndex = 14;
            this.btnAdaugare.Text = "Adaugare Produs";
            this.btnAdaugare.UseVisualStyleBackColor = false;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnAdaugareInfo
            // 
            this.btnAdaugareInfo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdaugareInfo.Location = new System.Drawing.Point(311, 444);
            this.btnAdaugareInfo.Name = "btnAdaugareInfo";
            this.btnAdaugareInfo.Size = new System.Drawing.Size(115, 42);
            this.btnAdaugareInfo.TabIndex = 15;
            this.btnAdaugareInfo.Text = "Adaugare Informatii Produs";
            this.btnAdaugareInfo.UseVisualStyleBackColor = false;
            this.btnAdaugareInfo.Click += new System.EventHandler(this.btnAdaugareInfo_Click);
            // 
            // btnAdaugareImagini
            // 
            this.btnAdaugareImagini.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdaugareImagini.Location = new System.Drawing.Point(462, 444);
            this.btnAdaugareImagini.Name = "btnAdaugareImagini";
            this.btnAdaugareImagini.Size = new System.Drawing.Size(115, 42);
            this.btnAdaugareImagini.TabIndex = 16;
            this.btnAdaugareImagini.Text = "Adaugare Imagini Produs";
            this.btnAdaugareImagini.UseVisualStyleBackColor = false;
            this.btnAdaugareImagini.Click += new System.EventHandler(this.btnAdaugareImagini_Click);
            // 
            // btnVizualizareProdus
            // 
            this.btnVizualizareProdus.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVizualizareProdus.Location = new System.Drawing.Point(621, 444);
            this.btnVizualizareProdus.Name = "btnVizualizareProdus";
            this.btnVizualizareProdus.Size = new System.Drawing.Size(115, 42);
            this.btnVizualizareProdus.TabIndex = 17;
            this.btnVizualizareProdus.Text = "Vizualizare Produs";
            this.btnVizualizareProdus.UseVisualStyleBackColor = false;
            this.btnVizualizareProdus.Click += new System.EventHandler(this.btnVizualizareProdus_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(919, 444);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 42);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Inchide Aplicatia";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSterge.Location = new System.Drawing.Point(767, 442);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(137, 42);
            this.btnSterge.TabIndex = 19;
            this.btnSterge.Text = "Sterge Produs";
            this.btnSterge.UseVisualStyleBackColor = false;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            // 
            // ProduseMagazie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1083, 529);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnVizualizareProdus);
            this.Controls.Add(this.btnAdaugareImagini);
            this.Controls.Add(this.btnAdaugareInfo);
            this.Controls.Add(this.btnAdaugare);
            this.Controls.Add(this.btnCautare);
            this.Controls.Add(this.txtCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dGWProduse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "ProduseMagazie";
            this.Text = "ProduseMagazie";
            this.Activated += new System.EventHandler(this.ProduseMagazie_Activated);
            this.Load += new System.EventHandler(this.ProduseMagazie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGWProduse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCautare;
        private System.Windows.Forms.Button btnCautare;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnAdaugareInfo;
        private System.Windows.Forms.Button btnAdaugareImagini;
        private System.Windows.Forms.Button btnVizualizareProdus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSterge;
    }
}