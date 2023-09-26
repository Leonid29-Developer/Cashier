using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cashier
{
    internal class FormSettings
    {
        /// <summary>
        /// Kod #1 - NoColorStyle
        /// Kod #2 - NotChangeSize
        /// Kod #3 - NoColorStyle and NotChangeSize
        /// </summary>

        //Стиль для различных элементов управления
        public static void StyleSetting(bool LightOrDark, Form FName)
        {
            FName.SuspendLayout();

            if (!LightOrDark)
            {
                FName.BackgroundImage = Properties.Resources.LightFormBackground;
                FName.BackColor = Color.White; FName.ForeColor = Color.Black;

                //Button на Form
                foreach (var A in FName.Controls.OfType<Button>().ToList())
                { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) A.BackColor = Color.White; A.ForeColor = Color.Black; }

                //Button на Panel
                foreach (var A in FName.Controls.OfType<Panel>().ToList())
                {
                    foreach (var B in A.Controls.OfType<Button>().ToList())
                    { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) B.BackColor = Color.White; B.ForeColor = Color.Black; }

                    foreach (var B in A.Controls.OfType<TrackBar>().ToList())
                    { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) B.BackColor = Color.White; B.ForeColor = Color.Black; }
                }
            }
            else
            {
                FName.BackgroundImage = Properties.Resources.DarkFormBackground;
                FName.BackColor = SystemColors.WindowFrame; FName.ForeColor = Color.White;

                //Button на Form
                foreach (var A in FName.Controls.OfType<Button>().ToList())
                { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) A.BackColor = SystemColors.ControlDarkDark; A.ForeColor = Color.White; }

                //Button на Panel
                foreach (var A in FName.Controls.OfType<Panel>().ToList())
                {
                    foreach (var B in A.Controls.OfType<Button>().ToList())
                    { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) B.BackColor = SystemColors.WindowFrame; B.ForeColor = Color.White; }

                    foreach (var B in A.Controls.OfType<TrackBar>().ToList())
                    { if (!((string)A.Tag == "Kod1" | (string)A.Tag == "Kod3")) B.BackColor = SystemColors.WindowFrame; B.ForeColor = Color.White; }
                }
            }

            FName.ResumeLayout(true);
        }

        //Размеры и расположение элементов управления на форме
        public static void DimensionalSettings(Form FName, int Width, int Height)
        {
            FName.SuspendLayout();

            //Расположение
            {
                //Button на Form
                foreach (var A in FName.Controls.OfType<Button>().ToList())
                {
                    double X = (double)Width / (double)A.Location.X, Y = (double)Height / (double)A.Location.Y;
                    A.Location = new Point((int)((double)FName.Width / X), (int)((double)FName.Height / Y));
                }
            }

            //Размер
            {
                //Button на Form
                foreach (var A in FName.Controls.OfType<Button>().ToList())
                {
                    if (A.Size.Width == A.Size.Height | ((string)A.Tag == "Kod2" | (string)A.Tag == "Kod3"))
                    {
                        double X = (double)Width / (double)A.Width * 1.3;
                        A.Size = new Size((int)((double)FName.Width / X), (int)((double)FName.Width / X));
                    }
                    else
                    {
                        double X = (double)Width / (double)A.Width * 1.2, Y = (double)Height / (double)A.Height * 1.2;
                        A.Size = new Size((int)((double)FName.Width / X), (int)((double)FName.Height / Y));
                    }
                }
            }

            FName.ResumeLayout(true);
        }
    }
}