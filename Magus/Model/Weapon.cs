using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Weapon : Item {

        WeaponCategory category;
        WeaponHandlingAttribute handlingAttribute;
        DiceValue damage;
        int speed;
        WeaponSize size;
        Range wepRange;

        public Weapon() : base() {
            this.damage = null;
            this.wepRange = null;
            this.speed = 0;
        }

        public WeaponCategory Category {
            get { return category; }
            set { this.category = value; }
        }
        public WeaponHandlingAttribute HandlingAttribute {
            get { return handlingAttribute; }
            set { this.handlingAttribute = value; }
        }
        public DiceValue Damage {
            get { return damage; }
            set { this.damage = value; }
        }
        public int Speed {
            get { return speed; }
            set { this.speed = value; }
        }
        public WeaponSize Size {
            get { return size; }
            set { this.size = value; }
        }
        public Range WepRange {
            get { return wepRange; }
            set { this.wepRange = value; }
        }

        #region future VM logic
        public List<int> generateDamage() {
            return damage.generateValue();
        }
        #endregion
    }
}