namespace Cashier
{
    partial class FSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSettings));
            this.Label_ServerName = new System.Windows.Forms.Label();
            this.TB_ServerName = new System.Windows.Forms.TextBox();
            this.Button_ServerName = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TBar_LightOrDark = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PB_Entry1 = new System.Windows.Forms.PictureBox();
            this.PB_Entry2 = new System.Windows.Forms.PictureBox();
            this.TBar_KeyboardOrMouse = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.Button_Close = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_LightOrDark)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entry1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entry2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_KeyboardOrMouse)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_ServerName
            // 
            this.Label_ServerName.Location = new System.Drawing.Point(5, 15);
            this.Label_ServerName.Margin = new System.Windows.Forms.Padding(5, 15, 5, 10);
            this.Label_ServerName.Name = "Label_ServerName";
            this.Label_ServerName.Size = new System.Drawing.Size(462, 34);
            this.Label_ServerName.TabIndex = 0;
            this.Label_ServerName.Text = "Имя сервера";
            this.Label_ServerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ServerName
            // 
            this.TB_ServerName.Location = new System.Drawing.Point(39, 62);
            this.TB_ServerName.Name = "TB_ServerName";
            this.TB_ServerName.Size = new System.Drawing.Size(394, 26);
            this.TB_ServerName.TabIndex = 1;
            this.TB_ServerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ServerName.Click += new System.EventHandler(this.TB_ServerName_Click);
            // 
            // Button_ServerName
            // 
            this.Button_ServerName.Location = new System.Drawing.Point(39, 110);
            this.Button_ServerName.Name = "Button_ServerName";
            this.Button_ServerName.Size = new System.Drawing.Size(394, 32);
            this.Button_ServerName.TabIndex = 2;
            this.Button_ServerName.Text = "Сохранить имя сервера и проверить подключение";
            this.Button_ServerName.UseVisualStyleBackColor = true;
            this.Button_ServerName.Click += new System.EventHandler(this.Button_ServerName_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Label_ServerName);
            this.panel1.Controls.Add(this.Button_ServerName);
            this.panel1.Controls.Add(this.TB_ServerName);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 176);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(187, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Настройки";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TBar_LightOrDark);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 271);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(474, 132);
            this.panel2.TabIndex = 4;
            // 
            // TBar_LightOrDark
            // 
            this.TBar_LightOrDark.AutoSize = false;
            this.TBar_LightOrDark.LargeChange = 3;
            this.TBar_LightOrDark.Location = new System.Drawing.Point(184, 77);
            this.TBar_LightOrDark.Maximum = 1;
            this.TBar_LightOrDark.Name = "TBar_LightOrDark";
            this.TBar_LightOrDark.Size = new System.Drawing.Size(104, 26);
            this.TBar_LightOrDark.TabIndex = 3;
            this.TBar_LightOrDark.TickFrequency = 0;
            this.TBar_LightOrDark.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TBar_LightOrDark.Scroll += new System.EventHandler(this.TBar_LightOrDark_Scroll);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(301, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Темная";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Светлая";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 15, 5, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Цветовой стиль программы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.PB_Entry1);
            this.panel3.Controls.Add(this.PB_Entry2);
            this.panel3.Controls.Add(this.TBar_KeyboardOrMouse);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 426);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(474, 132);
            this.panel3.TabIndex = 5;
            // 
            // PB_Entry1
            // 
            this.PB_Entry1.BackgroundImage = global::Cashier.Properties.Resources.DarkTouchpad1;
            this.PB_Entry1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Entry1.Location = new System.Drawing.Point(131, 68);
            this.PB_Entry1.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.PB_Entry1.Name = "PB_Entry1";
            this.PB_Entry1.Size = new System.Drawing.Size(35, 35);
            this.PB_Entry1.TabIndex = 8;
            this.PB_Entry1.TabStop = false;
            // 
            // PB_Entry2
            // 
            this.PB_Entry2.BackgroundImage = global::Cashier.Properties.Resources.DarkTouchpad2;
            this.PB_Entry2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PB_Entry2.Location = new System.Drawing.Point(306, 68);
            this.PB_Entry2.Margin = new System.Windows.Forms.Padding(15, 3, 3, 3);
            this.PB_Entry2.Name = "PB_Entry2";
            this.PB_Entry2.Size = new System.Drawing.Size(35, 35);
            this.PB_Entry2.TabIndex = 7;
            this.PB_Entry2.TabStop = false;
            // 
            // TBar_KeyboardOrMouse
            // 
            this.TBar_KeyboardOrMouse.AutoSize = false;
            this.TBar_KeyboardOrMouse.LargeChange = 3;
            this.TBar_KeyboardOrMouse.Location = new System.Drawing.Point(184, 77);
            this.TBar_KeyboardOrMouse.Maximum = 1;
            this.TBar_KeyboardOrMouse.Name = "TBar_KeyboardOrMouse";
            this.TBar_KeyboardOrMouse.Size = new System.Drawing.Size(104, 26);
            this.TBar_KeyboardOrMouse.TabIndex = 6;
            this.TBar_KeyboardOrMouse.TickFrequency = 0;
            this.TBar_KeyboardOrMouse.TickStyle = System.Windows.Forms.TickStyle.None;
            this.TBar_KeyboardOrMouse.Scroll += new System.EventHandler(this.TBar_KeyboardOrMouse_Scroll);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(5, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 15, 5, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(462, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Тип ввода данных";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Close
            // 
            this.Button_Close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Location = new System.Drawing.Point(99, 581);
            this.Button_Close.Margin = new System.Windows.Forms.Padding(90, 20, 90, 10);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(300, 35);
            this.Button_Close.TabIndex = 6;
            this.Button_Close.Text = "Закрыть";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(326, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 15, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 17);
            this.label5.TabIndex = 4;
            this.label5.Tag = "Kod1";
            this.label5.Text = "Version 1.01.0185";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 635);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Button_Close);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FSettings";
            this.Load += new System.EventHandler(this.FSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TBar_LightOrDark)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entry1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Entry2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBar_KeyboardOrMouse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_ServerName;
        private System.Windows.Forms.TextBox TB_ServerName;
        private System.Windows.Forms.Button Button_ServerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TrackBar TBar_LightOrDark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar TBar_KeyboardOrMouse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox PB_Entry1;
        private System.Windows.Forms.PictureBox PB_Entry2;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Label label5;
    }
}