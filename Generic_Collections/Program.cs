using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Custom<string> nums = new Custom<string>();
           
            nums.Add("a");
            nums.Add("aaaa");
            nums.Add("hbhjb");
            nums.Add("jbshkj");
            //nums.Count();
            //nums.Remove("a");
            //nums.Contains("jj");
            //nums.Clear();
            //nums.Remove("a");

            //strings.Remove("c");

        }


    }
 
        class Custom  <T> where T:class
    {
       public T[] custom;
        public Custom()
        {
            custom = new T[0];
        }



            public void Add( T element)
        {
            Array.Resize(ref custom, custom.Length+1 );
            custom[custom.Length-1] = element;
           
        }


        public void Remove(T a )
        {

            for (int i = 0; i < custom.Length; i++)
            {
                if (custom[i]==a)
                {
                    continue;
                   
                }
                Console.WriteLine(custom[i]);
               


            }
        }
        public void Contains(T num)
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