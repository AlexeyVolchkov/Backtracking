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
    public partial class ChipForm : Form
    {
        public int index;
        public bool isBlack;
        public ChipForm()
        {
            InitializeComponent();
            cbColor.SelectedIndex = 0;
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            index = (int) nudIndex.Value;
            isBlack = cbColor.SelectedIndex == 1;
            DialogResult = DialogResult.OK;
        }
    }
}
