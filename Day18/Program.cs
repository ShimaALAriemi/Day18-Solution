namespace Day18
{
    public static class IntegerMiror
    {
        public static int Miror(this int number)
        {
            int result = 0, reminder;

            while (number != 0)
            {
                reminder = number % 10;
                result = result * 10 + reminder;
                number = number / 10;
            }
            return result;
        }
    }
    internal class Program
    {
       
        static void Main(string[] args)
        {
            #region Extention
            /*
            int x = 12345;
            Console.WriteLine(x.Miror());
            int re = 10;
            for (int i = 1; i < 5; i++)
            {
                Console.WriteLine(12345 / re);
                re = re * 10;
            }
            */
            #endregion

            /*
            List<int> list = new List<int> {1,2,3,4,5,6,7,8,9};
            var len = list.Where(x => x % 3 == 0);
            Console.WriteLine(len.GetType());
            foreach ( var x in list ) Console.WriteLine(x);
            */

            List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var result = lst.Where(i => i % 2 == 0).ToList();
           Console.WriteLine(result.GetType());

            lst.Remove(2);
            lst.AddRange(new int[] { 10, 11, 12, 13, 14 });

            //Guess What is the Output 
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
            lst.AddRange(new int[] { 15, 16, 17, 18, 19 });

            Console.WriteLine(" ");
            //What is The output
            foreach (int i in result)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine("");


        }
    }
}