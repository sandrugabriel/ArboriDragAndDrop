using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArboriDragAndDrop.Arbori
{
    public class TreeNode : IComparable<TreeNode>
    {

        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public string Data { get; set; }

        public int CompareTo(TreeNode other)
        {
            throw new NotImplementedException();
        }
    }
}
