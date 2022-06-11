using System;

namespace Homework11June
{
    class Program
    {
        static void Main(string[] args)
        {


            //string[] adlar = new string[] { "vahid", "abbas", "nezrin", "hikmet", "abdullah", "duygu" };
            //FilterName(ref adlar);
            //foreach (var item in adlar)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] integers = { 1, 2, 3, 4, 5, 6, 6, 7, 8 };

            //int index = FindIndex(integers, 3);
            //Console.WriteLine(index);
            //EvenFilter(ref integers);
            //foreach (var item in integers)
            //{
            //    Console.WriteLine(item);
            //}
            int[] int1 = { 1, 4, 5 , 8};
            int[] int2 = { 1, 5, 6, 3, 4, 1, 6 };
            bool check = isThere(int1, int2);
            Console.WriteLine(check);

            

        }
        //- Verilmis adlar siyahisinda (string array) nece adin uzunlugunun
        //5-den boyuk oldugunu tapan proqram
        public static string[] FilterName(ref string[] adlar)
        {
            string[] filterlesmisAdlar = new string[0];
            foreach (var item in adlar)
            {
                if (item.Length > 5)
                {
                    Array.Resize(ref filterlesmisAdlar, filterlesmisAdlar.Length + 1);
                    filterlesmisAdlar[filterlesmisAdlar.Length - 1] = item;
                }
            }
            adlar = filterlesmisAdlar;
            return adlar;
        }
        //Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array
        //qaytaran method.Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6}
        //deyerleri varsa method geriye {4,6}
        //deyerlerinden ibaret bir array qaytarmalidir
        public static int[] EvenFilter(ref int[] nums)
        {
            int[] filterednums = new int[0];
            foreach (var item in nums)
            {
                if (item%2==0)
                {
                    Array.Resize(ref filterednums, filterednums.Length + 1);
                    filterednums[filterednums.Length - 1] = item;
                }
            }
            nums = filterednums;
            return nums;
        }
        //Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n
        //ədədinin yerləşdiyi indexi tapan method(binary search)
        public static int FindIndex(int[] array, int n)
        {
            Array.Sort(array);
            int max = array.Length - 1;
            int min = 0;
            int mid = (min + max) / 2;
            while (min<max)
            {
                mid = (min + max) / 2;
                if (n < array[mid])
                {
                    max = mid-1;
                }
                else if (n > array[mid])
                {
                    min = mid+1;
                }
                
            }
            return mid;
            
            
        }
        //Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub
        //olmadığını tapan metod
        public static bool isThere(int[] nums1, int[] nums2)
        {
            bool check;
            int index;
            if (nums1.Length < nums2.Length)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    index = Array.IndexOf(nums2, nums1[i]);
                    if (index ==-1)
                    {
                        check = false;
                        return check;
                        
                    }
                }
                check = true;
                return check;
            }
            else
            {
                check = false;
                return check;
            }
        }
    }

}

