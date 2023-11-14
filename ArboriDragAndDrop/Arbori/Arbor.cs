﻿using ArboriDragAndDrop.Arbori.interfaces;
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

    }
}
