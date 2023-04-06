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
    public partial class Func_Login : Form
    {
        public Func_Login()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (MainForm.Access.form_ActiveWorkArea == MainForm.Access.form_Work_MemberLogin)
            {
                MainForm.Access.OpenFormAtMenuArea(MainForm.Access.form_Menu_Member);
                MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberInfo);
                MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_MemberInfo);
                MessageBox.Show("會員登入成功！");
            }
            else if(MainForm.Access.form_ActiveWorkArea == MainForm.Access.form_Work_ManagerLogin)
            {
                MainForm.Access.OpenFormAtMenuArea(MainForm.Access.form_Menu_Manager);
                MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ManagerInfo);
                MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_ManagerInfo);
                MessageBox.Show("管理員登入成功！");
            }
        }
    }
}
