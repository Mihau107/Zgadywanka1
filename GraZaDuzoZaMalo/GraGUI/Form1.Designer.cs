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
            this.btnNowaGra = new System.Windows.Forms.Button();
            this.grpBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.lblZakresOd = new System.Windows.Forms.Label();
            this.lblZakresDo = new System.Windows.Forms.Label();
            this.textBoxOd = new System.Windows.Forms.TextBox();
            this.textBoxDo = new System.Windows.Forms.TextBox();
            this.btnLosuj = new System.Windows.Forms.Button();
            this.grpBoxLosowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowaGra
            // 
            this.btnNowaGra.Location = new System.Drawing.Point(13, 13);
            this.btnNowaGra.Name = "btnNowaGra";
            this.btnNowaGra.Size = new System.Drawing.Size(75, 23);
            this.btnNowaGra.TabIndex = 0;
            this.btnNowaGra.Text = "Nowa gra";
            this.btnNowaGra.UseVisualStyleBackColor = true;
            this.btnNowaGra.Click += new System.EventHandler(this.btnNowaGra_Click);
            // 
            // grpBoxLosowanie
            // 
            this.grpBoxLosowanie.Controls.Add(this.btnLosuj);
            this.grpBoxLosowanie.Controls.Add(this.textBoxDo);
            this.grpBoxLosowanie.Controls.Add(this.textBoxOd);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresDo);
            this.grpBoxLosowanie.Controls.Add(this.lblZakresOd);
            this.grpBoxLosowanie.Location = new System.Drawing.Point(13, 52);
            this.grpBoxLosowanie.Name = "grpBoxLosowanie";
            this.grpBoxLosowanie.Size = new System.Drawing.Size(287, 121);
            this.grpBoxLosowanie.TabIndex = 1;
            this.grpBoxLosowanie.TabStop = false;
            this.grpBoxLosowanie.Text = "Losowanie";
            this.grpBoxLosowanie.Visible = false;
            // 
            // lblZakresOd
            // 
            this.lblZakresOd.AutoSize = true;
            this.lblZakresOd.Location = new System.Drawing.Point(23, 28);
            this.lblZakresOd.Name = "lblZakresOd";
            this.lblZakresOd.Size = new System.Drawing.Size(58, 13);
            this.lblZakresOd.TabIndex = 0;
            this.lblZakresOd.Text = "Zakres od:";
            // 
            // lblZakresDo
            // 
            this.lblZakresDo.AutoSize = true;
            this.lblZakresDo.Location = new System.Drawing.Point(23, 77);
            this.lblZakresDo.Name = "lblZakresDo";
            this.lblZakresDo.Size = new System.Drawing.Size(58, 13);
            this.lblZakresDo.TabIndex = 1;
            this.lblZakresDo.Text = "Zakres do:";
            // 
            // textBoxOd
            // 
            this.textBoxOd.Location = new System.Drawing.Point(87, 25);
            this.textBoxOd.Name = "textBoxOd";
            this.textBoxOd.Size = new System.Drawing.Size(100, 20);
            this.textBoxOd.TabIndex = 2;
            // 
            // textBoxDo
            // 
            this.textBoxDo.Location = new System.Drawing.Point(87, 74);
            this.textBoxDo.Name = "textBoxDo";
            this.textBoxDo.Size = new System.Drawing.Size(100, 20);
            this.textBoxDo.TabIndex = 3;
            // 
            // btnLosuj
            // 
            this.btnLosuj.Location = new System.Drawing.Point(206, 46);
            this.btnLosuj.Name = "btnLosuj";
            this.btnLosuj.Size = new System.Drawing.Size(75, 23);
            this.btnLosuj.TabIndex = 2;
            this.btnLosuj.Text = "Wylosuj";
            this.btnLosuj.UseVisualStyleBackColor = true;
            this.btnLosuj.Click += new System.EventHandler(this.btnLosuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 362);
            this.Controls.Add(this.grpBoxLosowanie);
            this.Controls.Add(this.btnNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBoxLosowanie.ResumeLayout(false);
            this.grpBoxLosowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNowaGra;
        private System.Windows.Forms.GroupBox grpBoxLosowanie;
        private System.Windows.Forms.Button btnLosuj;
        private System.Windows.Forms.TextBox textBoxDo;
        private System.Windows.Forms.TextBox textBoxOd;
        private System.Windows.Forms.Label lblZakresDo;
        private System.Windows.Forms.Label lblZakresOd;
    }
}

