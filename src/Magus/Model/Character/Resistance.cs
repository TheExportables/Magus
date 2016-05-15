using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Resistance {
        int value;
        int defValue;
        int psiShield;
        ResistanceType type;

        public Resistance() {
            this.defValue = 0;
            this.psiShield = 0;
            this.value = defValue + psiShield;
            type = ResistanceType.None;
        }

        public Resistance(int defVal) {
            this.defValue = defVal;
            this.psiShield = 0;
            this.value = this.defValue + this.psiShield;
            type = ResistanceType.None;
        }

        public Resistance(int defVal, int psiShield) {
            this.defValue = defVal;
            this.psiShield = psiShield;
            this.value = this.defValue + this.psiShield;
            type = ResistanceType.None;
        }

        private void calculateValue() {
            this.value = defValue + psiShield;
        }

        public int Value {
            get {
                return value;
            }
        }

        public int DefValue {
            get {
                return defValue;
            }
            set {
                this.defValue = value;
                calculateValue();
            }
        }

        public int PsiShield {
            get {
                return psiShield;
            }
            set {
                this.psiShield = value;
                calculateValue();
            }
        }

        public ResistanceType Type {
            get { return type; }
            set { this.type = value; }
        }
    }
}