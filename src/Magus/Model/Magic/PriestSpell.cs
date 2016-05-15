using Magus.Model.Magic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class PriestSpell : Spell {

        int faith;
        List<GreaterSphere> greaterSupporters;
        List<SmallerSphere> smallerSupporters;
        List<GreaterSphere> oppositional;

        public PriestSpell() : base() {
            faith = 0;
            greaterSupporters = new List<GreaterSphere>();
            oppositional = new List<GreaterSphere>();
            smallerSupporters = new List<SmallerSphere>();
        }

        public PriestSpell(String name, String description, int duration, String range, int castTime, String affects, ResistanceType rtype, int str, int faith, List<GreaterSphere> gSupport, List<GreaterSphere> oppose, List<SmallerSphere> sSupport) : base(name, description, duration, range, castTime, affects, rtype, str) {
            this.greaterSupporters = gSupport;
            this.smallerSupporters = sSupport;
            this.oppositional = oppose;
        }

        public int Faith {
            get { return faith; }
            set { this.faith = value; }
        }
        public List<GreaterSphere> GreaterSupporters {
            get { return greaterSupporters; }
            set { this.greaterSupporters = value; }
        }
        public List<GreaterSphere> Oppositional {
            get { return oppositional; }
            set { this.oppositional = value; }
        }
        public List<SmallerSphere> SmallerSupporters {
            get { return smallerSupporters; }
            set { this.smallerSupporters = value; }
        }
    }
}