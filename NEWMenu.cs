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
    public partial class NEWMenu : Form
    {
        public NEWMenu() => InitializeComponent();

        private void NEWMenu_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            this.WindowState = FormWindowState.Maximized;
            FormSettings.DimensionalSettings(this, 1200, 650);
            StyleUpdate(); Catalog();
        }

        private void StyleUpdate()
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
        }

        private void Catalog()
        {
            Table.ColumnCount = Table.Width / 220; int Left = ((Table.Width - Table.ColumnCount * 220) / Table.ColumnCount);

            FillTable.Catalog_FirstStage(Table, (int)(Left / 2.6));
        }
    }

}
