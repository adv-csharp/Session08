using Session07.UI;
using System.Reflection;

namespace Session07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenAllForms_Click(object sender, EventArgs e)
        {
            //var formLogin = new FormLogin();
            //formLogin.Show();
            //var formRegister = new FormRegister();
            //formLogin.Show();

            var assembly = Assembly.GetExecutingAssembly();
            var forms = assembly.GetTypes()
                    .Where(t => t.BaseType == typeof(Form))                    
                    .Where(t => t != this.GetType());
            foreach (var form in forms)
            {
                ((Form)Activator.CreateInstance(form)).Show();
            }
        }
    }
}