using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Items {
    class Material {

        String name;

        int bonusWeaponAttackValue;
        int bonusWeaponDamage;

        int bonusArmorObjection;
        int bonusArmorDextirityModifier;
        int bonusArmorBlockValue;

        int bonusShieldDefenseValue;
        int bonusShieldAttackValue;
        int bonusShieldDamageValue;

        int weightPercentage;
        int priceMultiplier;
        bool isMagical;

        public Material() {
            name = "";
            bonusWeaponAttackValue = 0;
            bonusWeaponDamage = 0;
            bonusArmorObjection = 0;
            bonusArmorDextirityModifier = 0;
            bonusArmorBlockValue = 0;
            bonusShieldDefenseValue = 0;
            bonusShieldAttackValue = 0;
            bonusShieldDamageValue = 0;
            weightPercentage = 0;
            priceMultiplier = 1;
            isMagical = false;
        }

        public Material(String name, int bonusWeaponAttack, int bonusWeaponDamage,
            int bonusArmorObjection, int bonusArmorDextirityModifier, int bonusArmorBlockValue,
            int bonusShieldDefenseValue, int bonusShieldAttackValue, int bonusShieldDamageValue, 
            int wPercentage, int priceMulti, bool magical) {
            this.name = name;
            this.bonusWeaponAttackValue = bonusWeaponAttack;
            this.bonusWeaponDamage = bonusWeaponDamage;
            this.bonusArmorObjection = bonusArmorObjection;
            this.bonusArmorDextirityModifier = bonusArmorDextirityModifier;
            this.bonusArmorBlockValue = bonusArmorBlockValue;
            this.bonusShieldDefenseValue = bonusShieldDefenseValue;
            this.bonusShieldAttackValue = bonusShieldAttackValue;
            this.bonusShieldDamageValue = bonusShieldDamageValue;
            this.weightPercentage = wPercentage;
            this.priceMultiplier = priceMulti;
            this.isMagical = magical;
        }

        public String Name {
            get { return name; }
            set { name = value; }
        }

        public int BonusWeaponAttackValue {
            get { return bonusWeaponAttackValue; }
            set { bonusWeaponAttackValue = value; }
        }
        public int BonusWeaponDamage {
            get { return bonusWeaponDamage; }
            set { bonusWeaponDamage = value; }
        }

        public int BonusArmorObjection {
            get { return bonusArmorObjection; }
            set { bonusArmorObjection = value; }
        }
        public int BonusArmorDextirityModifier {
            get { return bonusArmorDextirityModifier; }
            set { bonusArmorDextirityModifier = value; }
        }
        public int BonusArmorBlockValue {
            get { return bonusArmorBlockValue; }
            set { bonusArmorBlockValue = value; }
        }

        public int BonusShieldDefenseValue {
            get { return bonusShieldDefenseValue; }
            set { bonusShieldDefenseValue = value; }
        }
        public int BonusShieldAttackValue {
            get { return bonusShieldAttackValue; }
            set { bonusShieldAttackValue = value; }
        }
        public int BonusShieldDamageValue {
            get { return bonusShieldDamageValue; }
            set { bonusShieldDamageValue = value; }
        }

        public int WeightPercentage {
            get { return weightPercentage; }
            set { weightPercentage = value; }
        }
        public int PriceMultiplier {
            get { return priceMultiplier; }
            set { priceMultiplier = value; }
        }
        public bool IsMagical {
            get { return isMagical; }
            set { isMagical = value; }
        }
    }
}
