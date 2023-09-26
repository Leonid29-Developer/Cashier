namespace Cashier
{
    partial class Authorization
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization));
            this.label1 = new System.Windows.Forms.Label();
            this.Label_Login = new System.Windows.Forms.Label();
            this.TBox_Login = new System.Windows.Forms.TextBox();
            this.TBox_Password = new System.Windows.Forms.TextBox();
            this.Label_Password = new System.Windows.Forms.Label();
            this.Button_Input = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Авторизация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Login
            // 
            this.Label_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Login.BackColor = System.Drawing.Color.Transparent;
            this.Label_Login.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Login.Location = new System.Drawing.Point(24, 170);
            this.Label_Login.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(337, 19);
            this.Label_Login.TabIndex = 9;
            this.Label_Login.Text = "Логин";
            this.Label_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Login.Visible = false;
            // 
            // TBox_Login
            // 
            this.TBox_Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBox_Login.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBox_Login.Location = new System.Drawing.Point(39, 209);
            this.TBox_Login.Margin = new System.Windows.Forms.Padding(30, 20, 30, 3);
            this.TBox_Login.MaxLength = 25;
            this.TBox_Login.Name = "TBox_Login";
            this.TBox_Login.Size = new System.Drawing.Size(307, 26);
            this.TBox_Login.TabIndex = 10;
            this.TBox_Login.Text = "Логин";
            this.TBox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBox_Login.Click += new System.EventHandler(this.TBox_Login_Click);
            this.TBox_Login.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            this.TBox_Login.Leave += new System.EventHandler(this.TBox_Login_Leave);
            // 
            // TBox_Password
            // 
            this.TBox_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBox_Password.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBox_Password.Location = new System.Drawing.Point(39, 297);
            this.TBox_Password.Margin = new System.Windows.Forms.Padding(30, 20, 30, 3);
            this.TBox_Password.MaxLength = 25;
            this.TBox_Password.Name = "TBox_Password";
            this.TBox_Password.Size = new System.Drawing.Size(307, 26);
            this.TBox_Password.TabIndex = 12;
            this.TBox_Password.Text = "Пароль";
            this.TBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBox_Password.Click += new System.EventHandler(this.TBox_Password_Click);
            this.TBox_Password.TextChanged += new System.EventHandler(this.TBox_TextChanged);
            this.TBox_Password.Leave += new System.EventHandler(this.TBox_Password_Leave);
            // 
            // Label_Password
            // 
            this.Label_Password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Password.BackColor = System.Drawing.Color.Transparent;
            this.Label_Password.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Password.Location = new System.Drawing.Point(24, 258);
            this.Label_Password.Margin = new System.Windows.Forms.Padding(15, 20, 15, 0);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(337, 19);
            this.Label_Password.TabIndex = 11;
            this.Label_Password.Text = "Пароль";
            this.Label_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label_Password.Visible = false;
            // 
            // Button_Input
            // 
            this.Button_Input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Input.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Input.Location = new System.Drawing.Point(89, 366);
            this.Button_Input.Margin = new System.Windows.Forms.Padding(80, 40, 80, 3);
            this.Button_Input.Name = "Button_Input";
            this.Button_Input.Size = new System.Drawing.Size(207, 40);
            this.Button_Input.TabIndex = 13;
            this.Button_Input.Text = "Войти";
            this.Button_Input.UseVisualStyleBackColor = true;
            this.Button_Input.Click += new System.EventHandler(this.Button_Input_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Exit.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Exit.Location = new System.Drawing.Point(89, 449);
            this.Button_Exit.Margin = new System.Windows.Forms.Padding(80, 40, 80, 3);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(207, 40);
            this.Button_Exit.TabIndex = 14;
            this.Button_Exit.Text = "Выйти";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_Settings.BackColor = System.Drawing.Color.Transparent;
            this.Button_Settings.BackgroundImage = global::Cashier.Properties.Resources.DarkSettings;
            this.Button_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button_Settings.Cursor = System.Windows.Forms.Cursors.Default;
            this.Button_Settings.FlatAppearance.BorderSize = 0;
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Settings.Location = new System.Drawing.Point(301, 24);
            this.Button_Settings.Margin = new System.Windows.Forms.Padding(3, 15, 15, 3);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(60, 60);
            this.Button_Settings.TabIndex = 7;
            this.Button_Settings.Tag = "NoColorStyle";
            this.Button_Settings.UseVisualStyleBackColor = false;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 514);
            this.ControlBox = false;
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Settings);
            this.Controls.Add(this.Button_Input);
            this.Controls.Add(this.TBox_Password);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.TBox_Login);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authorization";
            this.Shown += new System.EventHandler(this.Authorization_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Button_Settings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.TextBox TBox_Login;
        private System.Windows.Forms.TextBox TBox_Password;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button Button_Input;
        private System.Windows.Forms.Button Button_Exit;
    }
}

