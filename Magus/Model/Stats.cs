using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Stats {

        #region variables
        Stat strength;
        Stat dextirity;
        Stat endurance;
        Stat intellect;
        Stat willpower;
        Stat charism;

        int vitality;
        int agility;
        int wisdom;

        Hp hp;
        Fp fp;

        Resistance physicalResistance;
        Resistance mentalResistance;
        Resistance astralResistance;

        int initiativeValue;
        int defenseValue;
        int attackValue;
        #endregion

        #region constructros
        public Stats(){
            strength = new Stat(8);
            dextirity = new Stat(8);
            endurance = new Stat(8);
            intellect = new Stat(8);
            willpower = new Stat(8);
            charism = new Stat(8);
            vitality = 0;
            agility = 0;
            wisdom = 0;
            hp = new Hp();
            fp = new Fp();
            physicalResistance = new Resistance();
            mentalResistance = new Resistance();
            astralResistance = new Resistance();
            initiativeValue = 0;
            defenseValue = 0;
            attackValue = 0;
        }
        #endregion

        #region getters and setters
        public Stat Strength {
            get {
                return strength;
            }
            set {
                this.strength = value;
            }
        }
        public Stat Dextirity {
            get {
                return dextirity;
            }
            set {
                this.dextirity = value;
            }
        }
        public Stat Endurance {
            get {
                return endurance;
            }
            set {
                this.endurance = value;
                calculateHp();
                calculateFp();
                calculatePhysicalResistance();
            }
        }
        public Stat Intellect {
            get {
                return intellect;
            }
            set {
                this.intellect = value;
            }
        }
        public Stat Willpower {
            get {
                return willpower;
            }
            set {
                this.willpower = value;
                calculateMentalResistance();
            }
        }
        public Stat Charism {
            get {
                return charism;
            }
            set {
                this.charism = value;
                calculateAstralResistance();
            }
        }

        public int Vitality {
            get {
                return vitality;
            }
            set {
                this.vitality = value;
                calculateHp();
                calculatePhysicalResistance();
            }
        }
        public int Agility {
            get {
                return agility;
            }
            set {
                this.agility = value;
                calculateInitiativeValue();
                calculateDefenseValue();
            }
        }
        public int Wisdom {
            get {
                return wisdom;
            }
            set {
                this.wisdom = value;
                calculateAstralResistance();
                calculateMentalResistance();
            }
        }

        public Hp Hp { 
            get {
                return hp;
            }
            set {
                this.hp = value;
            }
        }
        public Fp Fp {
            get {
                return fp;
            }
            set {
                this.fp = value;
            }
        }

        public Resistance PhysicalResistance {
            get {
                return physicalResistance;
            }
            set {
                this.physicalResistance = value;
            }
        }
        public Resistance AstralResistnace {
            get {
                return astralResistance;
            }
            set {
                this.astralResistance = value;
            }
        }
        public Resistance MentalResistance {
            get {
                return mentalResistance;
            }
            set {
                this.mentalResistance = value;
            }
        }

        public int InitiativeValue {
            get { 
                return initiativeValue; 
            }
        }
        public int AttackValue {
            get {
                return attackValue;
            }
            set {
                this.attackValue = value;
            }
        }
        public int DefenseValue {
            get {
                return defenseValue;
            }
        }
        #endregion

        #region values calculation methods
        private void calculateInitiativeValue() {
            initiativeValue = agility + dextirity.Modifier;
        }

        private void calculateDefenseValue() {
            defenseValue = agility + dextirity.Modifier;
        }

        private void calculateHp() {
            hp = new Hp(10 + vitality + endurance.Modifier);
        }

        private void calculateFp() {
            fp = new Fp(fp.MaxFp+endurance.Modifier);
        }

        private void calculatePhysicalResistance() { 
            physicalResistance.DefValue = 10 + vitality + endurance.Modifier;
        }

        private void calculateAstralResistance() {
            astralResistance.DefValue = 10 + wisdom + charism.Modifier;
        }

        private void calculateMentalResistance() {
            mentalResistance.DefValue = 10 + wisdom + willpower.Modifier;
        }
        #endregion

        #region VM logic
        public void addShieldToDefense(Shield s) {
            defenseValue += s.DefenseValue;
        }

        public void removeShieldFromDefense(Shield s) {
            defenseValue -= s.DefenseValue;
        }
        #endregion
    }
}