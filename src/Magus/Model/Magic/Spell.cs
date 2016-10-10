using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    abstract class Spell {

        String name;
        String description;
        int duration;
        String range;
        int castTime;
        String affects;
        ResistanceType attackAgaints;
        int str;

        public Spell() {
            name = "";
            description = "";
            duration = 0;
            range = "";
            castTime = 0;
            affects = "";
            attackAgaints = ResistanceType.None;
            str = 0;
        }

        public Spell(String name, String description, int duration, String range, int castTime, String affects, ResistanceType rtype, int str) {
            this.name = name;
            this.description = description;
            this.duration = duration;
            this.range = range;
            this.castTime = castTime;
            this.affects = affects;
            this.attackAgaints = rtype;
            this.str = str;
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { description = value; }
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