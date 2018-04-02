using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void themTabPages(UserControl uct,byte typeControl,String tenTab)
        {
            //Kiểm Tra tồn tại
            for(int i=0;i<tabHienThi.TabPages.Count;i++)
            {
                if(tabHienThi.TabPages[i].Contains(uct)== true)
                {
                    tabHienThi.SelectedTab = tabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabHienThi.Size;
            tab.Text = tenTab;
            tabHienThi.TabPages.Add(tab);
            tabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }
        //đóng tab Hiện tại
        public void DonTabHienTai()
        {
            tabHienThi.TabPages.Remove(tabHienThi.SelectedTab);
        }
        // đóng all tab
        public void DongAllTab()
        {
            while(tabHienThi.TabPages.Count>0)
            {
                DonTabHienTai();
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
