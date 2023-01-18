using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Font
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.Font = new Font(btnExit.Font.FontFamily, btnExit.Font.Size + 2, FontStyle.Bold);
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.Font = new Font(btnExit.Font.FontFamily, btnExit.Font.Size - 2, FontStyle.Regular);
        }
    }
}
