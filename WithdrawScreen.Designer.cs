namespace Bank_Project_C_
{
    partial class WithdrawScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WithdrawScreen));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btn100 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn600 = new System.Windows.Forms.Button();
            this.btn400 = new System.Windows.Forms.Button();
            this.btn200 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(149, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Withdrawal Amount";
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.Color.White;
            this.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustom.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustom.ForeColor = System.Drawing.Color.Black;
            this.btnCustom.Image = global::Bank_Project_C_.Properties.Resources.tax;
            this.btnCustom.Location = new System.Drawing.Point(295, 102);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(214, 63);
            this.btnCustom.TabIndex = 7;
            this.btnCustom.Text = " Custom";
            this.btnCustom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btn100
            // 
            this.btn100.BackColor = System.Drawing.Color.White;
            this.btn100.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn100.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn100.ForeColor = System.Drawing.Color.Black;
            this.btn100.Image = ((System.Drawing.Image)(resources.GetObject("btn100.Image")));
            this.btn100.Location = new System.Drawing.Point(600, 372);
            this.btn100.Name = "btn100";
            this.btn100.Size = new System.Drawing.Size(132, 63);
            this.btn100.TabIndex = 6;
            this.btn100.Tag = "100";
            this.btn100.Text = "100";
            this.btn100.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn100.UseVisualStyleBackColor = false;
            this.btn100.Click += new System.EventHandler(this.button_Click);
            // 
            // btn50
            // 
            this.btn50.BackColor = System.Drawing.Color.White;
            this.btn50.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn50.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn50.ForeColor = System.Drawing.Color.Black;
            this.btn50.Image = ((System.Drawing.Image)(resources.GetObject("btn50.Image")));
            this.btn50.Location = new System.Drawing.Point(600, 237);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(132, 63);
            this.btn50.TabIndex = 5;
            this.btn50.Tag = "50";
            this.btn50.Text = "50";
            this.btn50.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn50.UseVisualStyleBackColor = false;
            this.btn50.Click += new System.EventHandler(this.button_Click);
            // 
            // btn20
            // 
            this.btn20.BackColor = System.Drawing.Color.White;
            this.btn20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn20.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.ForeColor = System.Drawing.Color.Black;
            this.btn20.Image = ((System.Drawing.Image)(resources.GetObject("btn20.Image")));
            this.btn20.Location = new System.Drawing.Point(600, 102);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(132, 63);
            this.btn20.TabIndex = 4;
            this.btn20.Tag = "20";
            this.btn20.Text = "20";
            this.btn20.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn20.UseVisualStyleBackColor = false;
            this.btn20.Click += new System.EventHandler(this.button_Click);
            // 
            // btn600
            // 
            this.btn600.BackColor = System.Drawing.Color.White;
            this.btn600.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn600.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn600.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn600.ForeColor = System.Drawing.Color.Black;
            this.btn600.Image = ((System.Drawing.Image)(resources.GetObject("btn600.Image")));
            this.btn600.Location = new System.Drawing.Point(81, 372);
            this.btn600.Name = "btn600";
            this.btn600.Size = new System.Drawing.Size(132, 63);
            this.btn600.TabIndex = 3;
            this.btn600.Tag = "600";
            this.btn600.Text = "600";
            this.btn600.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn600.UseVisualStyleBackColor = false;
            this.btn600.Click += new System.EventHandler(this.button_Click);
            // 
            // btn400
            // 
            this.btn400.BackColor = System.Drawing.Color.White;
            this.btn400.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn400.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn400.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn400.ForeColor = System.Drawing.Color.Black;
            this.btn400.Image = ((System.Drawing.Image)(resources.GetObject("btn400.Image")));
            this.btn400.Location = new System.Drawing.Point(81, 237);
            this.btn400.Name = "btn400";
            this.btn400.Size = new System.Drawing.Size(132, 63);
            this.btn400.TabIndex = 2;
            this.btn400.Tag = "400";
            this.btn400.Text = "400";
            this.btn400.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn400.UseVisualStyleBackColor = false;
            this.btn400.Click += new System.EventHandler(this.button_Click);
            // 
            // btn200
            // 
            this.btn200.BackColor = System.Drawing.Color.White;
            this.btn200.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn200.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn200.Font = new System.Drawing.Font("Stencil", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn200.ForeColor = System.Drawing.Color.Black;
            this.btn200.Image = ((System.Drawing.Image)(resources.GetObject("btn200.Image")));
            this.btn200.Location = new System.Drawing.Point(81, 102);
            this.btn200.Name = "btn200";
            this.btn200.Size = new System.Drawing.Size(132, 63);
            this.btn200.TabIndex = 0;
            this.btn200.Tag = "200";
            this.btn200.Text = "200";
            this.btn200.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn200.UseVisualStyleBackColor = false;
            this.btn200.Click += new System.EventHandler(this.button_Click);
            // 
            // WithdrawScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.btn100);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn600);
            this.Controls.Add(this.btn400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn200);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WithdrawScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw Screen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn200;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn400;
        private System.Windows.Forms.Button btn600;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Button btn100;
        private System.Windows.Forms.Button btnCustom;
    }
}