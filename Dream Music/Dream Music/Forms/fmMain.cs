using Dream_Music.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dream_Music
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            fmSignIn SignIn = new fmSignIn();
            SignIn.Show();
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            fmSignUp SignUp = new fmSignUp();
            SignUp.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Предупреждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
    }
}
