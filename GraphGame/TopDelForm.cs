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
    public partial class TopDelForm : Form
    {
        public int num;
        private int maxNum;
        public TopDelForm(int maxNum)
        {
            InitializeComponent();
            this.maxNum = maxNum;
        }

        private void BtDel_Click(object sender, EventArgs e)
        {
            if (!(Int32.TryParse(tbNum.Text, out num) && num >= 0 && num <= maxNum))
            {
                MessageBox.Show("Вы ввели некорректные данные");
                return;
            }
            DialogResult = DialogResult.OK;
        }
    }
}
