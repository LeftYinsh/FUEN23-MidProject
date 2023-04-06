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
    public partial class Menu_Member : Form
    {
        public Menu_Member()
        {
            InitializeComponent();
        }

        private void btn_MemberInfo_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberInfo);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_MemberInfo);
        }

        private void btn_ViewProducts_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ViewProducts);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_ViewProducts);
        }

        private void btn_ShoppingCart_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ShoppingCart);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_ShoppingCart);
        }

        private void btn_OrderStatus_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_OrderStatus);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_OrderStatus);
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtMenuArea(MainForm.Access.form_Menu_Login);
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }
    }
}
