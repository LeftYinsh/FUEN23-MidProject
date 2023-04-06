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
    public partial class Func_MemberJoin : Form
    {
        public Func_MemberJoin()
        {
            InitializeComponent();
        }

        private void btn_Join_Click(object sender, EventArgs e)
        {
            MessageBox.Show("註冊會員成功，切換至會員登入頁面！");
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }
    }
}
