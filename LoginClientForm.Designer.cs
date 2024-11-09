namespace Bank_Project_C_
{
    partial class LoginClientForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccNum = new System.Windows.Forms.TextBox();
            this.txtPinCode = new System.Windows.Forms.TextBox();
            this.lblClientNotFound = new System.Windows.Forms.Label();
            this.checkbShow = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.checbRemberMe = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Account Number :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(116, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pin Code :";
            // 
            // txtAccNum
            // 
            this.txtAccNum.BackColor = System.Drawing.Color.White;
            this.txtAccNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAccNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccNum.ForeColor = System.Drawing.Color.Black;
            this.txtAccNum.Location = new System.Drawing.Point(323, 209);
            this.txtAccNum.Name = "txtAccNum";
            this.txtAccNum.Size = new System.Drawing.Size(285, 30);
            this.txtAccNum.TabIndex = 0;
            // 
            // txtPinCode
            // 
            this.txtPinCode.BackColor = System.Drawing.Color.White;
            this.txtPinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPinCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPinCode.ForeColor = System.Drawing.Color.Black;
            this.txtPinCode.Location = new System.Drawing.Point(323, 286);
            this.txtPinCode.Name = "txtPinCode";
            this.txtPinCode.Size = new System.Drawing.Size(285, 30);
            this.txtPinCode.TabIndex = 1;
            this.txtPinCode.UseSystemPasswordChar = true;
            // 
            // lblClientNotFound
            // 
            this.lblClientNotFound.AutoSize = true;
            this.lblClientNotFound.Font = new System.Drawing.Font("Stencil", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientNotFound.ForeColor = System.Drawing.Color.Navy;
            this.lblClientNotFound.Location = new System.Drawing.Point(284, 394);
            this.lblClientNotFound.Name = "lblClientNotFound";
            this.lblClientNotFound.Size = new System.Drawing.Size(0, 35);
            this.lblClientNotFound.TabIndex = 12;
            // 
            // checkbShow
            // 
            this.checkbShow.AutoSize = true;
            this.checkbShow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checkbShow.Location = new System.Drawing.Point(252, 354);
            this.checkbShow.Name = "checkbShow";
            this.checkbShow.Size = new System.Drawing.Size(65, 20);
            this.checkbShow.TabIndex = 2;
            this.checkbShow.Text = "Show ";
            this.checkbShow.UseVisualStyleBackColor = true;
            this.checkbShow.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // checbRemberMe
            // 
            this.checbRemberMe.AutoSize = true;
            this.checbRemberMe.Checked = true;
            this.checbRemberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checbRemberMe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.checbRemberMe.Location = new System.Drawing.Point(323, 354);
            this.checbRemberMe.Name = "checbRemberMe";
            this.checbRemberMe.Size = new System.Drawing.Size(100, 20);
            this.checbRemberMe.TabIndex = 3;
            this.checbRemberMe.Text = "Rember Me";
            this.checbRemberMe.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Bank_Project_C_.Properties.Resources.password__2_;
            this.pictureBox3.Location = new System.Drawing.Point(270, 286);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(47, 38);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank_Project_C_.Properties.Resources.account;
            this.pictureBox2.Location = new System.Drawing.Point(285, 209);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 26);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank_Project_C_.Properties.Resources._153_1531291_transparent_world_bank_logo_png_world_bank_logo;
            this.pictureBox1.Location = new System.Drawing.Point(252, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Navy;
            this.btnLogin.Image = global::Bank_Project_C_.Properties.Resources.sign_in;
            this.btnLogin.Location = new System.Drawing.Point(311, 416);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(183, 98);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = " Login";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 526);
            this.Controls.Add(this.checbRemberMe);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.checkbShow);
            this.Controls.Add(this.lblClientNotFound);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPinCode);
            this.Controls.Add(this.txtAccNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client Login Screen";
            this.Activated += new System.EventHandler(this.LoginClientForm_Activated);
            this.Load += new System.EventHandler(this.LoginClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccNum;
        private System.Windows.Forms.TextBox txtPinCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblClientNotFound;
        private System.Windows.Forms.CheckBox checkbShow;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox checbRemberMe;
    }
}