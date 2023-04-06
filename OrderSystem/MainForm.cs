using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static MainForm Access = null;

        public Form form_ActiveWorkArea = null;
        public Form form_ActiveMenuArea = null;
        public Form form_ActiveFuncArea = null;

        public Menu_Login form_Menu_Login = null;
        public Func_Login form_Func_Login = null;
        public Work_MemberLogin form_Work_MemberLogin = null;
        public Work_ManagerLogin form_Work_ManagerLogin = null;
        public Work_MemberJoin form_Work_MemberJoin = null;
        public Func_MemberJoin form_Func_MemberJoin = null;

        public Menu_Member form_Menu_Member = null;       
        
        public Work_MemberInfo form_Work_MemberInfo = null;
        public Func_MemberInfo form_Func_MemberInfo = null;
        public Work_ViewProducts form_Work_ViewProducts = null;
        public Func_ViewProducts form_Func_ViewProducts = null;
        public Work_ShoppingCart form_Work_ShoppingCart = null;
        public Func_ShoppingCart form_Func_ShoppingCart = null;
        public Work_OrderStatus form_Work_OrderStatus = null;
        public Func_OrderStatus form_Func_OrderStatus = null;

        public Menu_Manager form_Menu_Manager = null;

        public Work_ManagerInfo form_Work_ManagerInfo = null;
        public Func_ManagerInfo form_Func_ManagerInfo = null;
        public Work_ProductsMaintain form_Work_ProductsMaintain = null;
        public Func_ProductsMaintain form_Func_ProductsMaintain = null;
        public Work_OrderMaintain form_Work_OrderMaintain = null;
        public Func_OrderMaintain form_Func_OrderMaintain = null;
        public Work_MemberMaintain form_Work_MemberMaintain = null;
        public Func_MemberMaintain form_Func_MemberMaintain = null;
        public Work_RevenueCalculate form_Work_RevenueCalculate = null;
        public Func_RevenueCalculate form_Func_RevenueCalculate = null;

        public void OpenFormAtWorkArea(Form form_OpenForm)
        {
            form_ActiveWorkArea = form_OpenForm;
            panel_WorkArea.Tag = form_OpenForm;
            form_OpenForm.BringToFront();
            form_OpenForm.Show();
        }
        public void OpenFormAtMenuArea(Form form_OpenForm)
        {
            form_ActiveMenuArea = form_OpenForm;
            panel_MenuArea.Tag = form_OpenForm;
            form_OpenForm.BringToFront();
            form_OpenForm.Show();
        }
        public void OpenFormAtFuncArea(Form form_OpenForm)
        {
            form_ActiveFuncArea = form_OpenForm;
            panel_FuncArea.Tag = form_OpenForm;
            form_OpenForm.BringToFront();
            form_OpenForm.Show();
        }

        private void InitialWorkArea(Form form)
        {
            form.TopLevel = false;
            panel_WorkArea.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Hide();
        }
        private void InitialMenuArea(Form form)
        {
            form.TopLevel = false;
            panel_MenuArea.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Hide();
        }
        private void InitialFuncArea(Form form)
        {
            form.TopLevel = false;
            panel_FuncArea.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Hide();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Access = this;
            form_Menu_Login = new Menu_Login();
            InitialMenuArea(form_Menu_Login);
            form_Work_MemberLogin = new Work_MemberLogin();
            InitialWorkArea(form_Work_MemberLogin);
            form_Func_Login = new Func_Login();
            InitialFuncArea(form_Func_Login);
            form_Work_MemberJoin = new Work_MemberJoin();
            InitialWorkArea(form_Work_MemberJoin);
            form_Func_MemberJoin = new Func_MemberJoin();
            InitialFuncArea(form_Func_MemberJoin);
            form_Work_ManagerLogin = new Work_ManagerLogin();
            InitialWorkArea(form_Work_ManagerLogin);
            form_Menu_Member = new Menu_Member();
            InitialMenuArea(form_Menu_Member);
            form_Work_MemberInfo = new Work_MemberInfo();
            InitialWorkArea(form_Work_MemberInfo);
            form_Func_MemberInfo = new Func_MemberInfo();
            InitialFuncArea(form_Func_MemberInfo);
            form_Work_ViewProducts = new Work_ViewProducts();
            InitialWorkArea(form_Work_ViewProducts);
            form_Func_ViewProducts = new Func_ViewProducts();
            InitialFuncArea(form_Func_ViewProducts);
            form_Work_ShoppingCart = new Work_ShoppingCart();
            InitialWorkArea(form_Work_ShoppingCart);
            form_Func_ShoppingCart = new Func_ShoppingCart();
            InitialFuncArea(form_Func_ShoppingCart);
            form_Work_OrderStatus = new Work_OrderStatus();
            InitialWorkArea(form_Work_OrderStatus);
            form_Func_OrderStatus= new Func_OrderStatus();
            InitialFuncArea(form_Func_OrderStatus);
            form_Menu_Manager = new Menu_Manager();
            InitialMenuArea(form_Menu_Manager);
            form_Work_ManagerInfo = new Work_ManagerInfo();
            InitialWorkArea(form_Work_ManagerInfo);
            form_Func_ManagerInfo = new Func_ManagerInfo();
            InitialFuncArea(form_Func_ManagerInfo);
            form_Work_ProductsMaintain = new Work_ProductsMaintain();
            InitialWorkArea(form_Work_ProductsMaintain);
            form_Func_ProductsMaintain = new Func_ProductsMaintain();
            InitialFuncArea(form_Func_ProductsMaintain);
            form_Work_OrderMaintain = new Work_OrderMaintain();
            InitialWorkArea(form_Work_OrderMaintain);
            form_Func_OrderMaintain = new Func_OrderMaintain();
            InitialFuncArea(form_Func_OrderMaintain);
            form_Work_MemberMaintain = new Work_MemberMaintain();
            InitialWorkArea(form_Work_MemberMaintain);
            form_Func_MemberMaintain = new Func_MemberMaintain();
            InitialFuncArea(form_Func_MemberMaintain);
            form_Work_RevenueCalculate = new Work_RevenueCalculate();
            InitialWorkArea(form_Work_RevenueCalculate);
            form_Func_RevenueCalculate = new Func_RevenueCalculate();
            InitialFuncArea(form_Func_RevenueCalculate);

            OpenFormAtMenuArea(form_Menu_Login);
        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
