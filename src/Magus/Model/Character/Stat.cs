using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Stat {
        int value;
        int modifier;

        public Stat() {
            this.value = 0;
            this.modifier = 0;
        }

        public Stat(int value) {
            this.value = value;
            calculateModifier();
        }

        public int Value {
            get {
                return value;
            }
            set {
                this.value = value;
                calculateModifier();
            } 
        }

        public int Modifier {
            get {
                return modifier;
            }
        }

        private void calculateModifier() {
            this.modifier = (value - 10)/2;
        }
    }
}