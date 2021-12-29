using System;
using System.Collections.Generic;
using System.Text;

namespace Praktika1
{
    class MyStack
    {
        public int N_op;

        Node head = null;
        int count = 0;
        class Node
        {
            public int Value;
            public Node Next;
        }

        public void Push(int value)
        {
            N_op++;
            // Создаётся новый элемент стека, который ссылается на предыдущую "голову"
            Node newNode = new Node(); N_op++;
            newNode.Next = head; N_op++;
            newNode.Value = value; N_op++;

            head = newNode; N_op++;
            count++; N_op += 1;
        }

        public bool IsEmpty() // 2
        {
            N_op += 2;
            return head == null;
        }

        public int Peek() //5
        {
            if (IsEmpty())
            {
                N_op++;
                Console.WriteLine("Стек пуст"); N_op++;
                N_op++;
                return 0;
            }
            N_op++;
            return head.Value;
        }

        public int Count() // 1
        {
            N_op++;
            return count;
        }

        public int Pop() // 8
        {
            if (!IsEmpty())
            {
                N_op++;
                Node newNode = new Node(); N_op++;

                newNode.Value = head.Value; N_op++;
                head = head.Next; N_op++;
                count--; N_op += 1;

                N_op++;
                return newNode.Value;
            }
            else
            {
                Console.WriteLine("Стек пуст"); N_op++;
                N_op++;
                return 0;
            }
        }

        public void Show()
        {

            MyStack boof = new MyStack(); N_op++;
            int n = count; N_op++;

            N_op += 2;
            for (int i = 0; i < n; i++)
            {
                N_op += 2;
                boof.Push(Pop());
            }
            N_op += 2;
            for (int i = 0; i < n; i++)
            {
                N_op += 2;
                Push(boof.Pop());
                Console.WriteLine(Peek()); N_op++;
            }
        }

        public int Get(int pos)
        {
            N_op++;
            MyStack boof = new MyStack(); N_op++;
            int n = count; N_op++;
            int result = 0; N_op++;
            N_op += 2;
            for (int i = 0; i < n; i++)
            {
                N_op += 2;
                boof.Push(Pop());
            }

            for (int i = 0; i < n; i++)
            {
                Push(boof.Pop());
                if (pos == count - 1)
                {
                    N_op += 2;
                    result = Peek(); N_op++;
                }

            }
            N_op++;
            return result;
        }

        public void Set(int pos, int value)
        {
            N_op += 2;
            MyStack boof = new MyStack(); N_op++;
            int n = count; N_op++;
            N_op += 2;
            for (int i = 0; i < n; i++)
            {
                N_op += 2;
                boof.Push(Pop());
            }
            N_op += 2;
            for (int i = 0; i < n; i++)
            {
                N_op += 2;
                if (pos == count)
                {
                    N_op++;
                    boof.head.Value = value; N_op++;
                }
                Push(boof.Pop());
            }
        }

        public void Sort()
        {
            int length = count / 2; N_op += 2;
            while (length >= 1)
            {
                N_op++;
                for (int i = length; i < count; i++)
                {
                    int j = i; N_op++;
                    while ((j >= length) && (Get(j - length) > Get(j)))
                    {
                        N_op += 4;
                        int boof = Get(j); N_op++;
                        Set(j, Get(j - length)); N_op++;
                        Set(j - length, boof); N_op++;
                        j = j - length; N_op += 2;
                    }
                }

                length = length / 2; N_op += 2;
            }
        }

    }
}