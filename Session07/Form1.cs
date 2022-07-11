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

        private void buttonReflection2_Click(object sender, EventArgs e)
        {
            var c = new City { Id = 1, Name = "Tehran", Population = 8000000 };
            var p = new Product { Shenase = 1, Name = "Monitor", ImageUrl = "nadarim", Price = 54154546 };


            MessageBox.Show(serialize(c)); // "Id:1💎Name:Tehran💎Population:8000000"
            MessageBox.Show(serialize(p)); // "Shenase:1💎Name:Monitor💎ImageUrl:nadarim💎Price:54154546"
        }

        private string serialize(object input)
        {
            var type = input.GetType();
            var list = new List<String>();
            foreach (var prop in type.GetProperties())
            {
                list.Add(prop.Name + ":" + prop.GetValue(input));
            }
            return String.Join("💎", list);
        }
    }

    class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }

    class Product
    {
        public int Shenase { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int Price { get; set; }
    }
}