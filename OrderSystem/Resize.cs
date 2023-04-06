using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderSystem
{
    public partial class Resize : Form
    {
        #region Resize
        double db_FormWidth;
        double db_FormHeight;
        double db_ScaleX;
        double db_ScaleY;
        protected Dictionary<string, string> dicStrStr_ControlInfo = new Dictionary<string, string>();

        protected void GetAllInfo(Control ctrl_Container)
        {
            if (ctrl_Container.Parent == this)
            {
                db_FormWidth = Convert.ToDouble(ctrl_Container.Width);
                db_FormHeight = Convert.ToDouble(ctrl_Container.Height);
            }
            foreach (Control ctrl_Item in ctrl_Container.Controls)
            {
                if (ctrl_Item.Name.Trim() != "")
                {
                    dicStrStr_ControlInfo.Add(ctrl_Item.Name,
                                             (ctrl_Item.Left + ctrl_Item.Width / 2) + "," +
                                             (ctrl_Item.Top + ctrl_Item.Height / 2) + "," +
                                             ctrl_Item.Width + "," + ctrl_Item.Height + "," + ctrl_Item.Font.Size);
                }
                if ((ctrl_Item as UserControl) == null && ctrl_Item.Controls.Count > 0)
                {
                    GetAllInfo(ctrl_Item);
                }
            }
        }

        protected void ControlsChangeInit(Control ctrl_Container)
        {
            db_ScaleX = (Convert.ToDouble(ctrl_Container.Width) / db_FormWidth);
            db_ScaleY = (Convert.ToDouble(ctrl_Container.Height) / db_FormHeight);
        }

        protected void ControlsChange(Control ctrl_Container)
        {
            double[] dbArr_pos = new double[5];
            foreach (Control ctrl_Item in ctrl_Container.Controls)
            {
                if (ctrl_Item.Name.Trim() != "")
                {
                    if ((ctrl_Item as UserControl) == null && ctrl_Item.Controls.Count > 0)
                    {
                        ControlsChange(ctrl_Item);
                    }
                    string[] strArr_Strs = dicStrStr_ControlInfo[ctrl_Item.Name].Split(',');
                    for (int i = 0; i < 5; i++)
                    {
                        dbArr_pos[i] = Convert.ToDouble(strArr_Strs[i]);
                    }
                    double db_ItemWidth = dbArr_pos[2] * db_ScaleX;
                    double db_ItemHeight = dbArr_pos[3] * db_ScaleY;
                    ctrl_Item.Left = Convert.ToInt32(dbArr_pos[0] * db_ScaleX - db_ItemWidth / 2);
                    ctrl_Item.Top = Convert.ToInt32(dbArr_pos[1] * db_ScaleY - db_ItemHeight / 2);
                    ctrl_Item.Width = Convert.ToInt32(db_ItemWidth);
                    ctrl_Item.Height = Convert.ToInt32(db_ItemHeight);
                    ctrl_Item.Font = new Font(ctrl_Item.Font.Name,
                                              float.Parse((dbArr_pos[4] * Math.Min(db_ScaleX, db_ScaleY)).ToString()), 
                                              ctrl_Item.Font.Style);
                }
            }
        }
        #endregion
        /*
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            if(dicStrStr_ControlInfo.Count > 0)
            {
                ControlsChangeInit(this.Controls[0]);
                ControlsChange(this.Controls[0]);
            }
        }
        public FormName()
        {
            InitializeComponent();
            GetAllInfo(this.Controls[0]);
        }
        */
    }
}
