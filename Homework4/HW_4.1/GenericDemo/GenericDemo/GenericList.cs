using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList() {
            tail = head = null;
        }

        //往List里添加新结点
        public void Add(T t) {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else {
                tail.Next = n;
                tail = n;
            }
        }


        //打印方法
        public void MyForeach(Action<T> action) {
            Node<T> p = head;
            while (p != null) {
                action(p.Data);
                p = p.Next;
            }
        }

    }
}
