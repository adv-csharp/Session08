using Session07.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Session07.UI
{
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }

        List<string> checkedButtons = new List<string>();
        Repository repo = new Repository();

        private void FormPermission_Load(object sender, EventArgs e)
        {
            comboBoxRoles.DisplayMember = "Name";
            comboBoxRoles.ValueMember = "Id";
            comboBoxRoles.DataSource = repo.AsQueryable<Role>().ToList();

            var assembly = Assembly.GetExecutingAssembly();
            var forms = assembly.GetTypes().Where(x => x.BaseType == typeof(Form));
            foreach (var form in forms)
            {
                listBoxForms.Items.Add(form.FullName);
            }
        }

        private void listBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedListBoxControls.Items.Clear();
            var formName = listBoxForms.SelectedItem as string;
            var formType = Type.GetType(formName);
            using var form = Activator.CreateInstance(formType) as Form;
            foreach (var control in form.Controls)
            {
                if (control is Button)
                {
                    var btn = control as Button;
                    checkedListBoxControls.Items.Add(
                        btn.Name,
                        checkedButtons.Contains(formName + "|" +  btn.Name)
                    );
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        { 
            var permisions = repo.AsQueryable<Permission>().ToList();
            var roleId = (int)comboBoxRoles.SelectedValue;

            ICollection<PermissionRole> permissionRoles = repo.
                    AsQueryable<Role>()
                    .Include(x => x.PermissionRoles)
                    .FirstOrDefault(x => x.Id == roleId)                    
                    .PermissionRoles;
            foreach (var PermissionRole in permissionRoles)
            {
                repo.Delete(PermissionRole);
            }


            foreach (var checkedButton in checkedButtons)
            {
                var parts = checkedButton.Split("|");
                var formName = parts[0];
                var buttonName = parts[1];

                if (buttonName == "")
                {
                    continue;
                }

                var permission = permisions.FirstOrDefault(x => x.FormName ==  formName && x.ButtonName == buttonName);
                if (permission == null)
                {
                    permission = new Permission { ButtonName = buttonName, FormName = formName };
                    repo.Add(permission);
                }

                repo.Add(new PermissionRole { Permission = permission, RoleId = roleId });
            }
            MessageBox.Show("Done");
        }

        private void checkedListBoxControls_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var formName = listBoxForms.SelectedItem as string;
            string key = formName + "|" + checkedListBoxControls.SelectedItem as string;
            if (e.NewValue == CheckState.Checked && !checkedButtons.Contains(key))
            {
                checkedButtons.Add(key);
            }
            if (e.NewValue == CheckState.Unchecked && checkedButtons.Contains(key))
            {
                checkedButtons.Remove(key);
            }
        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkedButtons.Clear();
            var permisions = repo.AsQueryable<Permission>().ToList();
            var roleId = (int)comboBoxRoles.SelectedValue;
            ICollection<PermissionRole> permissionRoles = repo.
                    AsQueryable<Role>()
                    .Include(x => x.PermissionRoles)                    
                    .FirstOrDefault(x => x.Id == roleId)
                    .PermissionRoles;
            foreach (var permissionRole in permissionRoles)
            {
                var p = permisions.FirstOrDefault(p => p.Id == permissionRole.PermissionId);
                checkedButtons.Add(p.FormName + "|" + p.ButtonName);
            }
        }
    }

    class XYZ
    {
        public List<int> numbers = new List<int>();
        public XYZ()
        {
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
        }
    }
}
