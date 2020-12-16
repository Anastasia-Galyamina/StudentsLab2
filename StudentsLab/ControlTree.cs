using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace StudentsLab
{
	public partial class ControlTree : UserControl
	{
		public ControlTree()
		{
			InitializeComponent();
            treeView.AfterSelect += (s, arg) => Id = Convert.ToInt32(treeView.SelectedNode.ToString().Split(' ')[1]);
            treeView.AfterSelect += (s, arg) => item = treeView.SelectedNode;

        }
        int Id;
        object item;
		public bool PropertyIsCorrect<T>(T data, String property)
		{
			var fields = data.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
			foreach (var field in fields)
			{
				if (property == field.Name)
					return true;
			}
			return false;
		}
		
		public String ConvertToString<T>(T data)
        {
			String str = "";
			var fields = data.GetType().GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
			foreach (var field in fields)
			{
				str += field.GetValue(data) + " ";
			}
			return str;
		}

		public bool AlreadyHaveNode(String property)
		{
			foreach (var node in treeView.Nodes)
            {
				if (node.ToString().Substring(10) == property)                
					return true;
				//MessageBox.Show(node.ToString());	
            }			
				return false;
		}

		public void AddValueToNode(Object obj, String node)
		{
			foreach (TreeNode item in treeView.Nodes)
				if (item.ToString().Substring(10) == node)
					treeView.Nodes[treeView.Nodes.IndexOf(item)].Nodes.Add(new TreeNode(ConvertToString(obj)));


		}

        public object GetSelectedItem()
        {

            return item;
        }

        public int GetSelectedId()
		{

            return Id;
		}
		public void CreateTree<T>(List<T> data, String property)
		{
			if (!PropertyIsCorrect(data[0], property))
			{
				MessageBox.Show("Нет такого свойства");
				
			}
			else
			{				
				
				treeView.BeginUpdate();				
				treeView.Nodes.Clear();
		
				foreach (var row in data)
				{					
					String val = row.GetType().GetProperty(property).GetValue(row).ToString();

					if (!AlreadyHaveNode(val))
					{						
						treeView.Nodes.Add(new TreeNode(val));

					}

					AddValueToNode(row, val);

				}

				// Reset the cursor to the default for all controls.
				Cursor.Current = Cursors.Default;

				// Begin repainting the TreeView.
				treeView.EndUpdate();
			}
		}
	}
}
