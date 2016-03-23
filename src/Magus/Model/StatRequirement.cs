using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class StatRequirement {

        StatDependency requiredStat;
        int minLvl;

        public StatRequirement() {
            minLvl = 0;
        }

        public StatRequirement(StatDependency stat, int minLvl) {
            this.requiredStat = stat;
            this.minLvl = minLvl;
        }

        public StatDependency RequiredStat {
            get { return requiredStat; }
            set { this.requiredStat = value; }
        }
        public int MinLvl {
            get { return minLvl; }
            set { this.minLvl = value; }
        }

    }
}