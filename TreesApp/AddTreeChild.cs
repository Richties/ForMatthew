using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreesApp
{
    public partial class AddTreeChild : Form
    {
        C_Tree<string> tree = new C_Tree<string>();
        string searchText = "";
        BinaryTree binaryTree = new BinaryTree();
        public AddTreeChild()
        {
            InitializeComponent();
           
            
            binaryTree.insertNode(new Employee("Harambe", 4));
            binaryTree.insertNode(new Employee("Guns", 1));
            binaryTree.insertNode(new Employee("Out", 2));
            binaryTree.insertNode(new Employee("For", 3));
            binaryTree.insertNode(new Employee("Yo  Mama", 5));
            binaryTree.insertNode(new Employee("Serious", 6));
            binaryTree.insertNode(new Employee("Not 12", 12));
            binaryTree.insertNode(new Employee("Professional", 10));
           
            binaryTree.insertNode(new Employee("Weed Lol", 420));
            bool titsout4H = binaryTree.containsNode(new Employee("Harambe", 4));
            bool titsout4H2 = binaryTree.containsNode(new Employee("Yo Daddy", 5));

            /*          tree.Root = new TreeNode<string>() { Data = "Rajesh" };
                        tree.Root.Children = new List<TreeNode<string>>
                        {
                            new TreeNode<string> { Data = "Sarina", Parent = tree.Root},
                            new TreeNode<string> { Data = "EB", Parent = tree.Root},
                        };

                        tree.Root.Children[0].Children = new List<TreeNode<string>>
                        {
                            new TreeNode<string> { Data = "Kyle", Parent = tree.Root.Children[0]},
                            new TreeNode<string> { Data = "Chandre", Parent = tree.Root.Children[0]},
                        };

                        tree.Root.Children[1].Children = new List<TreeNode<string>>
                        {
                            new TreeNode<string> { Data = "Nathan", Parent = tree.Root.Children[1]},
                            new TreeNode<string> { Data = "Josie", Parent = tree.Root.Children[1]},
                            new TreeNode<string> { Data = "Matt", Parent = tree.Root.Children[1]}
                        };*/
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            binaryTree.insertNode(new Employee(positionTxt.Text.ToString(), Convert.ToInt32(priorityTxt.Text)));
            
        }

        private TreeNode<string> realSearch(TreeNode<string> node)
        {

            foreach (TreeNode<string> t in node.Children)
            {
                if (t.Data.Equals(searchText))
                    {
                        return t;
                    }
                try
                {
                    realSearch(t);
                }
                catch
                {
                    Console.WriteLine("Lmao dude");
                }
            }
            return node;
        }


        private void search(string parent)
        {
            int indexI, indexJ;
            TreeNode<string> temp = new TreeNode<string>();
            temp = tree.Root;
            for (int i = 0; i < temp.Children.Count; i++)
            {
                for (int j = 0; j < temp.Children[i].Children.Count; j++)
                {
                    if (parent.Equals(temp.Children[i].Children[j]))
                    {
                        indexI = i;
                        indexJ = j;
                    }
                }
                temp = temp.Children[i+1];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool titsout4H2 = binaryTree.containsNode(new Employee(positionTxt.Text.ToString(), Convert.ToInt32(priorityTxt.Text)));
            treetxt.Text = titsout4H2.ToString();
        }
    }
}
