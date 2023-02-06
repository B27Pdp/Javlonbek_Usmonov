namespace OOP.Lesson_Delegate2.Lessontasks
{
    internal class Predikate
    {
        public List<string> list = new List<string>();
        public void Start()
        {
            list.Add("Abbb");
            list.Add("cbbb");
            list.Add("Abbb");
            list.Add("Abbb");
            list.Add("bbb");
            Predicate<string> predicate1 = list => list.Contains('a');

            string? str = list.Find(predicate1);
        }
    }
}
