using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualTask
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void Authorize_Load(object sender, EventArgs e)
        {
            txtLogin.Text = "Supervisor";
            txtPassword.Text = "Supervisor";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login = txtLogin.Text.Trim();
            var password = txtPassword.Text.Trim();

            using (DBEntities db = new DBEntities())
            {
                var user = db.User.Where(x => x.Login == login && x.Password == password).FirstOrDefault();
                if (user != null)
                {
                    var mainForm = new MainForm(this, user);
                    mainForm.Show();

                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Пользователь не найден. Обратитесь к администратору");
                }
            }
        }
    }
}
