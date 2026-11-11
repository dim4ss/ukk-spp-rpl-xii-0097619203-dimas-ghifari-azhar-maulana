namespace desktop_csharp.views
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.textpw = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.butlog = new System.Windows.Forms.Button();
            this.textuser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.butbtl = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textpw
            // 
            this.textpw.Location = new System.Drawing.Point(22, 172);
            this.textpw.Name = "textpw";
            this.textpw.PasswordChar = '*';
            this.textpw.Size = new System.Drawing.Size(224, 20);
            this.textpw.TabIndex = 0;
            this.textpw.UseSystemPasswordChar = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // butlog
            // 
            this.butlog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butlog.Location = new System.Drawing.Point(22, 207);
            this.butlog.Name = "butlog";
            this.butlog.Size = new System.Drawing.Size(224, 39);
            this.butlog.TabIndex = 3;
            this.butlog.Text = "Login";
            this.butlog.UseVisualStyleBackColor = false;
            this.butlog.Click += new System.EventHandler(this.button1_Click);
            // 
            // textuser
            // 
            this.textuser.Location = new System.Drawing.Point(22, 107);
            this.textuser.Name = "textuser";
            this.textuser.PasswordChar = '*';
            this.textuser.Size = new System.Drawing.Size(224, 20);
            this.textuser.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            // 
            // butbtl
            // 
            this.butbtl.BackColor = System.Drawing.Color.Red;
            this.butbtl.Location = new System.Drawing.Point(22, 252);
            this.butbtl.Name = "butbtl";
            this.butbtl.Size = new System.Drawing.Size(224, 37);
            this.butbtl.TabIndex = 7;
            this.butbtl.Text = "Batal";
            this.butbtl.UseVisualStyleBackColor = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(19, 292);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 18);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // FormLogin
            // 
            this.AcceptButton = this.butlog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 339);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.butbtl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.butlog);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textpw);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textpw;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butlog;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butbtl;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}