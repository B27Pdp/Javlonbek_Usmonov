namespace OOP.Lesson_Taple_Nullable.Hometasks.Proyekt
{
    public class TripleDictionary<T, U, V>
    {
        /*private T _id;

		public T Id
		{
			get { return _id; }
			set { _id = value; }
		}
		private T _age;

		public T Age
		{
			get { return _age; }
			set { _age = value; }
		}
		private T _year;

		public T Year
		{
			get { return _year; }
			set { _year = value; }
		}*/


        public void OrderBy(List<T> list)
        {
            var t = (list);
            t.Sort();
            for (int i = 0; i < t.Count; i++)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine();
        }
        
        public void OrderByDesc(List<T> list)
        {
            var t = (list);
            t.Sort();
            for (int i = t.Count-1; i >= 0; i--)
            {
                Console.WriteLine(t[i]);
            }
            Console.WriteLine();
        }

        /*public TripleDictionary(T id, T age, T year)
        {
            Id = id;
            Age = age;
            Year = year;
        }*/

        public TripleDictionary()
        {

        }
    }
}
