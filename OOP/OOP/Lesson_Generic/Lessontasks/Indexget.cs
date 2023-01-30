namespace OOP.Lesson_Generic.Lessontasks
{
    public class Indexget
    {
        private List<string> list = new List<string>(4);

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "903409342": return "Javlon";
                    case "334480718": return "Jaxon";
                    case "900537879": return "Laziz";
                    case "900223220": return "Asad";
                    default: throw new Exception("Unknown Property Name");
                }
            }
            set
            {
                switch (propname)
                {
                    case "903409342":
                        {
                            list[0] = value; 
                            break;
                        }
                    case "334480718":
                        {
                            list[1] = value; 
                            break;
                        }
                    case "900537879":
                        {
                            list[2] = value; 
                            break;
                        }
                    case "900223220":
                        {
                            list[3] = value; 
                            break;
                        }

                }
            }
        }
    }
}
