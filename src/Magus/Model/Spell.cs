using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Spell {

        String name;
        int duration;
        String range;
        int castTime;
        String affects;
        ResistanceType attackAgaints;
        int str;

        public Spell() {
            name = null;
            duration = 0;
            range = null;
            castTime = 0;
            affects = null;
            attackAgaints = ResistanceType.None;
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public int Duration {
            get { return duration; }
            set { this.duration = value; }
        }
        public String Range {
            get { return range; }
            set { this.range = value; }
        }
        public int CastTime {
            get { return castTime; }
            set { this.castTime = value; }
        }
        public String Affects {
            get { return affects; }
            set { this.affects = value; }
        }
        public ResistanceType AttackAgaints {
            get { return attackAgaints; }
            set { this.attackAgaints = value; }
        }
        public int Str {
            get { return str; }
            set { this.str = value; }
        }
    }
}