using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Reputation {

        String cityName;
        int reputationLvl;

        public Reputation() {
            cityName = null;
            reputationLvl = 0;
        }

        public Reputation(String cityName, int repuLvl) {
            this.cityName = cityName;
            this.reputationLvl = repuLvl;
        }

        public String CityName {
            get { return cityName; }
            set { this.cityName = value; }
        }

        public int ReputationLvl {
            get { return reputationLvl; }
            set { this.reputationLvl = value; }
        }
    }
}