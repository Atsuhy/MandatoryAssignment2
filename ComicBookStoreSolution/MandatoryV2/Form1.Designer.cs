namespace MandatoryV2
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
            this.textBoxAdmin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonStock = new System.Windows.Forms.Button();
            this.buttonValue = new System.Windows.Forms.Button();
            this.buttonSell = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAdmin
            // 
            this.textBoxAdmin.Location = new System.Drawing.Point(167, 215);
            this.textBoxAdmin.Name = "textBoxAdmin";
            this.textBoxAdmin.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdmin.TabIndex = 1;
            this.textBoxAdmin.TextChanged += new System.EventHandler(this.textBoxAdmin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(167, 241);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(167, 267);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(129, 215);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(32, 13);
            this.labelUser.TabIndex = 4;
            this.labelUser.Text = "User:";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(105, 241);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(190, 17);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 140);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 104);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(9, 10);
            this.buttonStock.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(76, 19);
            this.buttonStock.TabIndex = 7;
            this.buttonStock.Text = "Stock";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // buttonValue
            // 
            this.buttonValue.Location = new System.Drawing.Point(9, 33);
            this.buttonValue.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValue.Name = "buttonValue";
            this.buttonValue.Size = new System.Drawing.Size(76, 19);
            this.buttonValue.TabIndex = 7;
            this.buttonValue.Text = "Value";
            this.buttonValue.UseVisualStyleBackColor = true;
            this.buttonValue.Click += new System.EventHandler(this.buttonValue_Click);
            // 
            // buttonSell
            // 
            this.buttonSell.Location = new System.Drawing.Point(9, 57);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(76, 19);
            this.buttonSell.TabIndex = 7;
            this.buttonSell.Text = "Sell";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(357, 193);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(118, 35);
            this.buttonStatus.TabIndex = 7;
            this.buttonStatus.Text = "Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Location = new System.Drawing.Point(326, 284);
            this.buttonQuit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(116, 40);
            this.buttonQuit.TabIndex = 7;
            this.buttonQuit.Text = "QUIT";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.buttonStatus);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.buttonValue);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxAdmin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxAdmin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button buttonValue;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonQuit;
    }
}

