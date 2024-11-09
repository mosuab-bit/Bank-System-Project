namespace Bank_Project_C_
{
    partial class MainMenueForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagePeopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUserToolStripMenuItem,
            this.manageClientToolStripMenuItem,
            this.ManagePeopleToolStripMenuItem,
            this.logRegisterToolStripMenuItem,
            this.signOutToolStripMenuItem,
            this.accountSettingsToolStripMenuItem,
            this.transactionToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1557, 72);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUserToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.user_config;
            this.manageUserToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(202, 68);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // manageClientToolStripMenuItem
            // 
            this.manageClientToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageClientToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.clients_config;
            this.manageClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageClientToolStripMenuItem.Name = "manageClientToolStripMenuItem";
            this.manageClientToolStripMenuItem.Size = new System.Drawing.Size(213, 68);
            this.manageClientToolStripMenuItem.Text = "Manage Client";
            this.manageClientToolStripMenuItem.Click += new System.EventHandler(this.manageClientToolStripMenuItem_Click);
            // 
            // ManagePeopleToolStripMenuItem
            // 
            this.ManagePeopleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagePeopleToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.users_config;
            this.ManagePeopleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ManagePeopleToolStripMenuItem.Name = "ManagePeopleToolStripMenuItem";
            this.ManagePeopleToolStripMenuItem.Size = new System.Drawing.Size(221, 68);
            this.ManagePeopleToolStripMenuItem.Text = "Manage People";
            this.ManagePeopleToolStripMenuItem.Click += new System.EventHandler(this.ManagePeopleToolStripMenuItem_Click);
            // 
            // logRegisterToolStripMenuItem
            // 
            this.logRegisterToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logRegisterToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.register;
            this.logRegisterToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logRegisterToolStripMenuItem.Name = "logRegisterToolStripMenuItem";
            this.logRegisterToolStripMenuItem.Size = new System.Drawing.Size(196, 68);
            this.logRegisterToolStripMenuItem.Text = "Log Register";
            this.logRegisterToolStripMenuItem.Click += new System.EventHandler(this.logRegisterToolStripMenuItem_Click_1);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositeToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.listTransactionsToolStripMenuItem});
            this.signOutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.operation;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(259, 68);
            this.signOutToolStripMenuItem.Text = "Banking Operations";
            // 
            // depositeToolStripMenuItem
            // 
            this.depositeToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.deposit_64;
            this.depositeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depositeToolStripMenuItem.Name = "depositeToolStripMenuItem";
            this.depositeToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.depositeToolStripMenuItem.Text = "Deposit";
            this.depositeToolStripMenuItem.Click += new System.EventHandler(this.depositeToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.withdrawal_64;
            this.withdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.bank_transaction;
            this.transactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.transactionToolStripMenuItem.Text = "Transfer";
            this.transactionToolStripMenuItem.Click += new System.EventHandler(this.transactionToolStripMenuItem_Click);
            // 
            // listTransactionsToolStripMenuItem
            // 
            this.listTransactionsToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.white_list;
            this.listTransactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.listTransactionsToolStripMenuItem.Name = "listTransactionsToolStripMenuItem";
            this.listTransactionsToolStripMenuItem.Size = new System.Drawing.Size(268, 70);
            this.listTransactionsToolStripMenuItem.Text = "List Transfers";
            this.listTransactionsToolStripMenuItem.Click += new System.EventHandler(this.listTransactionsToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSettingsToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.account_settings__1_;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(235, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.id__4_;
            this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(275, 54);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::Bank_Project_C_.Properties.Resources.password__1_;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(275, 54);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem1
            // 
            this.transactionToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactionToolStripMenuItem1.Image = global::Bank_Project_C_.Properties.Resources.sign_out__1_;
            this.transactionToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionToolStripMenuItem1.Name = "transactionToolStripMenuItem1";
            this.transactionToolStripMenuItem1.Size = new System.Drawing.Size(143, 68);
            this.transactionToolStripMenuItem1.Text = "SignOut";
            this.transactionToolStripMenuItem1.Click += new System.EventHandler(this.transactionToolStripMenuItem1_Click);
            // 
            // MainMenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Bank_Project_C_.Properties.Resources._662951710156171;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 719);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menue Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ManagePeopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listTransactionsToolStripMenuItem;
    }
}

