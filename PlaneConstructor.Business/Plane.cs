using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneConstructor.Business
{
    public class Plane
    {
        private List<Subset> _subsetList = new List<Subset>();

        public List<Subset> SubsetList
        {
            get { return _subsetList; }
            set { _subsetList = value; }
        }


        /// <summary>
        /// Calcul the DO for the all plane
        /// </summary>
        /// <returns></returns>
        public int GetTheTotalDOPlane()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calcul the Cost for all the plane
        /// </summary>
        /// <returns></returns>
        public int GetTotalCostPlane()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Calcul the Time needed to complete the work
        /// </summary>
        /// <returns></returns>
        public int GetTotalHourPlane()
        {
            throw new NotImplementedException();
        }
    }
}
