using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WFDemo02_KuangJia
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmi_PwdModify_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        #region 创建关闭窗体的方法:ClosePreForm
        //创建一个关闭窗体的方法(类的最小单位是方法)
        private void ClosePreForm()
        {
            //首先判断当前容器中是否已经存在窗体,如果有窗体则关闭该窗体
            foreach (Control item in this.splitContainer1.Panel2.Controls)
            {
                //判断item是否是窗体
                if (item is Form)
                {
                    Form objControl = (Form)item;
                    objControl.Close();
                }
            }
        }
        #endregion

        #region  创建将子窗体嵌入到主窗体中的方法:OpenForm
        private void OpenForm(Form objFrm)
        {
            //注意：此段代码的作用是将子窗体嵌入到主窗体中
            objFrm.TopLevel = false;   //将子窗体设置成非顶级控件
            objFrm.WindowState = FormWindowState.Maximized;  //去掉窗体的边框
            objFrm.FormBorderStyle = FormBorderStyle.None;  //去掉窗体的边框
            objFrm.Parent = this.splitContainer1.Panel2;   //指定子窗体显示的容器
            objFrm.Show();
        }
        #endregion

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClosePreForm();   //调用创建的ClosePreForm方法，关闭已经存在的窗体
            
            //FrmAddStudent objFrm = new FrmAddStudent();

            OpenForm(new FrmAddStudent());  //调用创建的OpenForm方法，打开窗口



        }

        private void btnStuManage_Click(object sender, EventArgs e)
        {
            ClosePreForm();

            OpenForm(new FrmUserLogin());
        }

        private void btnStuManage_Click_1(object sender, EventArgs e)
        {
            ClosePreForm();

            OpenForm(new FrmStudentManage());
        }
    }
}
