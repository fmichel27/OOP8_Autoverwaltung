namespace OOP8_Autoverwaltung.src
{
    partial class GUI
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
            this.btn_neuerStandort = new System.Windows.Forms.Button();
            this.btn_aendereStandort = new System.Windows.Forms.Button();
            this.btn_loescheStandort = new System.Windows.Forms.Button();
            this.btn_neuesAuto = new System.Windows.Forms.Button();
            this.btn_aendereAuto = new System.Windows.Forms.Button();
            this.btn_loescheAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_standorte = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_marken = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_markenAnStandort = new System.Windows.Forms.ListBox();
            this.lb_standortDerMarke = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_neuerStandort
            // 
            this.btn_neuerStandort.Location = new System.Drawing.Point(81, 98);
            this.btn_neuerStandort.Name = "btn_neuerStandort";
            this.btn_neuerStandort.Size = new System.Drawing.Size(92, 23);
            this.btn_neuerStandort.TabIndex = 0;
            this.btn_neuerStandort.Text = "Neuer Standort";
            this.btn_neuerStandort.UseVisualStyleBackColor = true;
            this.btn_neuerStandort.Click += new System.EventHandler(this.btn_neuerStandort_Click);
            // 
            // btn_aendereStandort
            // 
            this.btn_aendereStandort.Location = new System.Drawing.Point(179, 98);
            this.btn_aendereStandort.Name = "btn_aendereStandort";
            this.btn_aendereStandort.Size = new System.Drawing.Size(75, 23);
            this.btn_aendereStandort.TabIndex = 1;
            this.btn_aendereStandort.Text = "Ändern";
            this.btn_aendereStandort.UseVisualStyleBackColor = true;
            this.btn_aendereStandort.Click += new System.EventHandler(this.btn_aendereStandort_Click);
            // 
            // btn_loescheStandort
            // 
            this.btn_loescheStandort.Location = new System.Drawing.Point(260, 98);
            this.btn_loescheStandort.Name = "btn_loescheStandort";
            this.btn_loescheStandort.Size = new System.Drawing.Size(75, 23);
            this.btn_loescheStandort.TabIndex = 2;
            this.btn_loescheStandort.Text = "Löschen";
            this.btn_loescheStandort.UseVisualStyleBackColor = true;
            this.btn_loescheStandort.Click += new System.EventHandler(this.btn_loescheStandort_Click);
            // 
            // btn_neuesAuto
            // 
            this.btn_neuesAuto.Location = new System.Drawing.Point(81, 278);
            this.btn_neuesAuto.Name = "btn_neuesAuto";
            this.btn_neuesAuto.Size = new System.Drawing.Size(75, 23);
            this.btn_neuesAuto.TabIndex = 3;
            this.btn_neuesAuto.Text = "Neues Auto";
            this.btn_neuesAuto.UseVisualStyleBackColor = true;
            this.btn_neuesAuto.Click += new System.EventHandler(this.btn_neuesAuto_Click);
            // 
            // btn_aendereAuto
            // 
            this.btn_aendereAuto.Location = new System.Drawing.Point(179, 278);
            this.btn_aendereAuto.Name = "btn_aendereAuto";
            this.btn_aendereAuto.Size = new System.Drawing.Size(75, 23);
            this.btn_aendereAuto.TabIndex = 4;
            this.btn_aendereAuto.Text = "Ändern";
            this.btn_aendereAuto.UseVisualStyleBackColor = true;
            this.btn_aendereAuto.Click += new System.EventHandler(this.btn_aendereAuto_Click);
            // 
            // btn_loescheAuto
            // 
            this.btn_loescheAuto.Location = new System.Drawing.Point(260, 278);
            this.btn_loescheAuto.Name = "btn_loescheAuto";
            this.btn_loescheAuto.Size = new System.Drawing.Size(75, 23);
            this.btn_loescheAuto.TabIndex = 5;
            this.btn_loescheAuto.Text = "Löschen";
            this.btn_loescheAuto.UseVisualStyleBackColor = true;
            this.btn_loescheAuto.Click += new System.EventHandler(this.btn_loescheAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Standorte";
            // 
            // lb_standorte
            // 
            this.lb_standorte.FormattingEnabled = true;
            this.lb_standorte.Location = new System.Drawing.Point(72, 9);
            this.lb_standorte.Name = "lb_standorte";
            this.lb_standorte.Size = new System.Drawing.Size(115, 69);
            this.lb_standorte.TabIndex = 7;
            this.lb_standorte.SelectedIndexChanged += new System.EventHandler(this.lb_standorte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Marken";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Standort";
            // 
            // lb_marken
            // 
            this.lb_marken.FormattingEnabled = true;
            this.lb_marken.Location = new System.Drawing.Point(72, 169);
            this.lb_marken.Name = "lb_marken";
            this.lb_marken.Size = new System.Drawing.Size(115, 82);
            this.lb_marken.TabIndex = 11;
            this.lb_marken.SelectedIndexChanged += new System.EventHandler(this.lb_marken_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Marke";
            // 
            // lb_markenAnStandort
            // 
            this.lb_markenAnStandort.FormattingEnabled = true;
            this.lb_markenAnStandort.Location = new System.Drawing.Point(277, 9);
            this.lb_markenAnStandort.Name = "lb_markenAnStandort";
            this.lb_markenAnStandort.Size = new System.Drawing.Size(115, 69);
            this.lb_markenAnStandort.TabIndex = 14;
            // 
            // lb_standortDerMarke
            // 
            this.lb_standortDerMarke.FormattingEnabled = true;
            this.lb_standortDerMarke.Location = new System.Drawing.Point(277, 169);
            this.lb_standortDerMarke.Name = "lb_standortDerMarke";
            this.lb_standortDerMarke.Size = new System.Drawing.Size(115, 82);
            this.lb_standortDerMarke.TabIndex = 15;
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 327);
            this.Controls.Add(this.lb_standortDerMarke);
            this.Controls.Add(this.lb_markenAnStandort);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_marken);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_standorte);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_loescheAuto);
            this.Controls.Add(this.btn_aendereAuto);
            this.Controls.Add(this.btn_neuesAuto);
            this.Controls.Add(this.btn_loescheStandort);
            this.Controls.Add(this.btn_aendereStandort);
            this.Controls.Add(this.btn_neuerStandort);
            this.Name = "GUI";
            this.Text = "GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_neuerStandort;
        private System.Windows.Forms.Button btn_aendereStandort;
        private System.Windows.Forms.Button btn_loescheStandort;
        private System.Windows.Forms.Button btn_neuesAuto;
        private System.Windows.Forms.Button btn_aendereAuto;
        private System.Windows.Forms.Button btn_loescheAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_standorte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_marken;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lb_markenAnStandort;
        private System.Windows.Forms.ListBox lb_standortDerMarke;
    }
}