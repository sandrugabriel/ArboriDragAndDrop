using ArboriDragAndDrop.Coada.interfaces;
using ArboriDragAndDrop.Coada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Arbori.interfaces
{
    public interface IArbor
    {

        TreeNode getNode();

        string find(string cautat);

        TreeNode find(TreeNode current, String cautat);

        void add(string parinte, string copil);

        void afisare();


    }
}
