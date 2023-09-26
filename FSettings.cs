using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Cashier
{
    public partial class FSettings : Form
    {
        public FSettings() => InitializeComponent();

        private void FSettings_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
            if (Properties.Settings.Default.FormStyle)
            { PB_Entry1.BackgroundImage = Properties.Resources.LightTouchpad1; PB_Entry2.BackgroundImage = Properties.Resources.LightTouchpad2; }
            else
            { PB_Entry1.BackgroundImage = Properties.Resources.DarkTouchpad1; PB_Entry2.BackgroundImage = Properties.Resources.DarkTouchpad2; }

            this.WindowState = FormWindowState.Maximized;
            TB_ServerName.Text = Properties.Settings.Default.ServerSave;
            TBar_LightOrDark.Value = Convert.ToInt32(Properties.Settings.Default.FormStyle);
            TBar_KeyboardOrMouse.Value = Convert.ToInt32(!Properties.Settings.Default.InputType);
        }

        private void Button_ServerName_Click(object sender, EventArgs e)
        { Properties.Settings.Default.ServerSave = TB_ServerName.Text; Properties.Settings.Default.Save(); ErrorTest(); }

        //Проверка на ошибку
        public static void ErrorTest()
        {
            //Проверка подключения к серверу и базе данных
            if (SQL.ServerСonnectionVerification(Properties.Settings.Default.ServerSave))
            {
                if (SQL.DataBaseСonnectionVerification(Properties.Settings.Default.ServerSave, "Program110"))
                {
                    MessageBox.Show("Сервер и база данных успешно проверены", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Authorization.ServerAccess = true;
                }
                else
                {
                    MessageBox.Show("База Данных не доступна", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Authorization.ServerAccess = false;
                }
            }
            else
            {
                MessageBox.Show("Сервер не доступен", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Authorization.ServerAccess = false;
            }
        }

        private void TBar_LightOrDark_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormStyle = Convert.ToBoolean(TBar_LightOrDark.Value);
            Properties.Settings.Default.Save(); FSettings_Load(sender, e);
        }

        private void TBar_KeyboardOrMouse_Scroll(object sender, EventArgs e)
        {
            Properties.Settings.Default.InputType = !Convert.ToBoolean(TBar_KeyboardOrMouse.Value);
            Properties.Settings.Default.Save();
        }

        private void TB_ServerName_Click(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.InputType)
            { TB_ServerName.Enabled = false; new MouseInput().Show(); MouseInput.Source = TB_ServerName; }
        }

        private void Button_Close_Click(object sender, EventArgs e) => this.Close();
    }
}