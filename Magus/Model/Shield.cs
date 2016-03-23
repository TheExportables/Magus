using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Shield : Item {

        int defenseValue;

        public Shield() : base() {
            weight = 0;
            defenseValue = 0;
        }

        public int DefenseValue {
            get {
                return defenseValue;
            }
            set {
                this.defenseValue = value;
            }
        }
    }
}