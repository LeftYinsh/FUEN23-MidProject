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
    public partial class Func_MemberInfo : Form
    {
        public Func_MemberInfo()
        {
            InitializeComponent();
        }

        private void btn_ModifyInfo_Click(object sender, EventArgs e)
        {
            MainForm.Access.form_Work_MemberInfo.txtB_Password.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.rdB_Male.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.rdB_Female.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.rdB_Private.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.dTP_Birthday.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.txtB_Email.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.txtB_Phone.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.cbB_Address.Enabled = true;
            MainForm.Access.form_Work_MemberInfo.txtB_Address.Enabled = true;
            btn_ModifyInfo.Enabled = false;
            btn_ModifyConfirm.Enabled = true;
            btn_ModifyCancel.Enabled = true;
        }

        private void btn_ModifyCancel_Click(object sender, EventArgs e)
        {
            //recover value
            MainForm.Access.form_Work_MemberInfo.txtB_Password.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Male.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Female.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Private.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.dTP_Birthday.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Email.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Phone.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.cbB_Address.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Address.Enabled = false;
            btn_ModifyInfo.Enabled = true;
            btn_ModifyConfirm.Enabled = false;
            btn_ModifyCancel.Enabled = false;
        }

        private void btn_ModifyConfirm_Click(object sender, EventArgs e)
        {
            //update value
            MainForm.Access.form_Work_MemberInfo.txtB_Password.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Male.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Female.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.rdB_Private.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.dTP_Birthday.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Email.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Phone.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.cbB_Address.Enabled = false;
            MainForm.Access.form_Work_MemberInfo.txtB_Address.Enabled = false;
            btn_ModifyInfo.Enabled = true;
            btn_ModifyConfirm.Enabled = false;
            btn_ModifyCancel.Enabled = false;
            MessageBox.Show("會員資料修改成功！");
            //MessageBox.Show("會員資料修改失敗！請檢查是否輸入錯誤格式！");
        }
    }
}
