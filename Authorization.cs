using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cashier
{
    public partial class Authorization : Form
    {
        public Authorization() { InitializeComponent(); }

        Thread Time = new Thread(() => Thread.Sleep(2000));

        public static bool ServerAccess { private get; set; }

        private void Authorization_Shown(object sender, EventArgs e)
        {
            Time.Start(); Time.Join(); Main(sender, e); FSettings.ErrorTest();
        }

        private void Main(object sender, EventArgs e)
        {
            //Установка параметров формы
            StyleUpdate();
            this.WindowState = FormWindowState.Maximized;

            if (!Properties.Settings.Default.FormStyle) Button_Settings.BackgroundImage = Properties.Resources.DarkSettings;
            else Button_Settings.BackgroundImage = Properties.Resources.LightSettings;
        }

        private void StyleUpdate()
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            new FSettings().ShowDialog(); Main(sender, e);
        }

        private void TBox_Login_Click(object sender, EventArgs e)
        {
            if (TBox_Login.Text == "Логин") { TBox_Login.Clear(); Label_Login.Visible = true; }
            if (!Properties.Settings.Default.InputType) { TBox_Login.Enabled = false; new MouseInput().Show(); MouseInput.Source = TBox_Login; }
        }
        private void TBox_Password_Click(object sender, EventArgs e)
        {
            if (TBox_Password.Text == "Пароль") { TBox_Password.Clear(); Label_Password.Visible = true; }
            if (!Properties.Settings.Default.InputType) { TBox_Password.Enabled = false; new MouseInput().Show(); MouseInput.Source = TBox_Password; }
        }

        private void TBox_Login_Leave(object sender, EventArgs e)
        { if (TBox_Login.Text == "" & Properties.Settings.Default.InputType) { TBox_Login.Text = "Логин"; Label_Login.Visible = false; } }
        private void TBox_Password_Leave(object sender, EventArgs e)
        { if (TBox_Password.Text == "" & Properties.Settings.Default.InputType) { TBox_Password.Text = "Пароль"; Label_Password.Visible = false; } }

        private void TBox_TextChanged(object sender, EventArgs e)
        {
            var TB = (System.Windows.Forms.TextBox)sender;
            if (TB.TextLength > TB.MaxLength) MessageBox.Show("Достигнута максимальная длина", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Button_Input_Click(object sender, EventArgs e)
        {
            List<List<string>> Data = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Authorization_ID] @Login = N'{TBox_Login.Text}', @Password = N'{TBox_Password.Text}';");

            if (Data.Count > 0) { new CashRegister().Show(); this.Hide(); CashRegister.ID = Data[0][0]; }
            else MessageBox.Show("Неверно введены данные", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Button_Exit_Click(object sender, EventArgs e) { this.Close(); FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this); }
    }
}