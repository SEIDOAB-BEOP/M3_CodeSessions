using System;
using Helpers;

namespace _06_embedded_list
{
    #region Necklace using Pearl as a class
    public class csNecklace
	{
        public List<csPearl> ListOfPearls { get; set; } = new List<csPearl>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfPearls)
            {
                sRet += $"\n{item}";
            }
            return sRet;
        }

        public csNecklace(int nrPearls, string name)
		{
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrPearls; i++)
            {
                ListOfPearls.Add(new csPearl(rnd));
            }
        }
	}
    #endregion

    #region Necklace using Pearl as a record
    public class csNecklace1
    {
        public List<rePearl> ListOfPearls { get; set; } = new List<rePearl>();
        public string Name { get; set; }

        public override string ToString()
        {
            string sRet = $"\n{Name}:";
            foreach (var item in ListOfPearls)
            {
                sRet += $"\n{item}";
            }
            return sRet;
        }

        public csNecklace1(int nrPearls, string name)
        {
            Name = name;
            var rnd = new csSeedGenerator();
            for (int i = 0; i < nrPearls; i++)
            {
                ListOfPearls.Add(new rePearl(rnd));
            }
        }
    }
    #endregion
}

