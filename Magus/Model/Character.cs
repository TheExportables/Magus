using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Character {

        #region variables
        ObservableCollection<CharacterClass> charClasses;
        Race charRace;
        Stats charStats;
        String name;
        String religion;
        String birthPlace;
        String gender;
        int age;
        CharacterSize size;
        Characteristic c1;
        Characteristic c2;
        int charLvl;
        int maxSkillLvl;
        ObservableCollection<Reputation> reputations;
        ObservableCollection<Skill> skills;
        ObservableCollection<Perk> perks;
        ObservableCollection<String> languages;
        ObservableCollection<Weapon> weapons;
        Shield equippedShield = null;
        Armor equippedArmor = null;
        ObservableCollection<Item> inventory;
        Cash charCash;
        ObservableCollection<Spell> spells;
        Mana manaPoints;
        Psi psiPoints;
        int faith;
        int unusedSp;
        int unusedPp;
        int unusedAttributePoints;
        int unusedSpellPoints;
        Boolean usedJoker;
        ObservableCollection<MagicMastery> magicalMasteries;
        ObservableCollection<MagicSchool> magicSchools;
        #endregion

        #region constructors
        public Character() {
            charClasses = new ObservableCollection<CharacterClass>();
            charRace = new Race();
            charStats = new Stats();
            name = null;
            religion = null;
            birthPlace = null;
            gender = null;
            age = 0;
            charLvl = 0;
            reputations = new ObservableCollection<Reputation>();
            skills = new ObservableCollection<Skill>();
            perks = new ObservableCollection<Perk>();
            languages = new ObservableCollection<String>();
            weapons = new ObservableCollection<Weapon>();
            inventory = new ObservableCollection<Item>();
            charCash = new Cash();
            spells = new ObservableCollection<Spell>();
            manaPoints = new Mana();
            psiPoints = new Psi();
            unusedSp = 0;
            unusedPp = 6;
            magicalMasteries = new ObservableCollection<MagicMastery>();
            magicSchools = new ObservableCollection<MagicSchool>();
            unusedSpellPoints = 5;
            unusedAttributePoints = 30;
            usedJoker = false;
            maxSkillLvl = 3;
            faith = 0;
        }
        #endregion

        #region getters and setters
        public ObservableCollection<CharacterClass> CharClasses {
            get { return charClasses; }
            set { this.charClasses = value; }
        }
        public Race CharRace {
            get { return charRace; }
            set { this.charRace = value; }
        }
        public Stats CharStats {
            get { return charStats; }
            set { this.charStats = value; }
        }
        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Religion {
            get { return religion; }
            set { this.religion = value; }
        }
        public String BirthPlace {
            get { return birthPlace; }
            set { this.birthPlace = value; }
        }
        public String Gender {
            get { return gender; }
            set { this.gender = value; }
        }
        public int Age {
            get { return age; }
            set { this.age = value; }
        }
        public CharacterSize Size {
            get { return size; }
            set { this.size = value; }
        }
        public Characteristic C1 {
            get { return c1; }
            set { this.c1 = value; }
        }
        public Characteristic C2 {
            get { return c2; }
            set { this.c2 = value; }
        }
        public int CharLvl {
            get { return charLvl; }
            set { this.charLvl = value; }
        }
        public ObservableCollection<Reputation> Reputations {
            get { return reputations; }
            set { this.reputations = value; }
        }
        public ObservableCollection<Skill> Skills {
            get { return skills; }
            set { this.skills = value; }
        }
        public ObservableCollection<Perk> Perks {
            get { return perks; }
            set { this.perks = value; }
        }
        public ObservableCollection<String> Languages {
            get { return languages; }
            set { this.languages = value; }
        }
        public ObservableCollection<Weapon> Weapons {
            get { return weapons; }
            set { this.weapons = value; }
        }
        public Shield EquippedShield {
            get { return equippedShield; }
            set { this.equippedShield = value; }
        }
        public Armor EquippedArmor {
            get { return equippedArmor; }
            set { this.equippedArmor = value; }
        }
        public ObservableCollection<Item> Inventory {
            get { return inventory; }
            set { this.inventory = value; }
        }
        public Cash CharCash {
            get { return charCash; }
            set { this.charCash = value; }
        }
        public ObservableCollection<Spell> Spells {
            get { return spells; }
            set { this.spells = value; }
        }
        public Mana ManaPoints {
            get { return manaPoints; }
            set { this.manaPoints = value; }
        }
        public Psi PsiPoints {
            get { return psiPoints; }
            set { this.psiPoints = value; }
        }
        public int Faith {
            get { return faith; }
            set { this.faith = value; }
        }
        public int UnusedSp {
            get { return unusedSp; }
            set { this.unusedSp = value; }
        }
        public int UnusedPp {
            get { return unusedPp; }
            set { this.unusedPp = value; }
        }
        public ObservableCollection<MagicMastery> MagicalMasteries {
            get { return magicalMasteries; }
            set { this.magicalMasteries = value; }
        }
        public ObservableCollection<MagicSchool> MagicSchools {
            get { return magicSchools; }
            set { this.magicSchools = value; }
        }
        public int UnusedSpellPoints {
            get { return unusedSpellPoints; }
            set { this.unusedSpellPoints = value; }
        }
        public int UnusedAttributePoints {
            get { return unusedAttributePoints; }
            set { this.unusedAttributePoints = value; }
        }
        public Boolean UsedJoker {
            get { return usedJoker; }
            set { this.usedJoker = value; }
        }
        public int MaxSkillLvl {
            get { return maxSkillLvl; }
            set { this.maxSkillLvl = value; }
        }
        #endregion

    }
}