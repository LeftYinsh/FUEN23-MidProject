using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public class GlobalResources
    { 
        private static void temp()
        {
            MainForm.Access.OpenFormAtMenuArea(MainForm.Access.form_Menu_Login);
            MainForm.Access.OpenFormAtWorkArea(MainForm.Access.form_Work_MemberLogin);
            MainForm.Access.OpenFormAtFuncArea(MainForm.Access.form_Func_Login);
        }
    }
}
