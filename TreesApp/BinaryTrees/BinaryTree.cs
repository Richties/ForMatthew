using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreesApp.NodeClass;

namespace TreesApp
{
    class BinaryTree
    {
        C_Node route;

        public void insertNode(Employee data)
        {
            if(route!=null)
            {
                route.insert(data);

            }
            else
            {
                route = new C_Node(data);
            }
        }

        public bool containsNode(Employee data)
        {
            if (route!=null)
            {
                if (route.contains(data))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
