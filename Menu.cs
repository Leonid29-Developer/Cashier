using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cashier
{
    public partial class Menu : Form
    {
        public Menu() => InitializeComponent();

        private bool DisplayingPhoto = true;    

        private void Menu_Load(object sender, EventArgs e)
        {
            //Установка параметров формы
            this.WindowState = FormWindowState.Maximized;
            FormSettings.DimensionalSettings(this, 1200, 650);
            StyleUpdate(); Catalog_FirstStage();
            Button_Close.BringToFront();
        }

        private void StyleUpdate()
        {
            //Установка параметров формы
            FormSettings.StyleSetting(Properties.Settings.Default.FormStyle, this);
        }

        private void Catalog_FirstStage()
        {
            //Очистка таблицы-вывод
            Table.BringToFront(); Table.Controls.Clear(); Table.AutoScroll = false; Table.HorizontalScroll.Enabled = false; Table.AutoScroll = true;

            Table.SuspendLayout(); Table.MouseWheel += new MouseEventHandler(this_MouseWheel);

            //Получение таблицы из Базы данных согласно хранимой процедуре
            List<List<string>> Menu_Category = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Menu_Category];");

            for (int I1 = 1; I1 < Menu_Category.Count; I1++)
            {
                //Создание Panel
                {
                    Panel Category = new Panel { Size = new Size(Table.Width - 20, 100), Margin = new Padding(0) };

                    //Создание Label с наименованием категории каталога
                    {
                        Label lab = new Label()
                        {
                            TextAlign = ContentAlignment.MiddleCenter,
                            Font = new Font("Times New Roman", 24, FontStyle.Underline),
                            Text = Menu_Category[I1][0],
                            Top = 0,
                            Left = 10,
                            Size = new Size(Category.Width, Category.Height)
                        };

                        Category.Controls.Add(lab);
                    }

                    Table.Controls.Add(Category);
                }

                //Получение таблицы из Базы данных согласно хранимой процедуре
                List<List<string>> Menu_Subdirectory = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Menu_Subdirectory] @Category = N'{Menu_Category[I1][0]}';");

                for (int I2 = 1; I2 < Menu_Subdirectory.Count; I2++)
                {
                    int Left_Start = (int)((double)Table.Width * 0.25);

                    //Создание Panel
                    {
                        Panel Subdirectory = new Panel
                        {
                            Size = new Size(Table.Width - 20, 100),
                            Margin = new Padding(0)
                        };

                        //Создание Label с наименованием подкатегории каталога
                        {
                            string Border = ""; while (Border.Length < (100 - Menu_Subdirectory[I2][0].Length)) Border += ".";

                            Label lab = new Label()
                            {
                                TextAlign = ContentAlignment.MiddleLeft,
                                Font = new Font("Times New Roman", 22),
                                Text = Menu_Subdirectory[I2][0] + Border,
                                Top = 0,
                                Left = Left_Start,
                                Size = new Size(Subdirectory.Width, Subdirectory.Height)
                            };

                            Subdirectory.Controls.Add(lab);
                        }

                        Table.Controls.Add(Subdirectory);
                    }

                    //Получение таблицы из Базы данных согласно хранимой процедуре
                    List<List<string>> Menu_Name = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Menu_ID] @Category = N'{Menu_Category[I1][0]}', @SubD = N'{Menu_Subdirectory[I2][0]}';");

                    for (int I3 = 1; I3 < Menu_Name.Count; I3++)
                    {
                        //Создание Panel
                        {
                            Panel Product = new Panel
                            {
                                Size = new Size(Table.Width - 20, 220),
                                Margin = new Padding(0),
                                Name = Menu_Name[I3][0]
                            };

                            Product.Click += Product_Panel_Click;

                            //Создание Picturebox c фотографией товара
                            if (DisplayingPhoto)
                            {
                                PictureBox Photo = new PictureBox { Size = new Size(200, 200), SizeMode = PictureBoxSizeMode.StretchImage, Top = 10, Left = Left_Start + 30 };
                                Photo.BorderStyle = BorderStyle.FixedSingle; Photo.Name = Menu_Name[I3][0]; Photo.Click += Product_PictureBox_Click;

                                if (File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product Photo/" + Menu_Name[I3][0] + ".png"))) Photo.ImageLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Product Photo/" + Menu_Name[I3][0] + ".png");
                                else Photo.Image = Properties.Resources.MissingPhoto;

                                Product.Controls.Add(Photo);
                            }

                            //Создание Label с наименованием товара
                            {
                                Label lab = new Label()
                                {
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    Font = new Font("Times New Roman", 20),
                                    Text = Menu_Name[I3][1],
                                    Top = 10,
                                    Left = Left_Start + 240,
                                    Size = new Size(Product.Width - 200, 80),
                                    Name = Menu_Name[I3][0]
                                };

                                lab.Click += Product_Label_Click; Product.Controls.Add(lab);
                            }

                            //Создание Label с ценой и размером товара
                            {
                                //Получение таблицы из Базы данных согласно хранимой процедуре
                                List<List<string>> PDetails = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[PDetails_ALL] @Index = N'{Menu_Name[I3][0]}';");

                                TableLayoutPanel TablePrice = new TableLayoutPanel
                                {
                                    ColumnCount = 1,
                                    Top = 90,
                                    Left = Left_Start + 250,
                                    ClientSize = new Size(600, 120),
                                    Name = Menu_Name[I3][0]
                                };

                                if (PDetails.Count > 3) TablePrice.ColumnCount = 2; TablePrice.RowCount = 3;
                                TablePrice.GrowStyle = TableLayoutPanelGrowStyle.FixedSize; TablePrice.Click += Product_TableLayoutPanel_Click;

                                for (int I4 = 1; I4 < PDetails.Count; I4++)
                                {
                                    Label lab = new Label()
                                    {
                                        TextAlign = ContentAlignment.MiddleLeft,
                                        Font = new Font("Times New Roman", 18),
                                        Text = PDetails[I4][1] + " / " + PDetails[I4][2] + " г / " + PDetails[I4][3] + " ₽",
                                        Top = 90 + (I4 - 1) * 40,
                                        Left = Left_Start + 250,
                                        Size = new Size(TablePrice.Width / 2, 40),
                                        Name = Menu_Name[I3][0]
                                    };

                                    lab.Click += Product_Label_Click; TablePrice.Controls.Add(lab);
                                }

                                Product.Controls.Add(TablePrice);
                            }

                            Table.Controls.Add(Product);
                        }
                    }
                }
            }

            Table.ResumeLayout(true);
        }

        //Выбор размера товара
        private void Product_Panel_Click(object sender, EventArgs e)
        { var PProduct = (Panel)sender; ProductSize.InterfaceElement = PProduct.Name; new ProductSize().ShowDialog(); }
        private void Product_Label_Click(object sender, EventArgs e)
        { var PProduct = (Label)sender; ProductSize.InterfaceElement = PProduct.Name; new ProductSize().ShowDialog(); }
        private void Product_PictureBox_Click(object sender, EventArgs e)
        { var PProduct = (PictureBox)sender; ProductSize.InterfaceElement = PProduct.Name; new ProductSize().ShowDialog(); }
        private void Product_TableLayoutPanel_Click(object sender, EventArgs e)
        { var PProduct = (TableLayoutPanel)sender; ProductSize.InterfaceElement = PProduct.Name; new ProductSize().ShowDialog(); }

        private void Button_Close_Click(object sender, EventArgs e) => this.Close();

        //Прогрузка данных при использовании Scroll
        private void Table_Scroll(object sender, ScrollEventArgs e) { Table.Refresh(); Table.Refresh(); }
        void this_MouseWheel(object sender, MouseEventArgs e) { Table.Refresh(); Table.Refresh(); }
    }
}