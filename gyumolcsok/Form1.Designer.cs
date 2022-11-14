namespace gyumolcsok
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
            this.gyumolcs = new System.Windows.Forms.ListBox();
            this.gyumolcsgy = new System.Windows.Forms.GroupBox();
            this.Nev = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Mennyiseg = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.nevtxt = new System.Windows.Forms.TextBox();
            this.egysegtxt = new System.Windows.Forms.TextBox();
            this.mennyisegnum = new System.Windows.Forms.NumericUpDown();
            this.adattarol = new System.Windows.Forms.Button();
            this.gyumolcsgy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).BeginInit();
            this.SuspendLayout();
            // 
            // gyumolcs
            // 
            this.gyumolcs.Dock = System.Windows.Forms.DockStyle.Left;
            this.gyumolcs.FormattingEnabled = true;
            this.gyumolcs.Location = new System.Drawing.Point(0, 0);
            this.gyumolcs.Name = "gyumolcs";
            this.gyumolcs.Size = new System.Drawing.Size(199, 450);
            this.gyumolcs.TabIndex = 2;
            // 
            // gyumolcsgy
            // 
            this.gyumolcsgy.Controls.Add(this.adattarol);
            this.gyumolcsgy.Controls.Add(this.mennyisegnum);
            this.gyumolcsgy.Controls.Add(this.egysegtxt);
            this.gyumolcsgy.Controls.Add(this.nevtxt);
            this.gyumolcsgy.Controls.Add(this.IDtxt);
            this.gyumolcsgy.Controls.Add(this.Mennyiseg);
            this.gyumolcsgy.Controls.Add(this.ID);
            this.gyumolcsgy.Controls.Add(this.label1);
            this.gyumolcsgy.Controls.Add(this.Nev);
            this.gyumolcsgy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gyumolcsgy.Location = new System.Drawing.Point(199, 0);
            this.gyumolcsgy.Name = "gyumolcsgy";
            this.gyumolcsgy.Size = new System.Drawing.Size(601, 450);
            this.gyumolcsgy.TabIndex = 4;
            this.gyumolcsgy.TabStop = false;
            this.gyumolcsgy.Text = "Gyumolcs Adatok";
            // 
            // Nev
            // 
            this.Nev.AutoSize = true;
            this.Nev.Location = new System.Drawing.Point(43, 84);
            this.Nev.Name = "Nev";
            this.Nev.Size = new System.Drawing.Size(27, 13);
            this.Nev.TabIndex = 0;
            this.Nev.Text = "Nev";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Egységár";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(43, 52);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 2;
            this.ID.Text = "ID";
            // 
            // Mennyiseg
            // 
            this.Mennyiseg.AutoSize = true;
            this.Mennyiseg.Location = new System.Drawing.Point(43, 151);
            this.Mennyiseg.Name = "Mennyiseg";
            this.Mennyiseg.Size = new System.Drawing.Size(58, 13);
            this.Mennyiseg.TabIndex = 3;
            this.Mennyiseg.Text = "Mennyiseg";
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(109, 49);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(120, 20);
            this.IDtxt.TabIndex = 4;
            // 
            // nevtxt
            // 
            this.nevtxt.Location = new System.Drawing.Point(108, 82);
            this.nevtxt.Name = "nevtxt";
            this.nevtxt.Size = new System.Drawing.Size(120, 20);
            this.nevtxt.TabIndex = 5;
            // 
            // egysegtxt
            // 
            this.egysegtxt.Location = new System.Drawing.Point(108, 117);
            this.egysegtxt.Name = "egysegtxt";
            this.egysegtxt.Size = new System.Drawing.Size(121, 20);
            this.egysegtxt.TabIndex = 6;
            // 
            // mennyisegnum
            // 
            this.mennyisegnum.Location = new System.Drawing.Point(109, 149);
            this.mennyisegnum.Name = "mennyisegnum";
            this.mennyisegnum.Size = new System.Drawing.Size(89, 20);
            this.mennyisegnum.TabIndex = 7;
            // 
            // adattarol
            // 
            this.adattarol.Location = new System.Drawing.Point(109, 225);
            this.adattarol.Name = "adattarol";
            this.adattarol.Size = new System.Drawing.Size(114, 30);
            this.adattarol.TabIndex = 8;
            this.adattarol.Text = "Adattárolás";
            this.adattarol.UseVisualStyleBackColor = true;
            this.adattarol.Click += new System.EventHandler(this.adattarol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gyumolcsgy);
            this.Controls.Add(this.gyumolcs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gyumolcsgy.ResumeLayout(false);
            this.gyumolcsgy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mennyisegnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox gyumolcs;
        private System.Windows.Forms.GroupBox gyumolcsgy;
        private System.Windows.Forms.Label Nev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adattarol;
        private System.Windows.Forms.NumericUpDown mennyisegnum;
        private System.Windows.Forms.TextBox egysegtxt;
        private System.Windows.Forms.TextBox nevtxt;
        private System.Windows.Forms.TextBox IDtxt;
        private System.Windows.Forms.Label Mennyiseg;
        private System.Windows.Forms.Label ID;
    }
}

