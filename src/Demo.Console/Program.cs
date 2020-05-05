namespace Demo.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("----------------- Version 1 --------------------");
            var version1 = new Version1.Version1();
            version1.Display();

            //System.Console.WriteLine("----------------- Version 2 --------------------");
            //var version2 = new Version2.Version2();
            //version2.Display();

            //System.Console.WriteLine("----------------- Version 3 --------------------");
            //var version3 = new Version3.Version3();
            //version3.Display();

            //System.Console.WriteLine("----------------- Version 4 --------------------");
            //var version4 = new Version4.Version4();
            //version4.Display();

            //System.Console.WriteLine("----------------- Version 5 --------------------");
            //var version5 = new Version5.Version5();
            //version5.Display();

            System.Console.WriteLine("----------------- Version 6 --------------------");
            var version6 = new Version6.Version6();
            version6.Display();
        }
    }
}