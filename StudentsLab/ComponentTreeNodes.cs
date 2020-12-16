using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Students.StudentsLogic
{
	public partial class ComponentTreeNodes : Component
	{
		public ComponentTreeNodes()
		{
			InitializeComponent();
		}

		public ComponentTreeNodes(IContainer container)
		{
			container.Add(this);

			InitializeComponent();
		}
		 public bool PropertyIsCorrect(T data, String property)
		{
			var fields = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly);
			foreach (var field in fields)
			{
				if (property == field.ToString())
					return true;
			}
			return false;
		}

		public bool AlreadyHaveNode(String property)
		{
			foreach (var node in treeView.Nodes)
				if (node.ToString() == property)
					return true;
			return false;
		}

		public void AddValueToNode(Object obj, String node)
		{
			foreach (TreeNode item in treeView.Nodes)
				if (item.ToString() == node)
					treeView.Nodes[treeView.Nodes.IndexOf(item)].Nodes.Add(new TreeNode(obj.ToString()));


		}

		public void CreateTree(List<T> data, String property)
		{
			if (!PropertyIsCorrect(data[0], property))
			{
				MessageBox.Show("Такого свойства нет у класса.");
			}
			else
			{
				// Display a wait cursor while the TreeNodes are being created.
				Cursor.Current = new Cursor("MyWait.cur");

				// Suppress repainting the TreeView until all the objects have been created.
				treeView.BeginUpdate();

				// Clear the TreeView each time the method is called.
				treeView.Nodes.Clear();

				// Add a root TreeNode for each Customer object in the ArrayList.
				foreach ( var row in data)
				{
					// получили значение свойства
					Type t = row.GetType();
					PropertyInfo[] props = t.GetProperties();
					String prop = t.GetProperty(property).ToString();	

					if (!AlreadyHaveNode(prop))
					{
						treeView.Nodes.Add(new TreeNode(prop));
					}					
					
					AddValueToNode(row, property);					
										
				}

				// Reset the cursor to the default for all controls.
				Cursor.Current = Cursors.Default;

				// Begin repainting the TreeView.
				treeView.EndUpdate();
			}
		}
	}
}
