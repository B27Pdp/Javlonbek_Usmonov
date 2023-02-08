namespace Advanced.Lesson_Regax2.Hometasks
{
    internal class Solution_4
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            List<string> morse = new() { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            Dictionary<string, string> dic = new Dictionary<string, string>();
            string alpha = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] letters = alpha.Split(',');
            for (int i = 0; i < letters.Length; i++)
            {
                dic.Add(letters[i], morse[i]);

            }
            List<string> morses = new();
            foreach (string word in words)
            {
                string str = "";
                for (int i = 0; i < word.Length; i++)
                {
                    str += dic[Convert.ToString(word[i])];

                }

                morses.Add(str);
            }

            HashSet<string> hashset = new HashSet<string>(morses);
            return hashset.Count;
        }
    }
}
