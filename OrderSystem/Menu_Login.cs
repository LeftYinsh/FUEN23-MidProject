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
    public partial class Menu_Login : Form
    {
        public Menu_Login()
        {
            InitializeComponent();
        }

        private void btn_MemberLogin_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }

        private void btn_ManagerLogin_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ManagerLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }

        private void btn_MemberJoin_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberJoin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_MemberJoin);
        }
    }
}
