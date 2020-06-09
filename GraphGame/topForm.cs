using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphGame
{
    public partial class topForm : Form
    {
        public Point point;
        private int maxX;
        private int maxY;
        public topForm(int maxX, int maxY)
        {
            InitializeComponent();
            this.maxX = maxX;
            this.maxY = maxY;
        }

        private void BtAct_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            if (Int32.TryParse(tbX.Text, out x) && Int32.TryParse(tbY.Text, out y))
            {
                if (x > 0 && y > 0 && x < maxX && y < maxY)
                {
                    point.X = x;
                    point.Y = maxY - y;
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
            MessageBox.Show("Введены некорректные значения X и Y. Повторите ввод!", "Ошибка");
        }

        private void TbX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
