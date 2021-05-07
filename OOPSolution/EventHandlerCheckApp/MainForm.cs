using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

      

       

        private void loginbutton_Click(object sender, EventArgs e)
        {
            var result = TXTuserID.Text + "\n" + TXTuserpassword.Text;
            MessageBox.Show($"당신의 아이디와 패스워드는 {result}");
        }

      

        private void TXTuserpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Resize(object sender, EventArgs e)
        {

        }
    }
}
