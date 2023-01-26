using OOP_11.vazifa_List._2_masala;
using OOP_11.vazifa_List._4_masala;

namespace OOP_11.vazifa_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List.StartArrayList();
            //List_Max.Get_Max();
            //ListError.GetError();
            //Name.GetName();
            /*string[] list1 = {"Javlon", "Ozod","Asad" };
            string[] list2 = {"Kamol","Javlon", "Ozod","Asad" };
            Solution obj = new();
            foreach (var item in obj.FindRestaurant(list1, list2))
            {
                Console.WriteLine(item);
            }*/
            /*int[] nums = {5,8,3,2,6,9,7 }; 
            Class1 obj= new Class1();
            foreach (var item in obj.SortArrayByParity(nums))
            {
                Console.Write(item+" ");
            }*/
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };
            leetcode obj= new leetcode();
            foreach (var item in obj.Intersection(nums1,nums2))
            {
                Console.WriteLine(item);
            }


        }
    }
}