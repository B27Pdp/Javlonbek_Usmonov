namespace Advanced.Lesson_Regax2.Hometasks
{
    internal class Solution_3
    {
        public int FindLUSlength(string a, string b)
        {

            if (a.Length > b.Length) return a.Length;
            else if (a.Length < b.Length) return b.Length;
            else if (a == b) return -1;
            return a.Length;
        }
    }
}
