namespace FQuery
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CheckConnection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBServer = new System.Windows.Forms.TextBox();
            this.TBPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TBDatabase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SendQuery = new System.Windows.Forms.Button();
            this.TBQuery = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.TBConnectionString = new System.Windows.Forms.TextBox();
            this.CBManual = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckConnection
            // 
            this.CheckConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckConnection.Location = new System.Drawing.Point(520, 247);
            this.CheckConnection.Name = "CheckConnection";
            this.CheckConnection.Size = new System.Drawing.Size(109, 23);
            this.CheckConnection.TabIndex = 0;
            this.CheckConnection.Text = "Сheck connection";
            this.CheckConnection.UseVisualStyleBackColor = true;
            this.CheckConnection.Click += new System.EventHandler(this.CheckConnection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // TBServer
            // 
            this.TBServer.Location = new System.Drawing.Point(9, 19);
            this.TBServer.Name = "TBServer";
            this.TBServer.Size = new System.Drawing.Size(128, 20);
            this.TBServer.TabIndex = 2;
            // 
            // TBPort
            // 
            this.TBPort.Location = new System.Drawing.Point(9, 58);
            this.TBPort.Name = "TBPort";
            this.TBPort.Size = new System.Drawing.Size(128, 20);
            this.TBPort.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // TBDatabase
            // 
            this.TBDatabase.Location = new System.Drawing.Point(9, 97);
            this.TBDatabase.Name = "TBDatabase";
            this.TBDatabase.Size = new System.Drawing.Size(128, 20);
            this.TBDatabase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Database";
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(9, 136);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(128, 20);
            this.TBLogin.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Login";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(9, 175);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.PasswordChar = '*';
            this.TBPassword.Size = new System.Drawing.Size(128, 20);
            this.TBPassword.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // SendQuery
            // 
            this.SendQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SendQuery.Location = new System.Drawing.Point(520, 276);
            this.SendQuery.Name = "SendQuery";
            this.SendQuery.Size = new System.Drawing.Size(154, 23);
            this.SendQuery.TabIndex = 11;
            this.SendQuery.Text = "Send query";
            this.SendQuery.UseVisualStyleBackColor = true;
            this.SendQuery.Click += new System.EventHandler(this.SendQuery_Click);
            // 
            // TBQuery
            // 
            this.TBQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBQuery.Location = new System.Drawing.Point(12, 25);
            this.TBQuery.Multiline = true;
            this.TBQuery.Name = "TBQuery";
            this.TBQuery.Size = new System.Drawing.Size(502, 274);
            this.TBQuery.TabIndex = 13;
            this.TBQuery.Text = "SHOW TABLES;";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Query";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(520, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(154, 230);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TBServer);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.TBPort);
            this.tabPage1.Controls.Add(this.TBPassword);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.TBDatabase);
            this.tabPage1.Controls.Add(this.TBLogin);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(146, 204);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Auto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.TBConnectionString);
            this.tabPage2.Controls.Add(this.CBManual);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(146, 204);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manual";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Connection string";
            // 
            // TBConnectionString
            // 
            this.TBConnectionString.Location = new System.Drawing.Point(9, 42);
            this.TBConnectionString.Name = "TBConnectionString";
            this.TBConnectionString.Size = new System.Drawing.Size(128, 20);
            this.TBConnectionString.TabIndex = 4;
            // 
            // CBManual
            // 
            this.CBManual.AutoSize = true;
            this.CBManual.Location = new System.Drawing.Point(9, 6);
            this.CBManual.Name = "CBManual";
            this.CBManual.Size = new System.Drawing.Size(82, 17);
            this.CBManual.TabIndex = 0;
            this.CBManual.Text = "Use manual";
            this.CBManual.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Location = new System.Drawing.Point(635, 247);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(39, 23);
            this.save.TabIndex = 15;
            this.save.Text = "save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.saveConnectionData);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 311);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.TBQuery);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SendQuery);
            this.Controls.Add(this.CheckConnection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(512, 350);
            this.Name = "Form1";
            this.Text = "FQuery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CheckConnection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBServer;
        private System.Windows.Forms.TextBox TBPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SendQuery;
        private System.Windows.Forms.TextBox TBQuery;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TBConnectionString;
        private System.Windows.Forms.CheckBox CBManual;
        private System.Windows.Forms.Button save;
    }
}

