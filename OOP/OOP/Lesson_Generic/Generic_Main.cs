using OOP.Lesson_Generic.Lessontasks;

namespace OOP.Lesson_Generic
{
    public class Generic_Main
    {
        public static void Mainn()
        {
        /*Class1<int> obj = new Class1<int>();

        obj.AddValue(1);
        obj.AddValue(5);
        obj.AddValue(3);
        obj.AddValue(2);
        obj.AddValue(5);
        obj.Print();
        obj.Remove_Index(1);
        //obj.RemoveValue(2);
        Console.WriteLine();
        obj.Print();*/
        /*User person = new User("Javlon", "ujavlon64@gmail.com", "998903409342");
        Console.WriteLine(person["name"]);*/
        /*Indexget number= new Indexget();
        Console.WriteLine(number["903409342"]);*/
        //nums = [1,3,5,6], target = 2
        //Output: 1
            Solution getobj=new Solution();
            getobj.SearchInsert(new int[] { 1, 3, 5, 6 }, 2);
        }
    }
}
