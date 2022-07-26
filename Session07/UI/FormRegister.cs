﻿using Session07.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Session07.Utils;

namespace Session07.UI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validation
            //policy
            //
            var repo = new Repository();

            Role roleAdmin = new Role { Name = "admin" };
            repo.Add(roleAdmin);
            repo.Add(new Role { Name = "user" });
            repo.Add(new Role { Name = "author" });
            repo.Add(new Role { Name = "sales" });

            string salt = Guid.NewGuid().ToString();
            var user = new User
            {
                Username = textBoxUsername.Text,
                Password = Crypto.ToSHA512(textBoxPassword.Text + salt),
                Salt = salt,
                Role = roleAdmin
            };
            repo.Add(user);
            MessageBox.Show("Register Successfully");
        }
    }
}
