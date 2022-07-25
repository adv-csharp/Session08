using Microsoft.EntityFrameworkCore;
using Session07.DataModel;
using Session07.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Session07.UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var repo = new Repository();
            var user = repo.AsQueryable<User>()
                   .Include(x => x.Role)
                   .FirstOrDefault(x => x.Username == textBoxUsername.Text);
            if(user != null)
            {
                var hash = Crypto.ToSHA512(textBoxPassword.Text + user.Salt);
                if(hash != user.Password)
                {
                    MessageBox.Show("Username or password is not correct");
                }
                else
                {
                    AppConfig.CurrentUser = user;
                    Hide();
                    var frm = new Form1();
                    frm.ShowDialog();
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Username or password is not correct");
            }
        }
    }
}
