namespace desktop_csharp.views
{
    partial class FormRegisterPetugas
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
            this.textuser = new System.Windows.Forms.TextBox();
            this.cmbrole = new System.Windows.Forms.ComboBox();
            this.butsim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllog = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textnama = new System.Windows.Forms.TextBox();
            this.textpw = new System.Windows.Forms.TextBox();
            this.textkonfirpw = new System.Windows.Forms.TextBox();
            this.butbtl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(68, 73);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(221, 20);
            this.textuser.TabIndex = 0;
            // 
            // cmbrole
            // 
            this.cmbrole.FormattingEnabled = true;
            this.cmbrole.Location = new System.Drawing.Point(68, 332);
            this.cmbrole.Name = "cmbrole";
            this.cmbrole.Size = new System.Drawing.Size(221, 21);
            this.cmbrole.TabIndex = 1;
            // 
            // butsim
            // 
            this.butsim.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butsim.Location = new System.Drawing.Point(68, 372);
            this.butsim.Name = "butsim";
            this.butsim.Size = new System.Drawing.Size(97, 37);
            this.butsim.TabIndex = 2;
            this.butsim.Text = "Simpan";
            this.butsim.UseVisualStyleBackColor = false;
            this.butsim.Click += new System.EventHandler(this.butsim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Register";
            // 
            // lbllog
            // 
            this.lbllog.AutoSize = true;
            this.lbllog.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllog.Location = new System.Drawing.Point(66, 412);
            this.lbllog.Name = "lbllog";
            this.lbllog.Size = new System.Drawing.Size(44, 18);
            this.lbllog.TabIndex = 4;
            this.lbllog.TabStop = true;
            this.lbllog.Text = "Login";
            this.lbllog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbllog_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nama Petugas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Konfirmasi Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Role";
            // 
            // textnama
            // 
            this.textnama.Location = new System.Drawing.Point(68, 138);
            this.textnama.Name = "textnama";
            this.textnama.Size = new System.Drawing.Size(221, 20);
            this.textnama.TabIndex = 11;
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(68, 209);
            this.textpw.Name = "textpw";
            this.textpw.Size = new System.Drawing.Size(221, 20);
            this.textpw.TabIndex = 12;
            // 
            // textkonfirpw
            // 
            this.textkonfirpw.Location = new System.Drawing.Point(68, 273);
            this.textkonfirpw.Name = "textkonfirpw";
            this.textkonfirpw.Size = new System.Drawing.Size(221, 20);
            this.textkonfirpw.TabIndex = 13;
            // 
            // butbtl
            // 
            this.butbtl.BackColor = System.Drawing.Color.Red;
            this.butbtl.Location = new System.Drawing.Point(196, 372);
            this.butbtl.Name = "butbtl";
            this.butbtl.Size = new System.Drawing.Size(93, 37);
            this.butbtl.TabIndex = 14;
            this.butbtl.Text = "Batal";
            this.butbtl.UseVisualStyleBackColor = false;
            // 
            // FormRegisterPetugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.butbtl);
            this.Controls.Add(this.textkonfirpw);
            this.Controls.Add(this.textpw);
            this.Controls.Add(this.textnama);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbllog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butsim);
            this.Controls.Add(this.cmbrole);
            this.Controls.Add(this.textuser);
            this.Name = "FormRegisterPetugas";
            this.Text = "FormRegisterPetugas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.ComboBox cmbrole;
        private System.Windows.Forms.Button butsim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lbllog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textnama;
        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.TextBox textkonfirpw;
        private System.Windows.Forms.Button butbtl;
    }
}