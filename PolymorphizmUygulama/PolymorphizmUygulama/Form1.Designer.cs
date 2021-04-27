namespace PolymorphizmUygulama
{
    partial class Form1
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
            this.btnEkmek = new System.Windows.Forms.Button();
            this.btnTekstil = new System.Windows.Forms.Button();
            this.btnElektronik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEkmek
            // 
            this.btnEkmek.Location = new System.Drawing.Point(107, 95);
            this.btnEkmek.Name = "btnEkmek";
            this.btnEkmek.Size = new System.Drawing.Size(75, 23);
            this.btnEkmek.TabIndex = 0;
            this.btnEkmek.Text = "EkmekEkle";
            this.btnEkmek.UseVisualStyleBackColor = true;
            this.btnEkmek.Click += new System.EventHandler(this.btnEkmek_Click);
            // 
            // btnTekstil
            // 
            this.btnTekstil.Location = new System.Drawing.Point(331, 95);
            this.btnTekstil.Name = "btnTekstil";
            this.btnTekstil.Size = new System.Drawing.Size(102, 23);
            this.btnTekstil.TabIndex = 1;
            this.btnTekstil.Text = "TekstilUrunuEkle";
            this.btnTekstil.UseVisualStyleBackColor = true;
            this.btnTekstil.Click += new System.EventHandler(this.btnTekstil_Click);
            // 
            // btnElektronik
            // 
            this.btnElektronik.Location = new System.Drawing.Point(107, 169);
            this.btnElektronik.Name = "btnElektronik";
            this.btnElektronik.Size = new System.Drawing.Size(130, 23);
            this.btnElektronik.TabIndex = 2;
            this.btnElektronik.Text = "ElektronikEkle";
            this.btnElektronik.UseVisualStyleBackColor = true;
            this.btnElektronik.Click += new System.EventHandler(this.btnElektronik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnElektronik);
            this.Controls.Add(this.btnTekstil);
            this.Controls.Add(this.btnEkmek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEkmek;
        private System.Windows.Forms.Button btnTekstil;
        private System.Windows.Forms.Button btnElektronik;
    }
}

