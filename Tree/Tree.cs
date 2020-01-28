using System;

namespace MyCollectionLib
{

    public class Tree<T>
    {
        TreeItem<T> root { get; set; }
        public TreeItem<T> currentItem { get; private set; }

        public Tree(TreeItem<T> item)
        {
            root = currentItem = item;
        }
        public void GoToRightItem() 
        {
            if(currentItem.RightTree != null) 
                currentItem = currentItem.RightTree;
        }
        public void GoToLeftItem()
        {
            if (currentItem.LeftTree != null)
                currentItem = currentItem.LeftTree;
        }
        public void GoToRoot() 
        {
            currentItem = root;
        }

        public void AddRightItem(TreeItem<T> item)
        {
            currentItem.RightTree = item;
        }

        public void AddLeftItem(TreeItem<T> item)
        {
            currentItem.LeftTree = item;
        }
    }
    public class TreeItem<T>
    {
        public TreeItem<T> LeftTree { get; set; }
        public TreeItem<T> RightTree { get; set; }
        public T Value { get; set; }

        public TreeItem(T value)
        {
            Value = value;
        }
    }
}
