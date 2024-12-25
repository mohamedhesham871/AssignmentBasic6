using System.Security.Cryptography;
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
            //   static int multarr(int[] ar)
            //  {
            //      int mult = 1;
            //      ar= new int[]{ 90,40,24};
            //      for(int i = 0; i<ar.Length;i++)
            //      {
            //          if(ar[i] != 0)
            //          {
            //              mult*=ar[i];
            //          }
            //      }
            //      return mult;
            //  }
            //  int[] Arr = { 10, 30, 40 };
            //  Console.WriteLine("multiplication is : " + multarr( Arr));
            //  Console.WriteLine(Arr[0]);
            //  //using ex for by ref out of main

            //Console.WriteLine("\n***************************\n");
            //  Console.WriteLine("multiplication is : "+multarrr(ref Arr));
            //  Console.WriteLine(Arr[0]);
            #endregion
            #region Q2:Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static void MyFun(int s1,int s2,int s3,int s4, out int sum,out int sub)
            //{
            //    sum = s1 + s2 + s3 + s4;
            //    sub = s1 - s2 - s3 - s4;
            //}


            //Console.WriteLine("enter four numbers \n");
            //int x1 = int.Parse(Console.ReadLine());
            //int x2 = int.Parse(Console.ReadLine());
            //int x3 = int.Parse(Console.ReadLine());
            //int x4 = int.Parse(Console.ReadLine());
            //int sum, sub;
            //MyFun(x1, x2, x3, x4,out sum,out sub);
            //Console.WriteLine($"sum is {sum} and sub is {sub}");
            #endregion
            #region Q3 create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            static void MinMaxArray(int[] arr,ref int minn,ref int maxx)
            {
                minn = arr[0];
                maxx = arr[0];
                for (int i = 1;i<arr.Length;i++)
                {
                    if (arr[i] < minn) minn = arr[i];
                    if(arr[i] > maxx) maxx = arr[i];
                }
            }

            int[] arr = { 20, 34, 23, 2, 4324, 42, 3, 1, 203 };

            int min=arr[0];
            int maxx = arr[0] ;
            MinMaxArray(arr, ref min, ref maxx);

            Console.WriteLine($"min number is : {min}\nmax number is : {maxx}");
            #endregion
        }



        ////using ex for by ref
        //static int multarrr(ref int[] ar)
        //    {
        //        int mult = 1;
        //        ar = new int[] { 90, 40, 24 };
        //        for (int i = 0; i < ar.Length; i++)
        //        {
        //            if (ar[i] != 0)
        //            {
        //                mult *= ar[i];
        //            }
        //        }
        //        return mult;
        //    }
    }
}
