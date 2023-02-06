namespace OOP.Lesson_Delegate2.Hometasks
{
    internal class 
        Func1
    {
        public void Func1_Run(List<int> l)
        {
            Func<List<int>, string> func1 = list =>
            {
                string? str = null;
                foreach (var item in list)
                {
                    str += item;
                }
                return str;
            };
            Console.WriteLine(func1(l));
        }
    }
}
