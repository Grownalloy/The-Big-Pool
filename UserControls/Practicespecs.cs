using System.Web;

namespace The_Big_Pool.UserControls
{
    internal class Practicespecs
    {
        int distance = 1000;
        string skil_lvl = "Garnet";
        string duration = "8:00:00";
        string categories = "Freestyle";
       public Practicespecs(int d, string s, string t, string c)
        {
            distance = (d + 24) / 25 * 25;

            skil_lvl = s;

            duration = t;

            categories = c;

        }
        public int Distance
        {
            get { return distance; }
            set { distance = (value + 24) / 25 * 25; }
        }

        public string SkilLevel
        {
            get { return skil_lvl; }
            set { skil_lvl = value; }
        }

        public string Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public string Categories
        {
            get { return categories; }
            set { categories = value; }
        }

        public int warmup()
        {
            int warmup = ((distance/5) + 24) / 25 * 25;
            
            return warmup;
        }
        public int mainset()
        {
            double m = (distance-warmup()) * .85;
            int mainset = ((int)m + 24) / 25 * 25;
      
            return mainset;
        }
        public int warmdown()
        {
            return (distance-warmup()-mainset());
        }
      public  string finaldist()
        {
            int dist = warmup() + mainset() + warmdown();
            return dist.ToString();
        }
    }
}
