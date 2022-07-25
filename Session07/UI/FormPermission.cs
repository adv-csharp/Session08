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

        private void FormPermission_Load(object sender, EventArgs e)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var forms = assembly.GetTypes().Where(x => x.BaseType == typeof(Form));
            foreach (var form in forms)
            {
                listBoxForms.Items.Add(form.FullName);
            }
        }

        private void listBoxForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControls.Items.Clear();
            var formName = listBoxForms.SelectedItem as string;
            var formType = Type.GetType(formName);
            using var form = Activator.CreateInstance(formType) as Form;
            foreach (var control in form.Controls)
            {
                if(control is Button)
                {
                    listBoxControls.Items.Add((control as Control).Name);
                }
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
