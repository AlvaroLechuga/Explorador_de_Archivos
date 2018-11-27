using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ExploradordeArchivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }
        private void PopulateTreeView()
        {
            TreeNode rootNode;
            DirectoryInfo info = new DirectoryInfo(@"../..");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                treeView1.Nodes.Add(rootNode);
            }
        }
        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "Folder";
                subSubDirs = subDir.GetDirectories();
                if (subSubDirs.Length != 0)
                {
                    GetDirectories(subSubDirs, aNode);
                }
                nodeToAddTo.Nodes.Add(aNode);
            }
        }

		private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			TreeNode newSelected = e.Node;
			listView1.Items.Clear();
			DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
			ListViewItem.ListViewSubItem[] subItems;
			ListViewItem item = null;
			foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
			{
				if(listView1.View == View.LargeIcon)
				{
					item = new ListViewItem(dir.Name, 2);
					subItems = new ListViewItem.ListViewSubItem[]
					{new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
				else
				{
					item = new ListViewItem(dir.Name, 0);
					subItems = new ListViewItem.ListViewSubItem[]
					{new ListViewItem.ListViewSubItem(item, "Directorio"),new ListViewItem.ListViewSubItem(item,dir.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}

				
			}
			foreach (FileInfo file in nodeDirInfo.GetFiles())
			{
				if (listView1.View == View.LargeIcon)
				{
					switch (file.Extension)
					{
						case ".pdf":
							item = new ListViewItem(file.Name, 4);
							break;
						case ".odt":
							item = new ListViewItem(file.Name, 6);
							break;
						case ".doc":
							item = new ListViewItem(file.Name, 6);
							break;
						case ".xls":
							item = new ListViewItem(file.Name, 9);
							break;
						case ".java":
							item = new ListViewItem(file.Name, 11);
							break;
						case ".php":
							item = new ListViewItem(file.Name, 13);
							break;
						case ".xml":
							item = new ListViewItem(file.Name, 15);
							break;
						case ".html":
							item = new ListViewItem(file.Name, 19);
							break;
						case ".css":
							item = new ListViewItem(file.Name, 17);
							break;
						default:
							item = new ListViewItem(file.Name, 7);
							break;

					}
					subItems = new ListViewItem.ListViewSubItem[]
					{ new ListViewItem.ListViewSubItem(item, "Fichero"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
				else
				{
					switch (file.Extension)
					{
						case ".pdf":
							item = new ListViewItem(file.Name, 3);
							break;
						case ".odt":
							item = new ListViewItem(file.Name, 5);
							break;
						case ".doc":
							item = new ListViewItem(file.Name, 5);
							break;
						case ".xls":
							item = new ListViewItem(file.Name, 8);
							break;
						case ".java":
							item = new ListViewItem(file.Name, 10);
							break;
						case ".php":
							item = new ListViewItem(file.Name, 12);
							break;
						case ".xml":
							item = new ListViewItem(file.Name, 14);
							break;
						case ".html":
							item = new ListViewItem(file.Name, 16);
							break;
						case ".css":
							item = new ListViewItem(file.Name, 18);
							break;
						default:
							item = new ListViewItem(file.Name, 1);
							break;
					}
					subItems = new ListViewItem.ListViewSubItem[]
				{ new ListViewItem.ListViewSubItem(item, "Fichero"), new ListViewItem.ListViewSubItem(item,file.LastAccessTime.ToShortDateString())};
					item.SubItems.AddRange(subItems);
					listView1.Items.Add(item);
				}
				listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			}
		}

		private void btnIconosPeque_Click(object sender, EventArgs e)
		{
			listView1.View = View.SmallIcon;
			
		}

		private void btnIconosGrandes_Click(object sender, EventArgs e)
		{
			listView1.View = View.LargeIcon;
			listView1.LargeImageList = imageList1;
			
		}

		private void btnIconosLista_Click(object sender, EventArgs e)
		{
			listView1.View = View.List;
			
		}

		private void btnIconosDetalles_Click(object sender, EventArgs e)
		{
			listView1.View = View.Details;

		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
