using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //栈stack是后进 先出的数据类型，相当于每次压栈都是从顶端进栈，进栈是从顶端出栈
            Stack<int> stack = new Stack<int>();

            //添加元素-压栈
            stack.Push(1);
            stack.Push(2);
            stack.Push(-5);
            stack.Push(-4);

            Console.WriteLine(getMin(stack));
            Console.Read();

        }

      static  int getMin(Stack<int> stack) {
            //该栈获取
            int min = 0;
            for (int i=0;i<stack.Count();i++) {
                if (min > stack.Peek())
                    min=stack.Peek();   //获取栈顶元素
                stack.Pop(); //移除元素
            }
            return min;
        }
    }
}
