using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestOpc
{
    public partial class MainForm : Form
    {
        OpcBridgeSupport opc;

        public MainForm()
        {
            InitializeComponent();
            opc = new OpcBridgeSupport();
        }

        private void MainForm_Load(object sender, System.EventArgs e)
        {
            // Инициализация
            opc.InitOPC();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            opc.FinitOPC();
        }

        private void btnRefresh_Click(object sender, System.EventArgs e)
        {
            var servers = opc.GetServers();
            var items = servers.Split(new[] { ';' },System.StringSplitOptions.RemoveEmptyEntries);
            var categories = new Dictionary<string, TreeNode>();
            TreeNode node;
            tvServers.Nodes.Clear();
            foreach (var item in items)
            {
                var vals = item.Split('=');
                if (vals.Length != 2) continue;
                if (categories.ContainsKey(vals[0]))
                    node = categories[vals[0]];
                else
                {
                    node = new TreeNode(vals[0]);
                    categories.Add(vals[0], node);
                    tvServers.Nodes.Add(node);
                }
                node.Nodes.Add(vals[1]);
            }
        }

        private void tvServers_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node == null) return;
            if (e.Node.Level == 0) return;
            tbServer.Text = e.Node.Text;
            tbGroup.Text = "Group1";
            tbTag.Text = "";
            lbServerItems.Items.Clear();
        }

        private void btnRefreshItems_Click(object sender, System.EventArgs e)
        {
            try
            {
                var items = opc.GetProps(tbServer.Text);
                var tags = items.Split(new[] { ';' }, System.StringSplitOptions.RemoveEmptyEntries);
                lbServerItems.Items.Clear();
                foreach (var tag in tags)
                {
                    lbServerItems.Items.Add(tag);
                    opc.AddItem(tbServer.Text, tbGroup.Text, tag.Split('=')[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbServerItems_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            tbTag.Text = ((string)lbServerItems.SelectedItem).Split('=')[0];
        }

        private void btnFetch_Click(object sender, System.EventArgs e)
        {
            var value = opc.FetchItem(tbServer.Text, tbGroup.Text, tbTag.Text);
            tbValue.Text = value;
        }
    }

}
