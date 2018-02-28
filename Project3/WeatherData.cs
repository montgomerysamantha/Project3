using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    public class WeatherData
    {
        // public DateTime _date { get; set; }
        private DateTime _date;
        public double _avgTemp { get; set; }


        public WeatherData(DateTime d, double avg)
        {
            _date = d;
            _avgTemp = avg;
        }

        public DateTime Date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Overrides ToString() so that the date
        /// can be displayed in a format like this:
        /// "Wednesday, May 16, 2001: 55.1 degrees"
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(_date.ToLongDateString());
            sb.Append(": " + _avgTemp + " °F");
            return sb.ToString();
        }

        public bool LessThanDate(DateTime d)
        {
            if (this._date < d) return true;
            return false;
        }

        public bool GreaterThanDate(DateTime d)
        {
            if (this._date > d) return true;
            return false;
        }
    }
}
