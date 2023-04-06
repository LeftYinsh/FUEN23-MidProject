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
    public partial class Menu_Manager : Form
    {
        public Menu_Manager()
        {
            InitializeComponent();
        }

        private void btn_ManagerInfo_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ManagerInfo);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_ManagerInfo);
        }

        private void btn_ProductsMaintain_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_ProductsMaintain);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_ProductsMaintain);
        }

        private void btn_OrderMaintain_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_OrderMaintain);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_OrderMaintain);
        }

        private void btn_MemberMaintain_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberMaintain);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_MemberMaintain);
        }

        private void btn_RevenueCalculate_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_RevenueCalculate);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_RevenueCalculate);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            MainForm.Access.OpenFormAtMenuArea(MainForm.Access.form_Menu_Login);
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }
    }
}
