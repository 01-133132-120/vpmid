using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace functionoverriding
{
    class functionoverridingclass
    {
        public virtual  void evenodd()
        {
            int num1=int .Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
       
    }
    class secondclass:functionoverridingclass
    {
        public override void evenodd()
        {
            functionoverridingclass obj = new functionoverridingclass();
            obj.evenodd();
        }
    }
}
namespace functionoverloading
{
    class functionloadingclass
    {
        public void sum()
        {
            int num1 = 20;
            int num2=30;
            int sum = num1 + num2;
            Console.WriteLine("sum = " + sum);
        }
        public void sum(int num1, int num2)
        {
            
            int ans = num1 + num2;
            Console.WriteLine("ans of over = " + ans);
        }
    }
}
namespace check
{
    interface interface_1
    {
         void function_interface();
    }
    class interfaceclass:interface_1
    {
        public void function_interface()
        {
            Console.WriteLine("implicit function of interface");
        }
        void interface_1.function_interface()
        {
            Console.WriteLine("explicit interface");
        }
    }
     class checkclass:IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("dispose");
        }
        
        public void checkfunction()
        {
            Console.WriteLine("namespace function");
        }
        
    }
    namespace checkagain
    {
        public class checkagainclass
        {
            public void checkagainfun()
            {
                Console.WriteLine("another");
            }
        }
    }
}
namespace vp_mids
{
    delegate int NumberChanger(int n);
    class TestDelegate
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }

        public static int getNum()
        {
            return num;
        }

        class Program
        {
            public void evenodd()
            {
                int temp = 0;
                Console.WriteLine("enter the number");
                int n = int.Parse(Console.ReadLine());
                int[] num = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("enter the values");
                    num[i] = int.Parse(Console.ReadLine());
                }
                foreach (int n1 in num)
                {

                    if (n1 % 2 == 0)
                    {
                        temp += n1;
                    }
                }
                Console.WriteLine("total of even  " + temp);

            }
            public void reverse()
            {
                //int temp=0;
                int num = int.Parse(Console.ReadLine());
                int[] reversenum = new int[num];

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("entet the numbers");
                    reversenum[i] = int.Parse(Console.ReadLine());

                }
                Array.Reverse(reversenum);
                for (int j = 0; j < reversenum.Length; j++)
                {
                    Console.WriteLine(reversenum[j]);

                }

            }


            public void remove()
            {
                int[] name1 = { 2, 3, 2, 4, 4 };
                //  int temp = 0;
                Array.Sort(name1);//2,2,3
                for (int i = 0; i < name1.Length; i++)
                {
                    for (int j = i + 1; j < name1.Length; j++)
                    {
                        if (name1[i] == name1[j])
                        {
                            name1[j] = 0;
                            name1[i] = 0;

                        }

                    }
                    Console.WriteLine(name1[i]);
                }
            }

            public void checkrepeat()
            {
                string arra = "hassan";

                char[] arra1 = arra.ToCharArray();
                int i;
                for (i = 0; i < arra1.Length; i++)
                {

                    for (int j = i; j < arra1.Length; j++)
                    {

                        if (arra1[i] != arra1[j])
                        {

                            arra1[i] = '0';
                        }

                    }
                    Console.WriteLine("value " + arra1[i].ToString());

                }

                //Console.WriteLine(arra1[i]);
            }
            public void forcheck()
            {
            
                int[] name = { 1, 2, 3, 4, 1, 9, 9 };
                //Array.Sort(name);
                int count = 0;
                for (int i = 0; i < name.Length; i++)
                {
                  
                    for (int j = 0; j < i; j++)
                    {
                        if (name[i] == name[j])
                        {
                             name[i] = 0; 
                        }
                             
                    }
                    Console.WriteLine("values " + name[i] + "at index of " + i);

                    //break;                   
                }
            }
            public void findnumber()
            {
                int[] arra = { 1, 2, 3, 4, 5 };
                Console.WriteLine( arra.Max());
                int output = arra.Max() - 1;
                Console.WriteLine("less than max " +output);

            }
            public void findadd()
            {
                int[] num = { 1, 2, 3, 4 };
               Console.WriteLine("enter num to check");
                int check=int.Parse(Console.ReadLine());
                for (int i = 0; i < num.Length; i++)
                {
                    for (int j = 0; j < num.Length; j++)
                    {
                        if (num[i] + num[j] == check)
                        {
                            Console.WriteLine("find " +"("+ num[i]+"," + num[j]+")");
                        }
                    }
                   
                    
                }
            }

            
            public void reference(ref int num1, ref int num2)
            {
                num1 = 30;
                num2 = 40;
                num1 = num1 + num2;//30
                num2 = num1 - num2;//10;
                num1 = num1 - num2;//20
            }


            public static void Main(string[] args)
            {
                Program cs = new Program();
                int val = 1;
                int val2 = 2;
                // cs.evenodd();
                //cs.reverse();
                // cs.remove();
                // cs.checkrepeat();
                check.checkclass obj = new check.checkclass();
                //obj.checkfunction();
                check.checkagain.checkagainclass obj1 = new check.checkagain.checkagainclass();
                obj.checkfunction();
                obj.Dispose();
                using (check.checkclass obj2 = new check.checkclass())
                {
                    obj2.checkfunction();
                    // obj2.Dispose();
                }

                obj1.checkagainfun();
                //cs.ch();
                //cs.reference(ref val, ref val2);
                Console.WriteLine("value 1 " + val);
                Console.WriteLine("value  2 " + val2);
                check.interfaceclass objin = new check.interfaceclass();
                objin.function_interface();
                check.interface_1 objinter = new check.interfaceclass();
                objinter.function_interface();
                functionoverloading.functionloadingclass objfun = new functionoverloading.functionloadingclass();
                objfun.sum();
                objfun.sum(12, 100);

                NumberChanger nc;
                NumberChanger nc1 = new NumberChanger(AddNum);
                NumberChanger nc2 = new NumberChanger(MultNum);
                nc = nc1;
                nc += nc2;

                //calling multicast
                nc(5);
                Console.WriteLine("Value of Num: {0}", getNum());
                Console.ReadKey();
               // cs.forcheck();
                cs.findnumber();
               // cs.check();
               // cs.findadd();
                cs.checkrepeat();
                Console.ReadLine();
            }
        }
    }

}