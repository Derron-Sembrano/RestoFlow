using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private void ShowView(UserControl view)
        {
            foreach (Control c in contentPanel.Controls)
                c.Dispose();
            contentPanel.Controls.Clear();
            view.Dock = DockStyle.Fill;      
            contentPanel.Controls.Add(view);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(new DashBoardView());
            lblHeaderTitle.Text = "Dashboard";
            lbldesc.Text = "Here’s what’s happening at your restaurant today.";
        }
        private void btnPOS_Click(object sender, EventArgs e)
        {
            ShowView(new PosView());
            lblHeaderTitle.Text = "Point of Sale";
            lbldesc.Text = "Create and manage customer orders.";
        }

        private void btnMM_Click(object sender, EventArgs e)
        {
            ShowView(new MenuView());
            lblHeaderTitle.Text = "Menu Management";
            lbldesc.Text = "Manage dishes, pricing, and availability.";
        }

        private void btnTM_Click(object sender, EventArgs e)
        {
            ShowView(new TablesView());
            lblHeaderTitle.Text = "Table Management";
            lbldesc.Text = "Monitor dining areas and table status.";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowView(new InventoryView());
            lblHeaderTitle.Text = "inventory";
            lbldesc.Text = "Track ingredients and restocking needs.";
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowView(new TransactionsView());
            lblHeaderTitle.Text = "Transactions";
            lbldesc.Text = "Review all restaurant payment activity.";
        }

        private void btnSR_Click(object sender, EventArgs e)
        {
            ShowView(new ReportsView());
            lblHeaderTitle.Text = "Sales Report";
            lbldesc.Text = "Understand performance and sales trends.";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowView(new SettingsView());
            lblHeaderTitle.Text = "Settings";
            lbldesc.Text = "Configure your restaurant and team preferences.";
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            ShowView(new DashBoardView());
            lblHeaderTitle.Text = "Dashboard";
            lbldesc.Text = "Here’s what’s happening at your restaurant today.";
        }
    }
}
