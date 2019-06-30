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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.groupBoxLosuj = new System.Windows.Forms.GroupBox();
            this.buttonLosuj = new System.Windows.Forms.Button();
            this.textBoxZakresDo = new System.Windows.Forms.TextBox();
            this.textBoxZakresOd = new System.Windows.Forms.TextBox();
            this.labelZakresDo = new System.Windows.Forms.Label();
            this.labelZakresOd = new System.Windows.Forms.Label();
            this.groupBoxLosowanie = new System.Windows.Forms.GroupBox();
            this.liczba = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.baton2 = new System.Windows.Forms.Button();
            this.baton1 = new System.Windows.Forms.Button();
            this.pole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.button_historia = new System.Windows.Forms.Button();
            this.groupBoxLosuj.SuspendLayout();
            this.groupBoxLosowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(37, 25);
            this.buttonNowaGra.Margin = new System.Windows.Forms.Padding(6);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(150, 44);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.buttonNowaGra_Click);
            // 
            // groupBoxLosuj
            // 
            this.groupBoxLosuj.Controls.Add(this.buttonLosuj);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresDo);
            this.groupBoxLosuj.Controls.Add(this.textBoxZakresOd);
            this.groupBoxLosuj.Controls.Add(this.labelZakresDo);
            this.groupBoxLosuj.Controls.Add(this.labelZakresOd);
            this.groupBoxLosuj.Location = new System.Drawing.Point(26, 83);
            this.groupBoxLosuj.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxLosuj.Name = "groupBoxLosuj";
            this.groupBoxLosuj.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxLosuj.Size = new System.Drawing.Size(586, 192);
            this.groupBoxLosuj.TabIndex = 1;
            this.groupBoxLosuj.TabStop = false;
            this.groupBoxLosuj.Text = "Losowanie";
            this.groupBoxLosuj.Visible = false;
            // 
            // buttonLosuj
            // 
            this.buttonLosuj.Location = new System.Drawing.Point(424, 78);
            this.buttonLosuj.Margin = new System.Windows.Forms.Padding(6);
            this.buttonLosuj.Name = "buttonLosuj";
            this.buttonLosuj.Size = new System.Drawing.Size(150, 44);
            this.buttonLosuj.TabIndex = 2;
            this.buttonLosuj.Text = "Wylosuj";
            this.buttonLosuj.UseVisualStyleBackColor = true;
            this.buttonLosuj.Click += new System.EventHandler(this.buttonLosuj_Click);
            // 
            // textBoxZakresDo
            // 
            this.textBoxZakresDo.Location = new System.Drawing.Point(182, 123);
            this.textBoxZakresDo.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxZakresDo.Name = "textBoxZakresDo";
            this.textBoxZakresDo.Size = new System.Drawing.Size(196, 31);
            this.textBoxZakresDo.TabIndex = 3;
            this.textBoxZakresDo.Text = "100";
            // 
            // textBoxZakresOd
            // 
            this.textBoxZakresOd.Location = new System.Drawing.Point(182, 52);
            this.textBoxZakresOd.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxZakresOd.Name = "textBoxZakresOd";
            this.textBoxZakresOd.Size = new System.Drawing.Size(196, 31);
            this.textBoxZakresOd.TabIndex = 2;
            this.textBoxZakresOd.Text = "1";
            // 
            // labelZakresDo
            // 
            this.labelZakresDo.AutoSize = true;
            this.labelZakresDo.Location = new System.Drawing.Point(36, 128);
            this.labelZakresDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZakresDo.Name = "labelZakresDo";
            this.labelZakresDo.Size = new System.Drawing.Size(114, 25);
            this.labelZakresDo.TabIndex = 1;
            this.labelZakresDo.Text = "Zakres do:";
            // 
            // labelZakresOd
            // 
            this.labelZakresOd.AutoSize = true;
            this.labelZakresOd.Location = new System.Drawing.Point(36, 58);
            this.labelZakresOd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelZakresOd.Name = "labelZakresOd";
            this.labelZakresOd.Size = new System.Drawing.Size(114, 25);
            this.labelZakresOd.TabIndex = 0;
            this.labelZakresOd.Text = "Zakres od:";
            // 
            // groupBoxLosowanie
            // 
            this.groupBoxLosowanie.Controls.Add(this.liczba);
            this.groupBoxLosowanie.Controls.Add(this.info);
            this.groupBoxLosowanie.Controls.Add(this.label4);
            this.groupBoxLosowanie.Controls.Add(this.label1);
            this.groupBoxLosowanie.Controls.Add(this.baton2);
            this.groupBoxLosowanie.Controls.Add(this.baton1);
            this.groupBoxLosowanie.Controls.Add(this.pole);
            this.groupBoxLosowanie.Controls.Add(this.label2);
            this.groupBoxLosowanie.Controls.Add(this.label);
            this.groupBoxLosowanie.Location = new System.Drawing.Point(66, 306);
            this.groupBoxLosowanie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosowanie.Name = "groupBoxLosowanie";
            this.groupBoxLosowanie.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxLosowanie.Size = new System.Drawing.Size(448, 266);
            this.groupBoxLosowanie.TabIndex = 4;
            this.groupBoxLosowanie.TabStop = false;
            this.groupBoxLosowanie.Text = "Losowanie";
            this.groupBoxLosowanie.Visible = false;
            this.groupBoxLosowanie.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // liczba
            // 
            this.liczba.AutoSize = true;
            this.liczba.Location = new System.Drawing.Point(242, 214);
            this.liczba.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.liczba.Name = "liczba";
            this.liczba.Size = new System.Drawing.Size(24, 25);
            this.liczba.TabIndex = 5;
            this.liczba.Text = "0";
            this.liczba.Click += new System.EventHandler(this.Liczba_Click);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.info.Location = new System.Drawing.Point(188, 69);
            this.info.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(0, 63);
            this.info.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Liczba ruchów";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 234);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 4;
            // 
            // baton2
            // 
            this.baton2.Location = new System.Drawing.Point(204, 159);
            this.baton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baton2.Name = "baton2";
            this.baton2.Size = new System.Drawing.Size(178, 36);
            this.baton2.TabIndex = 4;
            this.baton2.Text = "Poddaj się";
            this.baton2.UseVisualStyleBackColor = true;
            this.baton2.Click += new System.EventHandler(this.Baton2_Click);
            // 
            // baton1
            // 
            this.baton1.Location = new System.Drawing.Point(14, 159);
            this.baton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.baton1.Name = "baton1";
            this.baton1.Size = new System.Drawing.Size(166, 36);
            this.baton1.TabIndex = 3;
            this.baton1.Text = "Sprawdź";
            this.baton1.UseVisualStyleBackColor = true;
            this.baton1.Click += new System.EventHandler(this.Baton1_Click);
            // 
            // pole
            // 
            this.pole.Location = new System.Drawing.Point(14, 116);
            this.pole.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pole.Name = "pole";
            this.pole.Size = new System.Drawing.Size(148, 31);
            this.pole.TabIndex = 2;
            this.pole.Text = "0";
            this.pole.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 1;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(9, 69);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 25);
            this.label.TabIndex = 0;
            this.label.Text = "Podaj Liczby";
            // 
            // button_historia
            // 
            this.button_historia.Enabled = false;
            this.button_historia.Location = new System.Drawing.Point(450, 25);
            this.button_historia.Margin = new System.Windows.Forms.Padding(6);
            this.button_historia.Name = "button_historia";
            this.button_historia.Size = new System.Drawing.Size(150, 44);
            this.button_historia.TabIndex = 5;
            this.button_historia.Text = "Historia";
            this.button_historia.UseVisualStyleBackColor = false;
            this.button_historia.Click += new System.EventHandler(this.button_historia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 709);
            this.Controls.Add(this.button_historia);
            this.Controls.Add(this.groupBoxLosuj);
            this.Controls.Add(this.groupBoxLosowanie);
            this.Controls.Add(this.buttonNowaGra);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Zgadywanka";
            this.groupBoxLosuj.ResumeLayout(false);
            this.groupBoxLosuj.PerformLayout();
            this.groupBoxLosowanie.ResumeLayout(false);
            this.groupBoxLosowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.GroupBox groupBoxLosuj;
        private System.Windows.Forms.Button buttonLosuj;
        private System.Windows.Forms.TextBox textBoxZakresDo;
        private System.Windows.Forms.TextBox textBoxZakresOd;
        private System.Windows.Forms.Label labelZakresDo;
        private System.Windows.Forms.Label labelZakresOd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBoxLosowanie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button baton2;
        private System.Windows.Forms.Button baton1;
        private System.Windows.Forms.TextBox pole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label liczba;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Button button_historia;
    }
}

