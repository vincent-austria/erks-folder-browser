using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace folder_browser
{
    public partial class Form1 : Form
    {
        static readonly HttpClient client = new HttpClient();
        static ListViewItem[] ITEMS = new ListViewItem[1000];

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode root = new TreeNode("root");
            root.Name = "root";
            treeView1.Nodes.Add(root);
            AddDummyNode(root);
            // await client.GetStringAsync("https://localhost:8081/folder/root");
            CboStyle.SelectedIndex = 1;
            listView1.SmallImageList = imlSmallIcons;
            listView1.LargeImageList = imlLargeIcons;
            ListViewItem rcs = new ListViewItem("root", 0);
            listView1.Items.Add(rcs);

            for (int i = 0; i < ITEMS.Length; i++)
            {
                ITEMS[i] = new ListViewItem("Folder #" + i, 0);
            }
        }
        private void AddDummyNode(TreeNode node)
        {
            TreeNode dummy = new TreeNode();
            node.Nodes.Add(dummy);
        }

        async private void TreeView1_AfterExpand(object sender, TreeViewEventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            await AddChildNodes(e.Node);

            stopWatch.Stop();
            textBox1.AppendText("Expanding node '" + e.Node.Name + "' (" + e.Node.Nodes.Count + " items): " + stopWatch.Elapsed.TotalMilliseconds + "ms\r\n");
        }
        async private Task AddChildNodes(TreeNode node)
        {
            while (node.FirstNode != null)
            {
                node.Nodes.Remove(node.FirstNode);
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            String data = await client.GetStringAsync("http://localhost:8081/folder/" + node.Name);
            stopWatch.Stop();
            textBox1.AppendText("Network: " + stopWatch.Elapsed.TotalMilliseconds + "ms; ");

            String[] entries = data.Split('\n');
            foreach (var entry in entries)
            {
                if (entry.Contains(":"))
                {
                    String[] split = entry.Split(':');
                    TreeNode newNode = new TreeNode(split[1]);
                    newNode.Name = split[0];
                    AddDummyNode(newNode);
                    node.Nodes.Add(newNode);
                }
            }
        }
        private void CboStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CboStyle.Text)
            {
                case "Large Icons":
                    listView1.View = View.LargeIcon;
                    break;
                case "Small Icons":
                    listView1.View = View.SmallIcon;
                    break;
                case "List":
                    listView1.View = View.List;
                    break;
                case "Tile":
                    listView1.View = View.Tile;
                    break;
                case "Details":
                    listView1.View = View.Details;
                    break;
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            listView1.Items.Clear();
            int itemCount = int.TryParse(textItemCount.Text, out itemCount) ? itemCount : 20;
            for (int i = 0; i < itemCount; i++)
            {
                // ListViewItem newListItem = new ListViewItem("Folder #" + (i + 1), 0);
                ListViewItem newListItem = ITEMS[i];
                listView1.Items.Add(newListItem);
            }

            stopWatch.Stop();
            textBox1.AppendText("Listing (Type="
                + CboStyle.Text
                + "; ItemCount="
                + itemCount
                + "; ShowIcons="
                + checkboxToggleIcon.Checked
                + "): "
                + stopWatch.Elapsed.TotalMilliseconds
                + "ms\r\n");
        }

        private void checkboxToggleIcon_CheckedChanged(object sender, EventArgs e)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            listView1.SmallImageList = checkboxToggleIcon.Checked ? imlSmallIcons : null;
            listView1.LargeImageList = checkboxToggleIcon.Checked ? imlLargeIcons : null;
            stopWatch.Stop();
            textBox1.AppendText("Toggle icons: "
                + stopWatch.Elapsed.TotalMilliseconds
                + "ms\r\n");
        }
    }
}
