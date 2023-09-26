using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cashier
{
    public partial class RemovalOperations : Form
    {
        public RemovalOperations() => InitializeComponent();

        private void Removal_ProductOROperation_Load(object sender, EventArgs e)
        {
            this.Location = new Point((System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size.Width / 3), 0);

            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
            Enumeration();
        }

        private void Enumeration()
        {
            this.Height = 310;

            //Очистка таблицы-вывод
            Table.BringToFront(); Table.Controls.Clear(); Table.AutoScroll = false; Table.HorizontalScroll.Enabled = false; Table.AutoScroll = true;
            Table.SuspendLayout(); Table.MouseWheel += new MouseEventHandler(this_MouseWheel);

            //Заполнение данных
            {
                //Создание Panel - Оглавление
                {
                    Panel PName = new Panel { Size = new Size(Table.Width, 100), Margin = new Padding(0) };

                    //Создание Label с текстом "Отмена операций"
                    {
                        Label lab = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Times New Roman", 22),
                            Text = "Отмена операций",
                            Size = new Size(PName.Width, PName.Height),
                            BorderStyle = BorderStyle.FixedSingle
                        };

                        PName.Controls.Add(lab);
                    }

                    Table.Controls.Add(PName);
                }

                //Создание Panel - Очистка
                {
                    Panel PName = new Panel { Size = new Size(Table.Width, 120), Margin = new Padding(0), BorderStyle = BorderStyle.FixedSingle };

                    //Создание Label с текстом "Очистить список операций"
                    {
                        double All_Price = 0;

                        for (int I1 = 1; I1 < CashRegister.PurchaseReceipt_Table.Count; I1++) All_Price += Convert.ToDouble(CashRegister.PurchaseReceipt_Table[I1][4]) * Convert.ToDouble(CashRegister.PurchaseReceipt_Table[I1][3]);

                        Label lab = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Times New Roman", 20),
                            Text = "Очистить список операций",
                            Name = "Clear",
                            Size = new Size(PName.Width, PName.Height)
                        };

                        lab.Click += Clear_Click; PName.Controls.Add(lab);
                    }

                    PName.Click += Clear_Click; Table.Controls.Add(PName);
                }

                //Создание Panel - Закрыть
                {
                    Panel Close = new Panel { Size = new Size(Table.Width, 84), Margin = new Padding(0), BorderStyle = BorderStyle.FixedSingle };

                    //Создание Label с текстом "Закрыть"
                    {
                        Label lab = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Times New Roman", 20),
                            Text = "Закрыть",
                            Name = "Close",
                            Size = new Size(Close.Width, Close.Height)
                        };

                        lab.Click += FormClose_Click; Close.Controls.Add(lab);
                    }

                    Close.Click += FormClose_Click; Table.Controls.Add(Close);
                }
            }

            Table.ResumeLayout(true);
        }

        //Очистка данных
        private void Clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Уверены, что хотите очистить все операции?", "Подтверждение", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CashRegister.PurchaseReceipt_Table.Clear();
                string[] Tab = { "Index", "Name", "Size", "Price", "Quantity" }; CashRegister.PurchaseReceipt_Table = SQL.LocalDB(Tab);
            }
        }

        //Прогрузка данных при использовании Scroll
        private void Table_Scroll(object sender, ScrollEventArgs e) { Table.Refresh(); Table.Refresh(); }
        void this_MouseWheel(object sender, MouseEventArgs e) { Table.Refresh(); Table.Refresh(); }

        //Закрытие формы
        private void FormClose_Click(object sender, EventArgs e) => this.Close();
    }
}