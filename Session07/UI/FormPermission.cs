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

namespace Session07.UI
{
    public partial class FormPermission : Form
    {
        public FormPermission()
        {
            InitializeComponent();
        }

        List<string> checkedButtons = new List<string>();

        private void FormPermission_Load(object sender, EventArgs e)
        {
            var repo = new Repository();

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

        }

        private void checkedListBoxControls_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var formName = listBoxForms.SelectedItem as string;
            if (e.NewValue == CheckState.Checked)
            {
                checkedButtons.Add(formName + "|" + checkedListBoxControls.SelectedItem as string);
            }
            else
            {
                checkedButtons.Remove(formName + "|" + checkedListBoxControls.SelectedItem as string);
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
