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
    public partial class ChipDeleteForm : Form
    {
        public int index;
        public ChipDeleteForm()
        {
            InitializeComponent();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            index = (int) numericUpDown1.Value;
            DialogResult = DialogResult.OK;
        }
    }
}
