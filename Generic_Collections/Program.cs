using System.Collections;
using System.ComponentModel.Design;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Custom nums = new Custom();
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            //nums.Count();
            //nums.Remove(1);
            //nums.Contains(4);
            //nums.Clear();   
            nums.Remove(4);

            //Custom strings = new Custom();
            //strings.Add("a");
            //strings.Add("b");
            //strings.Add("c"); 
            //strings.Remove("c");


            //try
            //{
            //    ArrayList arrayList = new ArrayList();
            //    arrayList.Add("a");
            //    arrayList.Add("b");
            //    arrayList.Add("c");
            //    arrayList.Add(1);
            //    arrayList.Add(2);
            //    arrayList.Add(3);
            //    //arrayList.Clear();
            //    arrayList.Contains("a");
            //    //arrayList.Remove("A");
            //        foreach (var item in arrayList)
            //        {
            //            Console.WriteLine(item);
            //        }


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


        }


    }

    class Custom  
    {
        private int[] custom;
        public Custom()
        {
            custom = new int[0];
        }
     



        public void Add( int element)
        {
            Array.Resize(ref custom, custom.Length+1 );
            custom[custom.Length-1] = element;
           
        }


        public void Remove(int a )
        {

            for (int i = 0; i < custom.Length; i++)
            {
                if (custom[i]==a)
                {
                    continue;
                   
                }
                Console.WriteLine(custom[i]);
                if (false)
                {
                    Console.WriteLine("error");
                }


            }
        }
        public void Contains(int num)
        {
            for (int i = 0; i < custom.Length; i++)
            {
                if (custom[i] == num)
                {
                    Console.WriteLine(true);
                    break;
                }
                else if (custom[i] == custom[custom.Length - 1] && custom[i] != num)
                {
                    Console.WriteLine(false);
                }
            }
        }
        public void Clear()
        {
            foreach (var item in custom)
            {
                break; 
            }

        }

        public void Count()
        {
            int count = 0;
            for (int i = 0; i < custom.Length; i++)
            {
                count++;
               
            }
            Console.WriteLine(count);
        }

    }
}