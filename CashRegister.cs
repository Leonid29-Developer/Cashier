using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cashier
{
    public partial class CashRegister : Form
    {
        public CashRegister() => InitializeComponent();

        public static string ID { get; set; }

        public static List<List<string>> PurchaseReceipt_Table;

        private void CashRegister_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            StyleUpdate();
            Button_Payment.Location = new Point(Button_Payment.Location.X - 110, Button_Payment.Location.Y);
            Button_Cancel.Location = new Point(Button_Cancel.Location.X - 90, Button_Payment.Location.Y);
            this.WindowState = FormWindowState.Maximized;
            FormSettings.DimensionalSettings(this, 950, 800);

            string[] Tab = { "Index", "Name", "Size", "Price", "Quantity" }; PurchaseReceipt_Table = SQL.LocalDB(Tab);
        }

        private void StyleUpdate()
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);

            if (!Properties.Settings.Default.FormStyle)
            {
                Button_Menu.BackgroundImage = Properties.Resources.DarkMenu; Button_Discount.BackgroundImage = Properties.Resources.DarkDiscount;
                Button_Payment.BackgroundImage = Properties.Resources.DarkPayment; Button_Cancel.BackgroundImage = Properties.Resources.DarkFrame;
                Button_Settings.BackgroundImage = Properties.Resources.DarkSettings;

                for (int i = 0; i <= 24; i++) this.Controls["Button_PopularProducts_" + i].BackgroundImage = Properties.Resources.DarkFrame;
                for (int i = 0; i <= 5; i++) this.Controls["Button_PopularService_" + i].BackgroundImage = Properties.Resources.DarkFrame;
            }
            else
            {
                Button_Menu.BackgroundImage = Properties.Resources.LightMenu; Button_Discount.BackgroundImage = Properties.Resources.LightDiscount;
                Button_Payment.BackgroundImage = Properties.Resources.LightPayment; Button_Cancel.BackgroundImage = Properties.Resources.LightFrame;
                Button_Settings.BackgroundImage = Properties.Resources.LightSettings;

                for (int i = 0; i <= 24; i++) this.Controls["Button_PopularProducts_" + i].BackgroundImage = Properties.Resources.LightFrame;
                for (int i = 0; i <= 5; i++) this.Controls["Button_PopularService_" + i].BackgroundImage = Properties.Resources.LightFrame;
            }
        }

        private void CashRegister_FormClosed(object sender, FormClosedEventArgs e) => Application.OpenForms["Authorization"].Show();

        private void Button_Menu_Click(object sender, EventArgs e) => new NEWMenu().ShowDialog();

        private void Button_Discount_Click(object sender, EventArgs e) { }

        private void Button_Payment_Click(object sender, EventArgs e) => new PurchaseReceipt().ShowDialog();

        private void Button_Cancel_Click(object sender, EventArgs e) => new RemovalOperations().ShowDialog();

        private void Button_Settings_Click(object sender, EventArgs e) { new FSettings().ShowDialog(); StyleUpdate(); }

        private void Button_PopularProducts_Click(object sender, EventArgs e) { }

        private void Button_PopularService_Click(object sender, EventArgs e) { }

        private void Button_Close_Click(object sender, EventArgs e) => this.Close();
    }
}