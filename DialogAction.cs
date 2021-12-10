using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab28
{
    public struct KeyOfDict
    {
        public string eng, ukr;
    }

    public partial class DialogAction : Form
    {
        public KeyOfDict keys;

        public DialogAction(string name, KeyOfDict start)
        {
            InitializeComponent();
            textBoxUA.Text = start.ukr;
            textBoxENG.Text = start.eng;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            keys.ukr = textBoxUA.Text;
            keys.eng = textBoxENG.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxUA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }
    }
}
