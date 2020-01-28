using System;
using System.Collections.Generic;
using System.Text;

namespace MyCollectionLib
{
    public interface IAcross<T>
    {
        public void Across(Tree<T> root);
    }
}
