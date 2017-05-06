using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdditionalForms
{
    public partial class StrucutureElemntChoose : Form
    {
        TextBox[,] DisplayedGrid;
        int Siz = 0;
        public StrucutureElemntChoose()
        {
            InitializeComponent();
        }

        private void DrawGridBTN_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            int GridSizeX = 500, GridSizeY = 250;
            int number = int.Parse(SideLentxtB.Text);
            Siz = number;

            DisplayedGrid = new TextBox[Siz, Siz];
            for (int i = 0; i < Siz; i++)
            {
                for (int j = 0; j < Siz; j++)
                {
                    DisplayedGrid[i, j] = new TextBox();
                    DisplayedGrid[i, j].Multiline = true;
                    DisplayedGrid[i, j].TextAlign = HorizontalAlignment.Center;
                    DisplayedGrid[i, j].Size = new Size(GridSizeX / Siz, GridSizeY / Siz);
                    DisplayedGrid[i, j].Location = new Point(j * (GridSizeX / Siz), i * (GridSizeY / Siz));
                    DisplayedGrid[i, j].Font = new Font(DisplayedGrid[i, j].Font.FontFamily, 16);

                    panel1.Controls.Add(DisplayedGrid[i, j]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
