/*Quyidagi list dan eng katta juft sonni toping.
 
[12, 3, 34, 56, 11, 32, 45, 11, 43]*/
namespace OOP_11.vazifa_List
{
    internal class List_Max
    {
        public static void List__Max()
        {
            List<int> list = new List<int>
            {
                12, 3, 34, 56, 11, 32, 45, 11, 43
            };
            Console.WriteLine(list.Max());
        }
        public static void Get_Max()
        {
            List_Max.List__Max();
        }
    }
}
