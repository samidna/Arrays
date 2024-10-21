using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arraydeki ededlerin cemi
            //int[] arr = { 10, 20, 30, 40, 50, 60 };
            //int sum = 0;

            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            #region Arraydeki en boyuk ededin tapilmasi
            //int[] arr = { 10, 45, 32, 79, 87, 14 };
            //int maxNum = 0;

            //for(int i = 0;i<arr.Length; i++)
            //{
            //    if (arr[i] > maxNum) maxNum = arr[i];
            //}
            //Console.WriteLine(maxNum);

            #endregion

            #region Arrayin ilk ve son elementlerinin ceminin tapilmasi
            //int[] arr = { 15, 65, 78, 145, 14, 23 };
            //int sum = arr[0] + arr[arr.Length - 1];
            //Console.WriteLine(sum);
            #endregion

            #region Verilmis ededin 2nin quvveti olub olmamasini tapmaq
            //Console.Write("Eded daxil edin : ");
            //int num = int.Parse(Console.ReadLine());

            //while (num % 2 == 0) num /= 2;
            //if (num == 1) Console.WriteLine("quvvetidir");
            //else Console.WriteLine("quvveti deyil");
            #endregion

            #region Verilmis ededin nece mertebeli oldugunu tapmaq
            //Console.Write("Ededi daxil edin : ");
            //int num = int.Parse(Console.ReadLine());
            //int count = 0;

            //while(num > 0)
            //{
            //    num /= 10;
            //    count++;
            //}
            //Console.WriteLine(count);
            #endregion

            #region Arraydeki axtarilan ededin indexini qaytarmaq
            Console.Write("Axtarmaq istediyiniz ededi daxil edin : ");
            int num = int.Parse(Console.ReadLine());
            int[] arr = { 15, 20, 25, 34, 37, 48, 49, 74 };
            int tempNum = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    tempNum = i;
                }
            }
            if (tempNum == -1) Console.WriteLine("-1");
            else Console.WriteLine(tempNum);


            #endregion
        }
    }
}
