using ArboriDragAndDrop.Arbori.interfaces;
using ArboriDragAndDrop.Coada;
using ArboriDragAndDrop.Coada.interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArboriDragAndDrop.Arbori
{
    public class Arbor<T> : IArbor<T> where T : Panel
    {

        private TreeNode<T> root = null;

        public TreeNode<T> getNode() { return root; }

        public T find(T cautat)
        {
            TreeNode<T> searched = find(root, cautat);
            if (searched != null)
            {
                return searched.Data;
            }

            return cautat;
        }

        public TreeNode<T> find(TreeNode<T> current, T cautat)
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

        public void add(T parinte, T copil, string part)
        {


            if (find(parinte) == null)
            {
                root = new TreeNode<T>();

                root.Left = null;
                root.Right = null;
                root.Data = copil;

            }
            else
            {

                TreeNode<T> nou = new TreeNode<T>();
                nou.Data = copil;
                nou.Left = null;
                nou.Right = null;

                TreeNode<T> aux = find(root, parinte);

                if (aux.Left == null && part == "left")
                {

                    aux.Left = nou;
                    return;
                }
                else if(aux.Right == null && part == "right")
                {
                    aux.Right = nou;
                    return;
                }
                else
                {
                    MessageBox.Show("Nu sa putu adauga!!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }



        }

        public void afisare()
        {
            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> Node = root;

            do
            {
                
                MessageBox.Show(Node.Data.ToString());

                coada.push(Node.Left);
                coada.push(Node.Right);
                //MessageBox.Show(coada.top().Data) ;
                Node = coada.top();

                //  MessageBox.Show(Node.Data);

                coada.pop();


            } while (Node != null);

        }

        public void setT(T luat, T pus)
        {

            TreeNode<T> card1 = find(root,luat);
            TreeNode<T> card2 = find(root,pus);

            T aux = card1.Data;
            card1.Data = card2.Data;
            card2.Data = aux;

        }

        public void saveFisier(TreeNode<T> node, string name)
        {

            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> Node = node;

            string text = "";



            do
            {
                text += name + "|" + Node.Left.Data.Name.ToString() + "|" + Node.Data.Name.ToString() + "|" + Node.Right.Data.Name.ToString() + "\n"; 

                coada.push(Node.Left);
                coada.push(Node.Right);
                Node = coada.top();


                coada.pop();


            } while (Node.Right != null && Node.Left != null);

            File.AppendAllText(Application.StartupPath + @"/data/arbori.txt",text);

            MessageBox.Show("Schema s-a salvat in fisier","Succes!",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        public void load(string name)
        {
            root = new TreeNode<T>();

            StreamReader streamReader = new StreamReader(Application.StartupPath + @"/data/arbori.txt");

            string text = "";

            while((text = streamReader.ReadLine()) != null && streamReader.ReadLine().Split('|')[0] == name)
            {

                string[] prop = text.Split('|');

                TreeNode<T> left = new TreeNode<T>();

                left.Data.Name = prop[0];
                root.Left = left;

                root.Data.Name = prop[1];

                TreeNode<T> right = new TreeNode<T>();

                right.Data.Name = prop[2];
                root.Right = right;


            }

            streamReader.Close();
        }

        public T findParinte(T copil)
        {

            ICoada<TreeNode<T>> coada = new Coada<TreeNode<T>>();

            TreeNode<T> Node = root;

            do
            {
                if (Node.Left != null )
                    if(Node.Left.Data == copil)
                    {
                        return Node.Data;
                    }

                if (Node.Right != null)
                    if (Node.Right.Data == copil)
                    {
                        return Node.Data;
                    }
               
                   // MessageBox.Show(Node.Data.ToString());

                coada.push(Node.Left);
                coada.push(Node.Right);
                Node = coada.top();

                coada.pop();


            } while (Node != null);


            return null;
        }

        public void afisareParinte(T data)
        {
            string t = "Parintele: " + data.ToString();
            TreeNode<T> aux = find(root, data);
            if (aux.Left != null)
                t += "\nLeft: " + aux.Left.Data.ToString();

            if (aux.Right != null)
                t += "   Right: " + aux.Right.Data.ToString();

            MessageBox.Show(t);
        }
    }
}
