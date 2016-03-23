using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Range {

        int minRange;
        int maxRange;

        public Range() {
            minRange = 0;
            maxRange = 0;
        }

        public int MinRange { 
            get { return minRange; } 
            set { this.minRange = value; } 
        }
        public int MaxRange {
            get { return maxRange; }
            set { this.maxRange = value; }
        }
    }
}