using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class LoginMenuForm : Form
    {
        public LoginMenuForm()
        {
            InitializeComponent();
        }

        private void btn_MemberLogin_Click(object sender, EventArgs e)
        {
            GlobalResources.form_MainForm.OpenFormAtWorkArea(GlobalResources.form_MemberLoginForm);
            GlobalResources.form_MainForm.OpenFormAtFuncArea(GlobalResources.form_MemberLoginFuncForm);
        }

        private void btn_ManagerLogin_Click(object sender, EventArgs e)
        {
            GlobalResources.form_MainForm.OpenFormAtWorkArea(GlobalResources.form_ManagerLoginForm);
            GlobalResources.form_MainForm.OpenFormAtFuncArea(GlobalResources.form_ManagerLoginFuncForm);
        }
    }
}
