namespace Arrays
{
    class Arrays
    {
        static void Main(string[] args)
        {
            Console.Clear();

            var myArray = new int[5] {1, 2, 3, 4, 5};
            myArray[0] = 12;

            foreach (var item in myArray)
                Console.WriteLine(item);
        }
    }
}