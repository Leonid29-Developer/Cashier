using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    public partial class MouseInput : Form
    {
        public MouseInput() => InitializeComponent();

        private bool CapsLock = false, Language = false;

        public static TextBox Source { private get; set; }

        private void MouseInput_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
            if (Properties.Settings.Default.FormStyle) { Button_Language.BackgroundImage = Properties.Resources.LightLanguage; Button_CapsLock.BackgroundImage = Properties.Resources.LightCapsLockOff; }
            else { Button_Language.BackgroundImage = Properties.Resources.DarkLanguage; Button_CapsLock.BackgroundImage = Properties.Resources.DarkCapsLockOff; }
        }

        //Клавиши обычных символов
        private void Button_Сhar_Click(object sender, EventArgs e)
        {
            var But = (Button)sender;
            if (Source.TextLength <= Source.MaxLength) Source.Text += But.Text;
            else MessageBox.Show("Достигнута максимальная длина", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        //Специальные клавиши
        private void Button_CapsLock_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FormStyle)
            {
                if (!CapsLock) { CapsLock = true; Button_CapsLock.BackgroundImage = Properties.Resources.LightCapsLockOn; }
                else { CapsLock = false; Button_CapsLock.BackgroundImage = Properties.Resources.LightCapsLockOff; }
            }
            else
            {
                if (!CapsLock) { CapsLock = true; Button_CapsLock.BackgroundImage = Properties.Resources.DarkCapsLockOn; }
                else { CapsLock = false; Button_CapsLock.BackgroundImage = Properties.Resources.DarkCapsLockOff; }
            }
            UpdatingCharacters();
        }

        private void Button_Language_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.FormStyle) Button_Language.BackgroundImage = Properties.Resources.LightLanguage;
            else Button_Language.BackgroundImage = Properties.Resources.DarkLanguage;
            if (!Language) Language = true; else Language = false;
            UpdatingCharacters();
        }

        private void Button_Clear_Click(object sender, EventArgs e) => Source.Clear();

        private void Button_Backspace_Click(object sender, EventArgs e)
        { StringBuilder SB = new StringBuilder(Source.Text); SB.Remove(SB.Length - 1, 1); Source.Text = SB.ToString(); }

        private void Button_ENTER_Click(object sender, EventArgs e) => this.Close();

        //Изменение значения клавиш
        private void UpdatingCharacters()
        {
            string[] Symbols =
            {
                "~!@#$%^&*()QWERTYUIOP{}ASDFGHJKL:\"|ZXCVBNM<>?+",
                "`1234567890qwertyuiop[]asdfghjkl;'|zxcvbnm,./=",
                "Ё!\"№;%:?*()ЙЦУКЕНГШЩЗХЪФЫВАПРОЛДЖЭ\\ЯЧСМИТЬБЮ,_",
                "ё1234567890йцукенгшщзхъфывапролджэ\\ячсмитьбю.-"
            };

            if (Language)
            {
                if (CapsLock) for (int i = 0; i <= 45; i++) this.Controls["Button_Сhar_" + i].Text = Symbols[0][i].ToString();
                else for (int i = 0; i <= 45; i++) this.Controls["Button_Сhar_" + i].Text = Symbols[1][i].ToString();
            }
            else
            {
                if (CapsLock) for (int i = 0; i <= 45; i++) this.Controls["Button_Сhar_" + i].Text = Symbols[2][i].ToString();
                else for (int i = 0; i <= 45; i++) this.Controls["Button_Сhar_" + i].Text = Symbols[3][i].ToString();
            }
        }

        //Закрытие формы
        private void MouseInput_FormClosed(object sender, FormClosedEventArgs e) => Source.Enabled = true;
    }
}