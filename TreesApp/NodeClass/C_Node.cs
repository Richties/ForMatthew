using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreesApp.NodeClass
{
    class C_Node
    {
        C_Node left, right;
        Employee imp;

        public C_Node(Employee imp)
        {
            this.imp = imp;
        }


        public void insert(Employee input)
        {
            if(input.Priority<=imp.Priority)
            {
                if(left==null)
                {
                    left = new C_Node(input);
                }
                else
                {
                    left.insert(input);
                }
            }
            else
            {
                if(right==null)
                {
                    right = new C_Node(input);
                }
                else
                {
                    right.insert(input);
                }
            }
        }

        public bool contains(Employee input)
        {
            if (input.Priority==imp.Priority&&input.Position.Equals(imp.Position))
            {
                return true;
            }
            else
            {
                if(input.Priority<imp.Priority)
                {
                    if(left==null)
                    {
                        return false;
                    }
                    else
                    {
                        return left.contains(input);
                    }
                    
                }
                else
                {
                    if (right == null)
                    {
                        return false;
                    }
                    else
                    {
                        return right.contains(input);
                    }
                }
            }
            
        }
    }
}
