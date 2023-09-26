using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cashier
{
    class FillTable
    {
        public static Label CatalogName;

        public static void Catalog_FirstStage(TableLayoutPanel Table, int Left)
        {
            Table.Controls.Clear(); Table.AutoScroll = true; Table.SuspendLayout();

            List<List<string>> Menu_Category = SQL.SELECT(Properties.Settings.Default.ServerSave, $"EXEC [Program110].[dbo].[Menu_Category];");

            for (int I0 = 0; I0 < 12; I0++) for (int I1 = 1; I1 < Menu_Category.Count; I1++)
                {
                    Table.Controls.Add(CreateProduct(Menu_Category[I1][0], Left));
                }

            Table.ResumeLayout(true);
        }

        static Panel CreateProduct(string Text, int Left)
        {
            Panel Frame = new Panel
            {
                Size = new System.Drawing.Size(220 + Left*2, 200),
                BackgroundImageLayout = ImageLayout.Stretch
            };

            Panel Product = new Panel
            {
                Size = new System.Drawing.Size(220, 190),
                BackgroundImageLayout = ImageLayout.Stretch,
                Left = Left,
                Top = 5
            };

            if (!Properties.Settings.Default.FormStyle) Product.BackgroundImage = Properties.Resources.DarkFrame;
            else Product.BackgroundImage = Properties.Resources.LightFrame;

            Product.Controls.Add(CreateProduct_Name(Text)); Frame.Controls.Add(Product); return Frame;
        }

        static Label CreateProduct_Name(string Text)
        {
            Label PName = new Label
            {
                Text = Text,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Times New Roman", 20),
                Size = new System.Drawing.Size(220, 190),
            };

            return PName;
        }
    }
}