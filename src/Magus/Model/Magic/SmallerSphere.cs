using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Magic {
    class SmallerSphere : GreaterSphere{

        List<GiftOfGods> gifts;

        public SmallerSphere() : base() {
            gifts = new List<GiftOfGods>();
        }

        public SmallerSphere(String name, List<Skill> ps, List<Perk> p, List<GiftOfGods> g) : base(name, ps, p) {
            gifts = g;
        }

        public List<GiftOfGods> Gifts { 
            get { return this.gifts; }
            set { this.gifts = value; } 
        }

    }
}
