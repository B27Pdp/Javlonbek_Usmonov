namespace OOP.Lesson_Delegate2.Hometasks
{
    delegate bool MyDel(int n);
    internal class Delegate1
    {

        public List<int> list = new List<int>();
        public int this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }
        public void Start(MyDel del)
        {
           
            list.Add(-2);
            list.Add(-1);
            list.Add(0);
            list.Add(1);
            list.Add(2);
           

            bool a=del(list[3]);
            Console.WriteLine(a);
        }
        public bool Boool(int n)
        {
            if(n>0) return true; 
            return false;
        }
    }
}
