namespace StackApp
{
    internal class Program
    {
        static void Main(string[] args)
        {





            Stack<string> stackA = new Stack<string>();
            Stack<string> stackB = new Stack<string>();
            Stack<string> stackC = new Stack<string>();

            stackA.Push("Blue");
            stackA.Push("Red");
            stackA.Push("Green");
            stackA.Push("Yellow");

            foreach (var item in stackA)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n----------------------\n");
            foreach (var item in stackA)
            {
                stackB.Push(item);
            }
            foreach (var item in stackB)
            {
                stackC.Push(item);
            }
            foreach (var item in stackA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("A\n----------------------\n");
            foreach (var item in stackB)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("B\n----------------------\n");
            foreach (var item in stackC)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("C\n----------------------\n");
            //while (stackA.Count > 0)
            //{
            //    string tempdata = stackA.Pop();
            //    stackB.Push(tempdata);
            //}
            //while (stackB.Count > 0) 
            //{
            //    string tempdata = stackB.Pop();
            //    stackC.Push(tempdata);
            //}
            //Console.WriteLine("\n----------------------\n");
            //foreach (var item in stackC)
            //{
            //    Console.WriteLine(item);
            //}

        }
    }
}
