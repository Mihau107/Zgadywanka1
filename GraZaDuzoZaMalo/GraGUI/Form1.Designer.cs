namespace GraGUI
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
            this.NowaGra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Losuj = new System.Windows.Forms.Button();
            this.textBoxdo = new System.Windows.Forms.TextBox();
            this.ZakresDo = new System.Windows.Forms.Label();
            this.textBoxod = new System.Windows.Forms.TextBox();
            this.ZakresOd = new System.Windows.Forms.Label();
            this.PodanaLiczba = new System.Windows.Forms.TextBox();
            this.Sprawdz_Click = new System.Windows.Forms.Button();
            this.Sprawdzanie_Box = new System.Windows.Forms.GroupBox();
            this.PodajLiczbe = new System.Windows.Forms.Label();
            this.komunikat = new System.Windows.Forms.Label();
            this.Poddanie = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Sprawdzanie_Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowaGra
            // 
            this.NowaGra.Location = new System.Drawing.Point(13, 13);
            this.NowaGra.Name = "NowaGra";
            this.NowaGra.Size = new System.Drawing.Size(75, 23);
            this.NowaGra.TabIndex = 0;
            this.NowaGra.Text = "NowaGra";
            this.NowaGra.UseVisualStyleBackColor = true;
            this.NowaGra.Click += new System.EventHandler(this.NowaGra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Losuj);
            this.groupBox1.Controls.Add(this.textBoxdo);
            this.groupBox1.Controls.Add(this.ZakresDo);
            this.groupBox1.Controls.Add(this.textBoxod);
            this.groupBox1.Controls.Add(this.ZakresOd);
            this.groupBox1.Location = new System.Drawing.Point(13, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Losuj
            // 
            this.Losuj.Location = new System.Drawing.Point(205, 59);
            this.Losuj.Name = "Losuj";
            this.Losuj.Size = new System.Drawing.Size(75, 23);
            this.Losuj.TabIndex = 2;
            this.Losuj.Text = "Wylosuj";
            this.Losuj.UseVisualStyleBackColor = true;
            this.Losuj.Click += new System.EventHandler(this.Losuj_Click);
            // 
            // textBoxdo
            // 
            this.textBoxdo.Location = new System.Drawing.Point(70, 59);
            this.textBoxdo.Name = "textBoxdo";
            this.textBoxdo.Size = new System.Drawing.Size(100, 20);
            this.textBoxdo.TabIndex = 3;
            // 
            // ZakresDo
            // 
            this.ZakresDo.AutoSize = true;
            this.ZakresDo.Location = new System.Drawing.Point(7, 59);
            this.ZakresDo.Name = "ZakresDo";
            this.ZakresDo.Size = new System.Drawing.Size(57, 13);
            this.ZakresDo.TabIndex = 2;
            this.ZakresDo.Text = "Zakres Do";
            // 
            // textBoxod
            // 
            this.textBoxod.Location = new System.Drawing.Point(70, 20);
            this.textBoxod.Name = "textBoxod";
            this.textBoxod.Size = new System.Drawing.Size(100, 20);
            this.textBoxod.TabIndex = 1;
            // 
            // ZakresOd
            // 
            this.ZakresOd.AutoSize = true;
            this.ZakresOd.Location = new System.Drawing.Point(7, 20);
            this.ZakresOd.Name = "ZakresOd";
            this.ZakresOd.Size = new System.Drawing.Size(57, 13);
            this.ZakresOd.TabIndex = 0;
            this.ZakresOd.Text = "Zakres Od";
            // 
            // PodanaLiczba
            // 
            this.PodanaLiczba.Location = new System.Drawing.Point(77, 46);
            this.PodanaLiczba.Name = "PodanaLiczba";
            this.PodanaLiczba.Size = new System.Drawing.Size(100, 20);
            this.PodanaLiczba.TabIndex = 2;
            this.PodanaLiczba.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Sprawdz_Click
            // 
            this.Sprawdz_Click.Location = new System.Drawing.Point(205, 84);
            this.Sprawdz_Click.Name = "Sprawdz_Click";
            this.Sprawdz_Click.Size = new System.Drawing.Size(75, 23);
            this.Sprawdz_Click.TabIndex = 3;
            this.Sprawdz_Click.Text = "Sprawdź";
            this.Sprawdz_Click.UseVisualStyleBackColor = true;
            this.Sprawdz_Click.Click += new System.EventHandler(this.Sprawdz_Click_Click);
            // 
            // Sprawdzanie_Box
            // 
            this.Sprawdzanie_Box.Controls.Add(this.komunikat);
            this.Sprawdzanie_Box.Controls.Add(this.PodajLiczbe);
            this.Sprawdzanie_Box.Controls.Add(this.Sprawdz_Click);
            this.Sprawdzanie_Box.Controls.Add(this.PodanaLiczba);
            this.Sprawdzanie_Box.Location = new System.Drawing.Point(13, 170);
            this.Sprawdzanie_Box.Name = "Sprawdzanie_Box";
            this.Sprawdzanie_Box.Size = new System.Drawing.Size(297, 196);
            this.Sprawdzanie_Box.TabIndex = 4;
            this.Sprawdzanie_Box.TabStop = false;
            this.Sprawdzanie_Box.Text = "Sprawdzanie";
            this.Sprawdzanie_Box.Visible = false;
            this.Sprawdzanie_Box.Enter += new System.EventHandler(this.Sprawdzanie_Box_Enter);
            // 
            // PodajLiczbe
            // 
            this.PodajLiczbe.AutoSize = true;
            this.PodajLiczbe.Location = new System.Drawing.Point(7, 53);
            this.PodajLiczbe.Name = "PodajLiczbe";
            this.PodajLiczbe.Size = new System.Drawing.Size(64, 13);
            this.PodajLiczbe.TabIndex = 4;
            this.PodajLiczbe.Text = "Podaj liczbę";
            this.PodajLiczbe.Click += new System.EventHandler(this.Label1_Click);
            // 
            // komunikat
            // 
            this.komunikat.AutoSize = true;
            this.komunikat.ForeColor = System.Drawing.Color.Red;
            this.komunikat.Location = new System.Drawing.Point(135, 156);
            this.komunikat.Name = "komunikat";
            this.komunikat.Size = new System.Drawing.Size(35, 13);
            this.komunikat.TabIndex = 6;
            this.komunikat.Text = "label2";
            this.komunikat.Visible = false;
            // 
            // Poddanie
            // 
            this.Poddanie.Location = new System.Drawing.Point(195, 473);
            this.Poddanie.Name = "Poddanie";
            this.Poddanie.Size = new System.Drawing.Size(98, 47);
            this.Poddanie.TabIndex = 5;
            this.Poddanie.Text = "Poddaj się";
            this.Poddanie.UseVisualStyleBackColor = true;
            this.Poddanie.Visible = false;
            this.Poddanie.Click += new System.EventHandler(this.Poddanie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 532);
            this.Controls.Add(this.Poddanie);
            this.Controls.Add(this.Sprawdzanie_Box);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NowaGra);
            this.Name = "Form1";
            this.Text = "Gra Za Dużo Za Mało";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Sprawdzanie_Box.ResumeLayout(false);
            this.Sprawdzanie_Box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NowaGra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxdo;
        private System.Windows.Forms.Label ZakresDo;
        private System.Windows.Forms.TextBox textBoxod;
        private System.Windows.Forms.Label ZakresOd;
        private System.Windows.Forms.Button Losuj;
        private System.Windows.Forms.TextBox PodanaLiczba;
        private System.Windows.Forms.Button Sprawdz_Click;
        private System.Windows.Forms.GroupBox Sprawdzanie_Box;
        private System.Windows.Forms.Label PodajLiczbe;
        private System.Windows.Forms.Label komunikat;
        private System.Windows.Forms.Button Poddanie;
    }
}

