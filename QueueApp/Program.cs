namespace QueueApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id); //prints 1234

           
        }
    }
}
