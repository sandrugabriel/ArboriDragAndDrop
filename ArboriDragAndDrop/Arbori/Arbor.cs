using ArboriDragAndDrop.Arbori.interfaces;
using ArboriDragAndDrop.Coada;
using ArboriDragAndDrop.Coada.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.Arbori
{
    public class Arbor : IArbor
    {

        private TreeNode root = null;

        public TreeNode getNode() { return root; }

        public string find(string cautat)
        {
            TreeNode searched = find(root, cautat);
            if (searched != null)
            {
                return searched.Data;
            }
            return null;
        }

        public TreeNode find(TreeNode current, String cautat)
        {


            if (current == null)
            {
                return null;
            }
            else if (current.Data.Equals(cautat))
            {
                return current;
            }

            var left = find(current.Left, cautat);
            if (left != null)
            {
                return left;
            }

            return find(current.Right, cautat);


        }

        public void add(string parinte, string copil)
        {


            if (find(parinte) == null)
            {
                root = new TreeNode();

                root.Left = null;
                root.Right = null;
                root.Data = copil;

            }
            else
            {

                TreeNode nou = new TreeNode();
                nou.Data = copil;
                nou.Left = null;
                nou.Right = null;

                TreeNode aux = find(root, parinte);

                if (aux.Left == null)
                {

                    aux.Left = nou;
                    return;
                }
                else
                {
                    aux.Right = nou;
                    return;
                }

            }



        }

        public void afisare()
        {
            ICoada<TreeNode> coada = new Coada<TreeNode>();

            TreeNode Node = root;

            Console.WriteLine(Node.Data);

            Node = Node.Left;

            do
            {

                Console.WriteLine(Node.Data);

                coada.push(Node.Left);
                coada.push(Node.Right);
                //Console.WriteLine(coada.top().Data) ;
                Node = coada.top();

                //  Console.WriteLine(Node.Data);

                coada.pop();


            } while (Node != null);

        }



    }
}
