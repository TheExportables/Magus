using Magus.Model.Magic;
using Magus.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Character : INotifyPropertyChanged {

        #region variables
        ObservableCollection<CharacterClassViewModel> charClasses;
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
        ObservableCollection<SkillViewModel> skills;
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
        int unusedBonusAttributePoints;
        ObservableCollection<MagicMasteryViewModel> magicalMasteries;
        ObservableCollection<MagicSchool> magicSchools;
        ObservableCollection<GreaterSphere> greaterSpheres;
        ObservableCollection<SmallerSphere> smallerSpheres;

        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region constructors
        public Character() {
            charClasses = new ObservableCollection<CharacterClassViewModel>();
            charRace = new Race();
            charStats = new Stats();
            name = "";
            religion = "";
            birthPlace = "";
            gender = "";
            age = 0;
            charLvl = 0;
            reputations = new ObservableCollection<Reputation>();
            skills = new ObservableCollection<SkillViewModel>();
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
            magicalMasteries = new ObservableCollection<MagicMasteryViewModel>();
            magicSchools = new ObservableCollection<MagicSchool>();
            unusedSpellPoints = 5;
            unusedAttributePoints = 30;
            maxSkillLvl = 3;
            faith = 0;
            unusedBonusAttributePoints = 0;
            greaterSpheres = new ObservableCollection<GreaterSphere>();
            smallerSpheres = new ObservableCollection<SmallerSphere>();
        }
        #endregion

        #region getters and setters
        public ObservableCollection<CharacterClassViewModel> CharClasses {
            get { return charClasses; }
            set { this.charClasses = value; }
        }
        public Race CharRace {
            get { return charRace; }
            set {
                this.charRace = value;
                OnPropertyChanged("CharRace");
            }
        }
        public Stats CharStats {
            get { return charStats; }
            set {
                this.charStats = value;
                OnPropertyChanged("CharStats");
            }
        }
        public String Name {
            get { return name; }
            set {
                this.name = value;
                OnPropertyChanged("Name");
            }
        }
        public String Religion {
            get { return religion; }
            set {
                this.religion = value;
                OnPropertyChanged("Religion");
            }
        }
        public String BirthPlace {
            get { return birthPlace; }
            set {
                this.birthPlace = value;
                OnPropertyChanged("BirthPlace");
            }
        }
        public String Gender {
            get { return gender; }
            set {
                this.gender = value;
                OnPropertyChanged("Gender");
            }
        }
        public int Age {
            get { return age; }
            set {
                this.age = value;
                OnPropertyChanged("Age");
            }
        }
        public CharacterSize Size {
            get { return size; }
            set {
                this.size = value;
                OnPropertyChanged("Size");
            }
        }
        public Characteristic C1 {
            get { return c1; }
            set {
                this.c1 = value;
                OnPropertyChanged("C1");
            }
        }
        public Characteristic C2 {
            get { return c2; }
            set { 
                this.c2 = value;
                OnPropertyChanged("C2");
            }
        }
        public int CharLvl {
            get { return charLvl; }
            set { 
                this.charLvl = value;
                OnPropertyChanged("CharLvl");
            }
        }
        public ObservableCollection<Reputation> Reputations {
            get { return reputations; }
            set { this.reputations = value; }
        }
        public ObservableCollection<SkillViewModel> Skills {
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
            set { 
                this.equippedShield = value;
                OnPropertyChanged("EquippedShield");
            }
        }
        public Armor EquippedArmor {
            get { return equippedArmor; }
            set { 
                this.equippedArmor = value;
                OnPropertyChanged("EquippedArmor");
            }
        }
        public ObservableCollection<Item> Inventory {
            get { return inventory; }
            set { this.inventory = value; }
        }
        public Cash CharCash {
            get { return charCash; }
            set { 
                this.charCash = value;
                OnPropertyChanged("CharCash");
            }
        }
        public ObservableCollection<Spell> Spells {
            get { return spells; }
            set { this.spells = value; }
        }
        public Mana ManaPoints {
            get { return manaPoints; }
            set { 
                this.manaPoints = value;
                OnPropertyChanged("ManaPoints");
            }
        }
        public Psi PsiPoints {
            get { return psiPoints; }
            set { 
                this.psiPoints = value;
                OnPropertyChanged("PsiPoints");
            }
        }
        public int Faith {
            get { return faith; }
            set { 
                this.faith = value;
                OnPropertyChanged("Faith");
            }
        }
        public int UnusedSp {
            get { return unusedSp; }
            set { 
                this.unusedSp = value;
                OnPropertyChanged("UnusedSp");
            }
        }
        public int UnusedPp {
            get { return unusedPp; }
            set { 
                this.unusedPp = value;
                OnPropertyChanged("UnusedPp");
            }
        }
        public ObservableCollection<MagicMasteryViewModel> MagicalMasteries {
            get { return magicalMasteries; }
            set { this.magicalMasteries = value; }
        }
        public ObservableCollection<MagicSchool> MagicSchools {
            get { return magicSchools; }
            set { this.magicSchools = value; }
        }
        public int UnusedSpellPoints {
            get { return unusedSpellPoints; }
            set { 
                this.unusedSpellPoints = value;
                OnPropertyChanged("UnusedSpellPoints");
            }
        }
        public int UnusedAttributePoints {
            get { return unusedAttributePoints; }
            set { 
                this.unusedAttributePoints = value;
                OnPropertyChanged("UnusedAttributePoints");
            }
        }
        public int UnusedBonusAttributePoints {
            get { return unusedBonusAttributePoints; }
            set { 
                this.unusedBonusAttributePoints = value;
                OnPropertyChanged("UnusedBonusAttributePoints");
            }
        }
        public int MaxSkillLvl {
            get { return maxSkillLvl; }
            set { 
                this.maxSkillLvl = value;
                OnPropertyChanged("MaxSkillLvl");
            }
        }
        public ObservableCollection<GreaterSphere> GreaterSpheres {
            get { return greaterSpheres; }
            set { greaterSpheres = value; }
        }
        public ObservableCollection<SmallerSphere> SmallerSpheres {
            get { return smallerSpheres; }
            set { smallerSpheres = value; }
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