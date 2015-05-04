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

        public Line()
        {

        }

        #region getter
        public int Level
        {
            get
            {
                int i = TryToParse(_lineInformation[0]);
                return i;
            }
        }

        public int Art
        {
            get
            {
                int i = TryToParse(_lineInformation[1]);
                return i;
            }
        }

        public string Ref
        {
            get { return _lineInformation[2]; }
        }

        public string Designation
        {
            get { return _lineInformation[3];}
        }

        public double Coef
        {
            get
            {
                try
                {
                    return Double.Parse(_lineInformation[4]);
                }
                catch (FormatException)
                {
                    throw new FormatException("Il existe une erreur dans le fichier Excel, un nombre est attendu");
                }
            }
        }

        public string Unity
        {
            get { return _lineInformation[5]; }
        }

        public int DO
        {
            get
            {
                int i = TryToParse(_lineInformation[6]);
                return i;
            }
        }

        public int CompoCost
        {
            get
            {
                int i = TryToParse(_lineInformation[7]);
                return i;
            }
        }

        public int HourOfJob
        {
            get
            {
                int i = TryToParse(_lineInformation[8]);
                return i;
            }
        }
        #endregion

        public int TryToParse(string value)
        {
            int number;
            bool result = Int32.TryParse(value, out number);
            if (result)
            {
                return number;
            }
            else
            {
                throw new FormatException("Il existe une erreure dans el fichier Excel, un nombre est attendu");
            }
        }
    }
}
