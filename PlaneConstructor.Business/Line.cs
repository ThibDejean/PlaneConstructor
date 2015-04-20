using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneConstructor.Business
{
    public class Line
    {
        
        private List<string> _lineInformation = new List<string>();

        public List<string> LineInformation
        {
            get { return _lineInformation; }
            set { _lineInformation = value; }
        }

        #region get infos ...
        public string GetLevel()
        {
            return _lineInformation[0];
        }

        public string GetArt()
        {
            return _lineInformation[1];
        }

        public string GetRef()
        {
            return _lineInformation[2];
        }

        public string GetDesignation()
        {
            return _lineInformation[3];
        }

        public string GetCoef()
        {
            return _lineInformation[4];
        }

        public string GetUnity()
        {
            return _lineInformation[5];
        }

        public string GetDO()
        {
            return _lineInformation[6];
        }

        public string GetCompoCost()
        {
            return _lineInformation[7];
        }

        public string GetHourOfJob()
        {
            return _lineInformation[8];
        }
        #endregion

    }
}
