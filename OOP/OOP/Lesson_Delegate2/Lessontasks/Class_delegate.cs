namespace OOP.Lesson_Event.Lessontasks
{
    internal class Class_delegate
    {
        public delegate string Mydelegate(string str);
        public void ToStart()
        {
            Mydelegate md = GetString;
            Mydelegate mydelegate = delegate (string s)
            {
                return s;
            };
        }
        public string GetString(string str)
        {
            string val = str + " Javlon";
                return str+" Javlon";
        }
    }
}
