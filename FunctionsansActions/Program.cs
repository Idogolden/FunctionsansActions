using System.ComponentModel;
using System.Threading.Channels;

namespace FunctionsansActions
{
    internal class Program
    {
        public class Button 
        {
            public Action OnClick;

            public void SimulateClick() 
            {
                Console.WriteLine("Button was clicked");
                if (OnClick != null) 
                {
                    OnClick();
                }
            }
        }
        public bool Returnbool(bool flag) 
        {
            return flag;
        }
       public static List<int> FilterNumbers(int[] arr, Predicate<int> check) 
        {
            List<int> lst= new List<int>();
            foreach (int a in arr)
            {
                if (check.Invoke(a))
                {
                    lst.Add(a);
                }
            }
            return lst;
        }
        public static bool Even(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }

            else return false;
        }
        public static bool BiggerThenTen(int num)
        {
                if (num > 10)
              return true;
            else return false;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter a number");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Predicate<int> g = Even;
            FilterNumbers(arr,g);
            List<int> lst = new List<int>();
            lst = FilterNumbers(arr, g);
            foreach (int l in lst) 
            {
                Console.WriteLine(l);
            }
            Predicate<int> f = BiggerThenTen;
            FilterNumbers(arr, f);
            foreach (int l in lst)
            {
                Console.WriteLine(l);
            }
            Button b = new Button();
            
        }
    }
}
