using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoresBasicas
{
    public class Node<T>
    {
        public T? Data {get;set;}
        public Node<T>? Parent {get;set;}  

        public List<Node<T>>? Children {get;set;} = [];

        public int GetHeight()
        {
            int height = 1;
            Node<T> currrent = this;
            while (currrent.Parent != null)
            {
                height++;
                currrent = currrent.Parent;     

            }
            return height;
        }  
    }
}