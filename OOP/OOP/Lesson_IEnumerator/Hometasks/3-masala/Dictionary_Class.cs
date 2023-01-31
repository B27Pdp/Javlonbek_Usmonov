namespace OOP.Lesson_IEnumerator.Hometasks._3_masala
{
    public class Dictionary_Class
    {
        public string str { get; set; }
        Dictionary<string, string> _dic = new Dictionary<string, string>()
        {
            ["name"] = "Javlon",
            ["surname"] = "Usmonov"
        };
        public string this[string key]
        {
            get { return _dic[key]; }
            set { _dic[key] = value; }
        }

        public void Replase()
        {
            int index = str.Length;
                if (str.IndexOf("$") >= 0 && str.Substring(str.IndexOf("$") + 1, 5) == "name$")
                {
                    int n = str.IndexOf("$");
                    str = str.Remove(n, 6);
                    str = str.Insert(n, _dic["name"]);
                }
        }

        public Dictionary_Class(string s)
        {
            str = s;
        }
    }
}
