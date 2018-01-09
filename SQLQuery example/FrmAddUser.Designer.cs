namespace SQLQuery_example
{
    partial class FrmAddUser
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPass1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPass2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LblInf = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(21, 166);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(194, 23);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Add new user";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(81, 16);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(134, 20);
            this.TxtName.TabIndex = 2;
            this.TxtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtName_KeyDown);
            // 
            // TxtSurname
            // 
            this.TxtSurname.Location = new System.Drawing.Point(81, 44);
            this.TxtSurname.Name = "TxtSurname";
            this.TxtSurname.Size = new System.Drawing.Size(134, 20);
            this.TxtSurname.TabIndex = 4;
            this.TxtSurname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSurname_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Surname:";
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(81, 72);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(134, 20);
            this.TxtUsername.TabIndex = 6;
            this.TxtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUsername_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username:";
            // 
            // TxtPass1
            // 
            this.TxtPass1.Location = new System.Drawing.Point(81, 100);
            this.TxtPass1.Name = "TxtPass1";
            this.TxtPass1.PasswordChar = '*';
            this.TxtPass1.Size = new System.Drawing.Size(134, 20);
            this.TxtPass1.TabIndex = 8;
            this.TxtPass1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtPass1_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password:";
            // 
            // TxtPass2
            // 
            this.TxtPass2.Location = new System.Drawing.Point(81, 129);
            this.TxtPass2.Name = "TxtPass2";
            this.TxtPass2.PasswordChar = '*';
            this.TxtPass2.Size = new System.Drawing.Size(134, 20);
            this.TxtPass2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password:";
            // 
            // LblInf
            // 
            this.LblInf.AutoSize = true;
            this.LblInf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblInf.ForeColor = System.Drawing.Color.Red;
            this.LblInf.Location = new System.Drawing.Point(219, 129);
            this.LblInf.Name = "LblInf";
            this.LblInf.Size = new System.Drawing.Size(14, 18);
            this.LblInf.TabIndex = 11;
            this.LblInf.Text = "*";
            this.LblInf.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LblInf_MouseMove);
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 203);
            this.Controls.Add(this.LblInf);
            this.Controls.Add(this.TxtPass2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtUsername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAdd);
            this.Name = "FrmAddUser";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPass2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblInf;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}