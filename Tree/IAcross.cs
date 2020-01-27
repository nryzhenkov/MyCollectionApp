using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionApp
{
    public interface IAcross<T>
    {
        public void Across(Tree<T> root);
    }
}
