using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneConstructor.Business
{
    public class Subset
    {
        private List<Line> _nomenclature = new List<Line>();
        private string _name;

        public List<Line> Nomenclature
        {
            get { return _nomenclature; }
            set { _nomenclature = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        /// <summary>
        /// Calcul the longest DO for the all subset
        /// </summary>
        /// <returns></returns>
        public int GetTheLongestDOSub()
        {
            throw new NotImplementedException();
            // 
        }

        /// <summary>
        /// Calcul the Cost for all the subset
        /// </summary>
        /// <returns></returns>
        public int GetTotalCostSub()
        {
            int cost = 0;
            foreach (Line l in Nomenclature)
            {
                cost += int.Parse(l.GetCompoCost()) * int.Parse(l.GetCoef());
            }

            return cost;
        }

        /// <summary>
        /// Calcul the Time needed to complete the work
        /// </summary>
        /// <returns></returns>
        public int GetTotalHourSub()
        {
            try
            {
                return int.Parse(Nomenclature[0].GetHourOfJob());
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
