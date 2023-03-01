namespace cs_classWithArray_compose_agregate
{
    internal class Program
    {
        static void Main(string[] args) {
           
            
            //var x = a.GetValue(1); /// a[1]
            //Console.WriteLine(x);
            //int xx = (int)x + 5;
            //a.SetValue(1000000, 0);

            ////Console.WriteLine(b[0]);
            ////Console.WriteLine(a[0]);
            
            int[] a = { 1, 2, 3 };
            int[] aa = a;

            int[] b = { 1, 2, 3 };

            int[] c = new int[3];            
            int[] d;

       

            a.CopyTo(c, 0);
            Array.ForEach(c, Console.WriteLine);

            d = (int[])a.Clone();
            Array.ForEach(d, Console.WriteLine);


        }
    }
}