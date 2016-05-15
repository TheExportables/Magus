using Magus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.ViewModel {
    class SkillViewModel {

        Skill skill;
        int value;
        int lvl;
        int modifier;
        int other;

        public SkillViewModel(Skill skill) {
            this.skill = skill;
            value = 0;
            lvl = 0;
            modifier = 0;
            other = 0;
        }

        public int Value {
            get { return value; }
        }
        public int Lvl {
            get { return lvl; }
            set {
                this.lvl = value;
                calculateValue();
            }
        }
        public int Modifier {
            get { return modifier; }
            set {
                this.modifier = value;
                calculateValue();
            }
        }
        public int Other {
            get { return other; }
            set {
                this.other = value;
                calculateValue();
            }
        }
        public Skill Skill { get; set; }
        private void calculateValue() {
            value = lvl + modifier + other;
        }

    }
}
