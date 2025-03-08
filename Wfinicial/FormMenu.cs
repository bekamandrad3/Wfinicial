using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wfinicial
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void btnex1_Click(object sender, EventArgs e)
        {
            FormEx1 form = new FormEx1();
            form.ShowDialog();
        }

        private void btnex2_Click(object sender, EventArgs e)
        {
            FormEx2 form = new FormEx2();
            form.ShowDialog();
        }

        private void btnex3_Click(object sender, EventArgs e)
        {
            FormEx3 form = new FormEx3();
            form.ShowDialog();
        }

        private void btnex4_Click(object sender, EventArgs e)
        {
            FormEx4 form = new FormEx4();
            form.ShowDialog();
        }

        private void btnex5_Click(object sender, EventArgs e)
        {
            FormEx5 form = new FormEx5();
            form.ShowDialog();
        }

        private void btnex6_Click(object sender, EventArgs e)
        {
            FormsEx6 form = new FormsEx6();
            form.ShowDialog();
        }

        private void btnex7_Click(object sender, EventArgs e)
        {
            FormEx7 form = new FormEx7();
            form.ShowDialog();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnEx8_Click(object sender, EventArgs e)
        {
            FormEx8 form = new FormEx8();
            form.ShowDialog();
        }
    }
}
