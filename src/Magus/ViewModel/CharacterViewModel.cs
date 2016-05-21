using Magus.Data;
using Magus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.ViewModel {
    class CharacterViewModel : INotifyPropertyChanged{

        Character c;
        int availableLvlPoints;
        int index;
        ObservableCollection<CharacterClass> availableClassesForRace;

        public event PropertyChangedEventHandler PropertyChanged;

        public CharacterViewModel() {
            c = new Character();
            availableLvlPoints = 4;
            index = 0;
            availableClassesForRace = new ObservableCollection<CharacterClass>();
        }

        public void addCharacterClass(CharacterClass cc) {
            c.CharClasses.Add(new CharacterClassViewModel(cc));
            lvlUpClass(c.CharClasses.IndexOf(c.CharClasses.Where(charClass => charClass.CharClass.Equals(cc)).FirstOrDefault()));
        }

        public void addCharacterClass(AdventurerCharacterClass acc) {
            c.CharClasses.Add(new CharacterClassViewModel(acc));
            if (acc.School != null) {
                c.MagicSchools.Add(acc.School);
                foreach (var mastery in acc.School.SchoolMasteries) {
                    c.MagicalMasteries.Add(new MagicMasteryViewModel(mastery));
                    foreach (var spell in mastery.Spells) {
                        c.Spells.Add(spell);
                    }
                }
            }
            lvlUpClass(c.CharClasses.IndexOf(c.CharClasses.Where(cc => cc.CharClass.Equals(acc)).FirstOrDefault()));
        }

        public bool alreadyHasClass(CharacterClass charClass) {
            return c.CharClasses.Contains(c.CharClasses.Where(cc => cc.CharClass.Equals(charClass)).FirstOrDefault());
        }

        public void lvlUpClass(int index) {
            c.CharClasses.ElementAt(index).Lvl++;
            c.CharLvl++;
            if (c.CharLvl / 3 == 0 && c.CharLvl!=3)
                c.UnusedPp++;
            if (c.CharLvl / 4 == 0)
                c.UnusedBonusAttributePoints++;
            c.CharStats.Agility += c.CharClasses.ElementAt(index).getAgilityValue();
            c.CharStats.Vitality += c.CharClasses.ElementAt(index).getVitalityValue();
            c.CharStats.Wisdom += c.CharClasses.ElementAt(index).getWisdomValue();
            c.CharStats.AttackValue += c.CharClasses.ElementAt(index).getAttackValue();
            c.UnusedSp += c.CharClasses.ElementAt(index).CharClass.SpPerLvl + c.CharStats.Intellect.Modifier;
            foreach (var item in c.CharClasses.ElementAt(index).CharClass.FpPerLvl.generateValue()) {
                c.CharStats.Fp.increaseFp(item);
            }
            if (c.CharClasses.ElementAt(index).GetType() == typeof(AdventurerCharacterClass)) {
                AdventurerCharacterClass acc = c.CharClasses.ElementAt(index).CharClass as AdventurerCharacterClass;
                if (acc.School != null) {
                    if (acc.School.ManaPerLvl != 0) {
                        c.ManaPoints.increaseMp(acc.School.ManaPerLvl);
                        c.UnusedSpellPoints += 3;
                    }
                }
                foreach (var item in acc.ValuesPerLvl.ElementAt(c.CharClasses.ElementAt(index).Lvl - 1).Perks) {
                    // bound string could be a reference to a dependent resourceString in the future
                    if (item.Name.Equals("Képesség", StringComparison.InvariantCultureIgnoreCase))
                        c.UnusedPp++;
                    else
                        c.Perks.Add(item);
                }
            }
            calculateSkillLvl();
        }

        //check the race, and list classes available for that race
        public void getAvailableClassesForRace() {
            availableClassesForRace = new ObservableCollection<CharacterClass>();
            foreach (var charClass in DataManager.Classes) {
                if (charClass is AdventurerCharacterClass) {
                    if ((charClass as AdventurerCharacterClass).AvailableForRaces.Contains(c.CharRace.Name)) {
                        availableClassesForRace.Add(charClass);
                    }
                }
            }
        }

        public void setRace(Race race) {
            c.CharRace = race;
        }

        public void applyRaceModifiers() {
            c.CharStats.Strength.Value += c.CharRace.StrengthModifier;
            c.CharStats.Dextirity.Value += c.CharRace.DextirityModifier;
            c.CharStats.Endurance.Value += c.CharRace.EnduranceModifier;
            c.CharStats.Intellect.Value += c.CharRace.IntellectModifier;
            c.CharStats.Willpower.Value += c.CharRace.WillpowerModifier;
            c.CharStats.Charism.Value += c.CharRace.CharismModifier;
        }

        public void calculateSkillLvl() {
            c.MaxSkillLvl = c.CharLvl + 3;
        }

        #region Stat modifying
        public void increaseStrength() {
            c.CharStats.Strength.Value++;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Strength))
                    skill.Modifier = c.CharStats.Strength.Modifier;
            }
        }

        public void increaseDextirity() {
            c.CharStats.Dextirity.Value++;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Dextirity))
                    skill.Modifier = c.CharStats.Dextirity.Modifier;
            }
        }

        public void increaseEndurance() {
            c.CharStats.Endurance.Value++;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Endurance))
                    skill.Modifier = c.CharStats.Endurance.Modifier;
            }
        }

        public void increaseIntellect() {
            c.CharStats.Intellect.Value++;
            c.PsiPoints.increasePsi(getPsiMultiplier());
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Intellect))
                    skill.Modifier = c.CharStats.Intellect.Modifier;
            }
        }

        public void increaseWillpower() {
            c.CharStats.Willpower.Value++;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Willpower))
                    skill.Modifier = c.CharStats.Willpower.Modifier;
            }
        }

        public void increaseCharism() {
            c.CharStats.Charism.Value++;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Charism))
                    skill.Modifier = c.CharStats.Charism.Modifier;
            }
        }

        public void decreaseStrength() {
            c.CharStats.Strength.Value--;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Strength))
                    skill.Modifier = c.CharStats.Strength.Modifier;
            }
        }

        public void decreaseDextirity() {
            c.CharStats.Dextirity.Value--;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Dextirity))
                    skill.Modifier = c.CharStats.Dextirity.Modifier;
            }
        }

        public void decreaseEndurance() {
            c.CharStats.Endurance.Value--;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Endurance))
                    skill.Modifier = c.CharStats.Endurance.Modifier;
            }
        }

        public void decreaseIntellect() {
            c.CharStats.Intellect.Value--;
            c.PsiPoints.decreasePsi(getPsiMultiplier());
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Intellect))
                    skill.Modifier = c.CharStats.Intellect.Modifier;
            }
        }

        public void decreaseWillpower() {
            c.CharStats.Willpower.Value--;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Willpower))
                    skill.Modifier = c.CharStats.Willpower.Modifier;
            }
        }

        public void decreaseCharism() {
            c.CharStats.Charism.Value--;
            foreach (var skill in c.Skills) {
                if (skill.Skill.Dependency.Equals(StatDependency.Charism))
                    skill.Modifier = c.CharStats.Charism.Modifier;
            }
        }
        #endregion

        public int getPsiMultiplier() {
            int multiplier = 0;
            foreach (var charclass in c.CharClasses) {
                if(charclass.GetType().Equals(typeof(AdventurerCharacterClass))){
                    AdventurerCharacterClass acc = charclass.CharClass as AdventurerCharacterClass;
                    if(acc.School != null){
                        if(acc.School.PsiMultiplier > multiplier)
                            multiplier = acc.School.PsiMultiplier;
                    }
                }
            }
            return multiplier;
        }

        public void rename(String name) {
            c.Name = name;
        }

        public void changeReligion(String religion) {
            c.Religion = religion;
        }

        public void setBirthplace(String place) {
            c.BirthPlace = place;
        }

        public void setGender(String gender) {
            c.Gender = gender;
        }

        public void setAge(int age) {
            c.Age = age;
        }

        public void setCharacterSize(CharacterSize size) {
            c.Size = size;
        }

        public void setCharacteristic1(Characteristic characteristic) {
            c.C1 = characteristic;
        }

        public List<Characteristic> getCharacteristics() {
            List<Characteristic> list = new List<Characteristic>();
            list.Add(Characteristic.Káosz);
            list.Add(Characteristic.Halál);
            list.Add(Characteristic.Élet);
            list.Add(Characteristic.Rend);
            return list;
        }

        public List<Characteristic> availableCharacteristicFor2() {
            List<Characteristic> list = new List<Characteristic>();
            switch (c.C1) { 
                case Characteristic.Káosz:
                    list.Add(Characteristic.Halál);
                    list.Add(Characteristic.Élet);
                    break;
                case Characteristic.Halál:
                    list.Add(Characteristic.Káosz);
                    list.Add(Characteristic.Rend);
                    break;
                case Characteristic.Élet:
                    list.Add(Characteristic.Káosz);
                    list.Add(Characteristic.Rend);
                    break;
                case Characteristic.Rend:
                    list.Add(Characteristic.Élet);
                    list.Add(Characteristic.Halál);
                    break;
            }
            list.Add(Characteristic.Üres);
            return list;
        }

        public void setCharacteristic2(Characteristic characteristic) {
            c.C2 = characteristic;
        }

        public void addReputation(string location, int value) {
            int i = c.Reputations.IndexOf(c.Reputations.Where(r => r.CityName.Equals(location, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault());
            if (i == -1) {
                Reputation r = new Reputation();
                r.CityName = location;
                r.ReputationLvl = value;
            } else {
                c.Reputations.ElementAt(i).ReputationLvl += value;
            }
        }

        public void learnSkill(Skill s) {
            c.Skills.Add(new SkillViewModel(s));
        }

        public bool increaseSkillLvl(int index, int amount) {
            // TODO PSI
            if (c.Skills.ElementAt(index).Lvl + amount <= c.MaxSkillLvl) {
                c.Skills.ElementAt(index).Lvl += amount;
                return true;
            } else
                return false;
        }

        public void addOtherModifierToSkillValue(int index, int mod) {
            c.Skills.ElementAt(index).Other = mod;
        }

        public void learnPerk(Perk perk) {
            c.Perks.Add(perk);
        }

        public bool canLearnPerk(Perk perk) {
            if(c.Perks.Contains(perk))
                return false;
            foreach (var skillReq in perk.SkillRequirements) {
                int i = c.Skills.IndexOf(c.Skills.Where(s => s.Skill.Name.Equals(skillReq.RequiredSkill.Name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault());
                if (i == -1) {
                    return false;
                } else if (c.Skills.ElementAt(i).Value < skillReq.MinLvl) {
                    return false;
                }
            }
            foreach (var p in perk.PerkRequirements) {
                if (!c.Perks.Contains(p))
                    return false;
            }
            return true;
        }

        public List<Perk> getAvailablePerks() {
            List<Perk> list = new List<Perk>();
            foreach (var perk in DataManager.Perks) {
                if(canLearnPerk(perk)){
                    list.Add(perk);
                }
            }
            return list;
        }

        public void addLanguage(String language) {
            c.Languages.Add(language);
        }

        public void addWeapon(Weapon weapon) {
            c.Weapons.Add(weapon);
        }

        public int getAttackValueWithWeapon(int index) { 
            switch(c.Weapons.ElementAt(index).HandlingAttribute){
                case WeaponHandlingAttribute.FromDextirity:
                    return c.CharStats.Dextirity.Modifier + c.CharStats.AttackValue;
                case WeaponHandlingAttribute.FromStrength:
                    return c.CharStats.Strength.Modifier + c.CharStats.AttackValue;
                case WeaponHandlingAttribute.FromStrengthAndDextirity:
                    int strMod = c.CharStats.Strength.Modifier;
                    int dexMod = c.CharStats.Dextirity.Modifier;
                    int attackVal = c.CharStats.AttackValue;
                    return strMod > dexMod ? strMod + attackVal : dexMod + attackVal;
            }
            return 0;
        }

        public List<int> getDamageWithWeapon(int index) {
            return c.Weapons.ElementAt(index).Damage.generateValue();
        }

        public Cash weaponSellValue(int index) {
            return c.Weapons.ElementAt(index).Cost;
        }

        public void sellWeapon(int index) {
            Cash cash = weaponSellValue(index);
            c.Weapons.RemoveAt(index);
            c.CharCash.CopperAmount += cash.convertToCopper();
        }

        public void equipShield() {
            c.CharStats.addShieldToDefense(c.EquippedShield);
        }

        public void removeShield() {
            c.CharStats.removeShieldFromDefense(c.EquippedShield);
        }

        public bool gotAttacked(int attackValue, int damage) {
            if (c.CharStats.DefenseValue > attackValue) {
                return false;
            }
            if (c.EquippedArmor != null) {
                damage -= c.EquippedArmor.BlockValue;
                if (damage <= 0)
                    return false;
            }
            if (c.CharStats.DefenseValue < attackValue && c.CharStats.DefenseValue + 15 > attackValue) {
                c.CharStats.Fp.sufferDamage(damage);
                c.CharStats.Hp.sufferDamage(damage / 10);
                return true;
            } else {
                c.CharStats.Hp.sufferDamage(damage);
                c.CharStats.Fp.sufferDamage(damage * 2);
                return true;
            }
        }

        public void healHp(int amount) {
            c.CharStats.Hp.heal(amount);
        }

        public void healFp(int amount) {
            c.CharStats.Fp.heal(amount);
        }

        public void increaseHp(int amount) {
            c.CharStats.Hp.increaseHp(amount);
        }

        public void increaseFp(int amount) {
            c.CharStats.Fp.increaseFp(amount);
        }

        public void decreaseHp(int amount) {
            c.CharStats.Hp.decreaseHp(amount);
        }

        public void decreaseFp(int amount) {
            c.CharStats.Fp.decreaseFp(amount);
        }

        public Item getItem(int index) {
            return c.Inventory.ElementAt(index);
        }

        public bool buyItem(Item item) {
            if (c.CharCash.convertToCopper() > item.Cost.convertToCopper()) {
                c.Inventory.Add(item);
                Cash temp = new Cash();
                temp.CopperAmount = c.CharCash.convertToCopper();
                c.CharCash = new Cash();
                c.CharCash.CopperAmount = temp.convertToCopper() - item.Cost.convertToCopper();
                return true;
            } else
                return false;              
        }

        public Cash itemSellValue(int index) {
            return c.Inventory.ElementAt(index).Cost;
        }

        public void sellItem(int index) {
            Cash cash = itemSellValue(index);
            c.Inventory.RemoveAt(index);
            c.CharCash.CopperAmount += cash.convertToCopper();
        }

        public bool spellHadEffect(Spell spell) {
            switch (spell.AttackAgaints) { 
                case ResistanceType.Physical:
                    if (c.CharStats.PhysicalResistance.Value > spell.Str)
                        return false;
                    else
                        return true;
                case ResistanceType.Astral:
                    if (c.CharStats.AstralResistnace.Value > spell.Str)
                        return false;
                    else
                        return true;
                case ResistanceType.Mental:
                    if (c.CharStats.MentalResistance.Value > spell.Str)
                        return false;
                    else
                        return true;
                default:
                    return true;
            }
        }

        public bool canCastMagicSpell(MagicSpell spell) {
            if (spell.UsesPsi) {
                if (c.PsiPoints.CurrPsi > spell.Str * spell.CostPerStr)
                    return true;
                else
                    return false;
            } else if (c.ManaPoints.CurrMp > spell.Str * spell.CostPerStr)
                return true;
            else
                return false;
        }

        public bool canCastPriestSpell(PriestSpell spell) {
            int actualCost = calculatePriestSpellCost(spell);
            if (c.Faith > actualCost) {
                return true;
            } else
                return false;
        }

        public int calculatePriestSpellCost(PriestSpell spell) {
            int actualCost = spell.Faith;
            foreach (var sphere in spell.GreaterSupporters) {
                if (c.GreaterSpheres.Contains(sphere))
                    actualCost -= 5;
            }
            foreach (var sphere in spell.SmallerSupporters) {
                if (c.SmallerSpheres.Contains(sphere))
                    actualCost -= 10;
            }
            foreach (var sphere in spell.Oppositional) {
                if (c.GreaterSpheres.Contains(sphere))
                    actualCost += 5;
            }
            return actualCost;
        }

        public void castSpell(Spell spell, CharacterViewModel target) {
            if (spell.GetType() == typeof(MagicSpell)) {
                MagicSpell ms = spell as MagicSpell;
                if (canCastMagicSpell(ms)) {
                    if (ms.UsesPsi) {
                        c.PsiPoints.useDiscipline(ms.CostPerStr * ms.Str);
                        target.spellHadEffect(ms);
                    } else {
                        c.ManaPoints.castSpell(ms.CostPerStr * ms.Str);
                        target.spellHadEffect(ms);
                    }
                }
            } else if (spell.GetType() == typeof(PriestSpell)) {
                PriestSpell ps = spell as PriestSpell;
                if (canCastPriestSpell(ps)) {
                    c.Faith -= calculatePriestSpellCost(ps);
                    if (c.Faith < 0)
                        c.Faith = 0;
                    target.spellHadEffect(ps);
                }
            }
        }

        public void increaseMana(int amount) {
            c.ManaPoints.increaseMp(amount);
        }

        public void decreaseMana(int amount) {
            c.ManaPoints.decreaseMp(amount);
        }

        public void chargeMana(int amount) {
            c.ManaPoints.chargeMana(amount);
        }

        public void increasePsi(int amount) {
            c.PsiPoints.increasePsi(amount);
        }

        public void decreasePsi(int amount) {
            c.PsiPoints.decreasePsi(amount);
        }

        public void meditatePsi(int amount) { 
            c.PsiPoints.meditate(amount);
        }

        public void sayPrayer(int amount) {
            c.Faith += amount;
        }

        public void forgotPrayer(int amount) {
            c.Faith -= amount;
            if (c.Faith < 0)
                c.Faith = 0;
        }

        public void lvlUpMagicMastery(int index) {
            c.MagicalMasteries.ElementAt(index).Lvl++;
        }

        public int getSpellsMaxStrength(Spell spell) {
            foreach (var masteries in c.MagicalMasteries) {
                if (masteries.mastery.Spells.Contains(spell))
                    return masteries.Lvl;
            }
            return 0;
        }

        public CharacterClass getCharacterClass(int index) {
            return c.CharClasses.ElementAt(index).CharClass;
        }

        public ObservableCollection<CharacterClassViewModel> getCharacterClasses() {
            return c.CharClasses;
        }

        #region getters
        public Race getRace() {
            return c.CharRace;
        }

        public Stats getStats() {
            return c.CharStats;
        }

        public String getName() {
            return c.Name;
        }

        public String getReligion() {
            return c.Religion;
        }

        public String getBirthPlace() {
            return c.BirthPlace;
        }

        public String getGender() {
            return c.Gender;
        }

        public int getAge() {
            return c.Age;
        }

        public CharacterSize getSize() {
            return c.Size;
        }

        public Characteristic getC1() {
            return c.C1;
        }

        public Characteristic getC2() {
            return c.C2;
        }

        public int getCharLvl() {
            return c.CharLvl;
        }

        public int getMaxSkillLvl() {
            return c.MaxSkillLvl;
        }

        public ObservableCollection<Reputation> getReputations() {
            return c.Reputations;
        }

        public ObservableCollection<SkillViewModel> getSkills() {
            return c.Skills;
        }

        public ObservableCollection<Perk> getPerks() {
            return c.Perks;
        }

        public ObservableCollection<String> getLanguages() {
            return c.Languages;
        }

        public ObservableCollection<Weapon> getWeapons() {
            return c.Weapons;
        }

        public Weapon getWeapon(int index) {
            return c.Weapons.ElementAt(index);
        }

        public Shield getShield() {
            return c.EquippedShield;
        }

        public Armor getArmor() {
            return c.EquippedArmor;
        }

        public ObservableCollection<Item> getInventory() {
            return c.Inventory;
        }
        
        public Cash getCash() {
            return c.CharCash;
        }

        public ObservableCollection<Spell> getSpells() {
            return c.Spells;
        }

        public Spell getSpell(int index) {
            return c.Spells.ElementAt(index);
        }

        public Mana getManaPoints() {
            return c.ManaPoints;
        }

        public Psi getPsiPoints() {
            return c.PsiPoints;
        }

        public int getFaith() {
            return c.Faith;
        }
        public int getUnusedSp() {
            return c.UnusedSp;
        }

        public int getUnusedPp() {
            return c.UnusedPp;
        }

        public int getUnusedAttributePoints() {
            return c.UnusedAttributePoints;
        }

        public int getUnusedSpellPoints() {
            return c.UnusedSpellPoints;
        }

        public int getUnusedBonusPoints() {
            return c.UnusedBonusAttributePoints;
        }

        public ObservableCollection<MagicMasteryViewModel> getMagicalMasteries() {
            return c.MagicalMasteries;
        }

        public ObservableCollection<MagicSchool> getMagicSchools() {
            return c.MagicSchools;
        }

        public int AvailableLvlPoints {
            get { return availableLvlPoints; }
            set { 
                availableLvlPoints = value;
                OnPropertyChanged("AvailableLvlPoints");
            }
        }

        public Character GetCharacter {
            get { return c; }
            set {
                this.c = value;
                OnPropertyChanged("GetCharacter");
            }
        }

        public int Index {
            get { return index; }
            set {
                this.index = value;
                OnPropertyChanged("Index");
            }
        }

        public DataManager Manager {
            get { return DataManager.Instance; }
        }

        public ObservableCollection<CharacterClass> AvailableClassesForRace {
            get { return availableClassesForRace; }
        }

        public List<Characteristic> Characteristics {
            get { return getCharacteristics(); }
        }
        #endregion

        protected void OnPropertyChanged(string name) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}