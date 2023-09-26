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
    public partial class ProductSize : Form
    {
        public ProductSize() => InitializeComponent();

        public static string InterfaceElement { private get; set; }

        private List<List<string>> Data;

        private void ProductSize_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
            Choice();
        }

        private void Choice()
        {
            //Получение таблицы из Базы данных согласно хранимой процедуре
            Data = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Menu_PDetails_ID] @Index = N'{InterfaceElement}';");

            this.Height = 30 + 90 * (Data.Count + 1);

            //Очистка таблицы-вывод
            Table.BringToFront(); Table.Controls.Clear();

            Table.SuspendLayout(); Table.MouseWheel += new MouseEventHandler(this_MouseWheel);

            //Создание Panel с наименованием товара
            {
                Panel PName = new Panel { Size = new Size(Table.Width, 120), Margin = new Padding(0) };

                //Создание Label с наименованием товара
                {
                    Label lab = new Label()
                    {
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 22),
                        Text = Data[1][0],
                        Size = new Size(PName.Width, PName.Height)
                    };

                    PName.Controls.Add(lab);
                }

                Table.Controls.Add(PName);
            }

            for (int I1 = 1; I1 < Data.Count; I1++)
            {
                //Создание Panel с ценой и размером товара
                {
                    Panel Product = new Panel
                    {
                        Size = new Size(Table.Width, 90),
                        Margin = new Padding(0),
                        Name = Data[I1][2],
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    Product.Click += Product_Panel_Click;

                    //Создание Label с ценой и размером товара
                    {
                        Label lab = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Times New Roman", 20),
                            Text = Data[I1][2] + " / " + Data[I1][3] + " г / " + Data[I1][4] + " ₽",
                            Name = Data[I1][2],
                            Size = new Size(Product.Width, Product.Height)
                        };

                        lab.Click += Product_Label_Click; Product.Controls.Add(lab);
                    }

                    Table.Controls.Add(Product);
                }
            }

            //Создание Panel с отменой операции
            {
                Panel Сancel = new Panel { Size = new Size(Table.Width, 100), Margin = new Padding(0) };

                //Создание Label с отменой операции
                {
                    Label lab = new Label()
                    {
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new Font("Times New Roman", 20),
                        Text = "Отмена",
                        Size = new Size(Сancel.Width, Сancel.Height),
                        Name = "Сancel"
                    };

                    lab.Click += Product_Label_Click; Сancel.Controls.Add(lab);
                }

                Сancel.Click += Product_Panel_Click; Table.Controls.Add(Сancel);
            }

            Table.ResumeLayout(true);
        }

        //Выбор размера товара
        private void Product_Panel_Click(object sender, EventArgs e)
        {
            var PProduct = (Panel)sender; bool T = false;

            if (PProduct.Name == "Сancel") this.Close();
            else
            {
                for (int I1 = 1; I1 < CashRegister.PurchaseReceipt_Table.Count; I1++)
                {
                    if (CashRegister.PurchaseReceipt_Table[I1][0] == Data[1][1] & CashRegister.PurchaseReceipt_Table[I1][2] == PProduct.Name)
                    {
                        CashRegister.PurchaseReceipt_Table[I1][4] = (Convert.ToInt32(CashRegister.PurchaseReceipt_Table[I1][4]) + 1).ToString();
                        T = true; break;
                    }
                }

                if (T == false) for (int I1 = 1; I1 < Data.Count; I1++) if (Data[I1][2] == PProduct.Name)
                        { string[] Line = { Data[1][1], Data[1][0], PProduct.Name, Data[I1][4], "1" }; SQL.LocalDB(CashRegister.PurchaseReceipt_Table, Line); break; }

                this.Close();
            }
        }
        private void Product_Label_Click(object sender, EventArgs e)
        {
            var PProduct = (Label)sender; bool T = false;

            if (PProduct.Name == "Сancel") this.Close();
            else
            {
                for (int I1 = 1; I1 < CashRegister.PurchaseReceipt_Table.Count; I1++)
                {
                    if (CashRegister.PurchaseReceipt_Table[I1][0] == Data[1][1] & CashRegister.PurchaseReceipt_Table[I1][2] == PProduct.Name)
                    {
                        CashRegister.PurchaseReceipt_Table[I1][4] = (Convert.ToInt32(CashRegister.PurchaseReceipt_Table[I1][4]) + 1).ToString();
                        T = true; break;
                    }
                }

                if (T == false) for (int I1 = 1; I1 < Data.Count; I1++) if (Data[I1][2] == PProduct.Name)
                        { string[] Line = { Data[1][1], Data[1][0], PProduct.Name, Data[I1][4], "1" }; SQL.LocalDB(CashRegister.PurchaseReceipt_Table, Line); break; }

                this.Close();
            }
        }

        //Прогрузка данных при использовании Scroll
        private void Table_Scroll(object sender, ScrollEventArgs e) { Table.Refresh(); Table.Refresh(); }
        void this_MouseWheel(object sender, MouseEventArgs e) { Table.Refresh(); Table.Refresh(); }
    }
}