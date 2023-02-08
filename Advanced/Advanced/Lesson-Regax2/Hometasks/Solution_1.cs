namespace Advanced.Lesson_Regax.Lesson_Regax2.Hometasks
{
    internal class Solution_1
    {
        public static char FindTheDifference(string s, string t)
        {
            char[] charX1 = s.ToCharArray();
            char[] charX2 = t.ToCharArray();
            Array.Sort(charX1);
            Array.Sort(charX2);
            char str = charX2[charX2.Length- 1];
            for (int i = 0; i < charX1.Length; i++)
            {
                if (charX1[i] != charX2[i])
                {
                    str = charX2[i];
                    break;
                }
            }
            
            return str;
        }
    }
}
