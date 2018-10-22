/* BinaryTreeNode.ITree.cs
 * Author: Rod Howell
 * 
 * Note: This file contains only code relevant to drawing the tree.
 * It should not be modified.
 * 
 * Mod: Paulina Olivas
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KansasStateUniversity.TreeViewer2;

namespace Ksu.Cis300.PriorityQueueLibrary
{
    /// <summary>
    /// An immutable binary tree node that can draw itself.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the tree.</typeparam>
    public partial class LeftistTree<T> : ITree
    {
        //globa value of the null paths length
        private int _nullPathLength;

        /// <summary>
        /// Gets the children of this node.
        /// </summary>
        ITree[] ITree.Children
        {
            get
            {
                ITree[] children = new ITree[2];

                int left = NullPathLength(LeftChild);
                int right = NullPathLength(RightChild);

                if(left < right)
                {
                    children[0] = LeftChild;
                    children[1] = RightChild;
                }
                else
                {
                    children[0] = RightChild;
                    children[1] = LeftChild;
                }

                return children;
            }
        }

        /// <summary>
        /// Gets whether this node is empty. Because empty trees will be represented by
        /// null, it always returns false.
        /// </summary>
        bool ITree.IsEmpty => false;

        /// <summary>
        /// Gets the object to be drawn as the contents of this node.
        /// </summary>
        object ITree.Root => Data;

        /// <summary>
        /// Finds the null path lenght of the given tree
        /// </summary>
        /// <param name="t">Tree</param>
        /// <returns>Returns 0 if the given tree is null or the
        /// value stored of _nullPathLength </returns>
        public static int NullPathLength(LeftistTree<T> t)
        {
            if (t.Data == null) { 
                return 0;
            }


            return t._nullPathLength;
        }


    }
}
