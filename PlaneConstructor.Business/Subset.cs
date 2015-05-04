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
        private int _maxLevel;

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
        /// Get maximum level for the Subset
        /// </summary>
        /// <returns>int MaxLevel</returns>
        public int GetMaxLevel()
        {         
                int _maxLevel = 0;
                foreach (Line l in Nomenclature)
                {
                    if( l.Level > _maxLevel)
                    {
                        _maxLevel = l.Level;
                    }
                }
                return _maxLevel;
        }

        /// <summary>
        /// Calcul the longest DO for the all subset
        /// </summary>
        /// <returns>int TotalDO</returns>
        public int GetTheLongestDOSub()
        {
            //throw new NotImplementedException();
            int TotalDO = 0;

            for(int i = 3; i <= this.GetMaxLevel(); i++)
            {
                int currentDO = 0;
                IEnumerable<Line> LvlQuery =
                from l in Nomenclature
                where l.Level == i
                select l;
                
                foreach(Line li in LvlQuery)
                {
                    if(li.DO > currentDO)
                    {
                        currentDO = li.DO;
                    }
                }
                TotalDO += currentDO;

            }         
            return TotalDO;
        }

        /// <summary>
        /// Calcul the Cost for all the subset
        /// </summary>
        /// <returns> double SubsetCost </returns>
        public double GetTotalCostSub()
        {
            double lineTotalCost=0;
            double subsetTotalCost=0;
            int Hours = 100;
            foreach( Line li in Nomenclature)
            {
                // Si ce n'est pas un sous ensemble
                if(li.CompoCost != 0)
                {
                    lineTotalCost = li.CompoCost * li.Coef;
                }
                //Si c'est un sous ensemble
                else
                {
                    lineTotalCost = li.Coef * li.HourOfJob * Hours;
                }
                subsetTotalCost += lineTotalCost;
            }
            return subsetTotalCost;
        }

        /// <summary>
        /// Calcul the Time needed to complete the work
        /// </summary>
        /// <returns>int totalHour</returns>
        public int GetTotalHourSub()
        {           
            int totalHour=0;

            IEnumerable<Line> HourQuery =
               from l in Nomenclature
               where l.HourOfJob != 0
               select l;

            foreach (Line li in HourQuery)
            {
                totalHour += li.HourOfJob * (int)li.Coef;
            }
            return totalHour;
        }
    }
}
