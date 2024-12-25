using System.Security.Cryptography.X509Certificates;

namespace Basic6_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //First passing by value 
            //when using by value you take as copy of reference if do any change it will happen in original object
            //but if do reassignment doesn't change in original one

            //second passing by reference
            //when using by ref  you take direct access to original reference
            //allow to modifing and  reassign the reference '

            //using ex call by value 
             static int multarr(int[] ar)
            {
                int mult = 1;
                ar= new int[]{ 90,40,24};
                for(int i = 0; i<ar.Length;i++)
                {
                    if(ar[i] != 0)
                    {
                        mult*=ar[i];
                    }
                }
                return mult;
            }
            int[] Arr = { 10, 30, 40 };
            Console.WriteLine("multiplication is : " + multarr( Arr));
            Console.WriteLine(Arr[0]);
            //using ex for by ref out of main

          Console.WriteLine("\n***************************\n");
            Console.WriteLine("multiplication is : "+multarrr(ref Arr));
            Console.WriteLine(Arr[0]);
            #endregion
        }


        //using ex for by ref
        static int multarrr(ref int[] ar)
            {
                int mult = 1;
                ar = new int[] { 90, 40, 24 };
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] != 0)
                    {
                        mult *= ar[i];
                    }
                }
                return mult;
            }
    }
}
