﻿namespace PROJEKT_PO_1
{
    partial class menu
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_sprawdz_poziom_glukozy = new System.Windows.Forms.Button();
            this.button_panel_admina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_sprawdz_poziom_glukozy
            // 
            this.button_sprawdz_poziom_glukozy.BackColor = System.Drawing.Color.IndianRed;
            this.button_sprawdz_poziom_glukozy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_sprawdz_poziom_glukozy.Location = new System.Drawing.Point(704, 107);
            this.button_sprawdz_poziom_glukozy.Name = "button_sprawdz_poziom_glukozy";
            this.button_sprawdz_poziom_glukozy.Size = new System.Drawing.Size(311, 225);
            this.button_sprawdz_poziom_glukozy.TabIndex = 4;
            this.button_sprawdz_poziom_glukozy.Text = "SPRAWDŹ POZIOM GLUKOZY";
            this.button_sprawdz_poziom_glukozy.UseVisualStyleBackColor = false;
            this.button_sprawdz_poziom_glukozy.Click += new System.EventHandler(this.button_sprawdz_poziom_glukozy_Click);
            // 
            // button_panel_admina
            // 
            this.button_panel_admina.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button_panel_admina.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button_panel_admina.Location = new System.Drawing.Point(156, 107);
            this.button_panel_admina.Name = "button_panel_admina";
            this.button_panel_admina.Size = new System.Drawing.Size(311, 225);
            this.button_panel_admina.TabIndex = 3;
            this.button_panel_admina.Text = "PANEL ADMINISTRATORA";
            this.button_panel_admina.UseVisualStyleBackColor = false;
            this.button_panel_admina.Click += new System.EventHandler(this.button_panel_admina_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1178, 439);
            this.Controls.Add(this.button_sprawdz_poziom_glukozy);
            this.Controls.Add(this.button_panel_admina);
            this.Name = "menu";
            this.Text = "Cukrometr 2000 GTR AMG SLS  PANEL ADMINISTRATORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_sprawdz_poziom_glukozy;
        private System.Windows.Forms.Button button_panel_admina;
    }
}

