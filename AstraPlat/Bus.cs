using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AstraPlat
{
    public class Bus
    {
        private string _cityBus;
        private string _outCityBus;
        private string _expressBus;
        public string CityBus
        {
            get
            {
                string result = "Городской автобус";
                return result;
            }
            set
            {
                _cityBus = value;
            }
        }
        public string ExpressBus
        {
            get
            {
                string result = "Экспресс автобус";
                return result;
            }
            set
            {
                _expressBus = value;
            }
        }
        public string OutCityBus
        {
            get
            {
                string result = "Загородный автобус";
                return result;
            }
            set
            {
                _outCityBus = value;
            }
        }
    }


}
