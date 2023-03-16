using Lab009;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09A_210042149
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show($"Logged in as : {GlobalClass._userName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userLabel.Text = GlobalClass._userName;
        }
    }
}
