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
    public partial class EdgeForm : Form
    {

        private int maxNum;
        public Tuple<int, int> tuple;
        public EdgeForm(int maxNum)
        {
            InitializeComponent();
            this.maxNum = maxNum;
        }

        private void BtAct_Click(object sender, EventArgs e)
        {
            int first;
            int second;
            if (Int32.TryParse(tbFirst.Text, out first) && Int32.TryParse(tbSecond.Text, out second))
            {
                if (first != second && first >= 0 && second >= 0 && first <= maxNum && second <= maxNum)
                {
                    tuple = new Tuple<int, int>(first, second);
                    DialogResult = DialogResult.OK;
                    return;
                }
            }
            MessageBox.Show("Введеные некорректные данные!");
        }
    }
}
