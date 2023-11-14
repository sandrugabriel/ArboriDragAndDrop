using ArboriDragAndDrop.Coada.interfaces;
using ArboriDragAndDrop.Coada;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Arbori.interfaces
{
    public interface IArbor<T>
    {

        TreeNode<T> getNode();

        T find(T cautat);

        TreeNode<T> find(TreeNode<T> current, T cautat);

        void add(T parinte, T copil,string part);

        void afisare();

        void setT(T luat, T pus);

    }
}
