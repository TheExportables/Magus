using Magus.Model;
using Magus.Model.Abilities;
using Magus.Model.Items;
using Magus.Model.Magic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Data {
    class TestDataLoader : DataLoader{

        public TestDataLoader() {
            loadRaces();
            loadClasses();
            loadCommonItems();
            loadArmors();
            loadShields();
            loadWeapons();
            loadMaterials();

            loadSkills();
            loadPerks();
            loadDeities();
            loadMagicShools();
        }

        public void loadRaces() {
            Race race = new Race("Teszt faj", "Bölcs és méltán híres tesztelők népe, akik mind a Tesztek isteneiben hisznek, és tőlük várnak megváltást minden funkció kipróbálására teljes lefedettséggel. Vannak köztük mágiahasználók is, akik mindenféle tesztelési mágikus praktikák bevetésére képesek.", 1, 1, 1, 5, -1, 0);
            DataManager.Races.Add(race);
            Race race2 = new Race("Teszt faj2", "Bölcs és méltán híres tesztelők népe, akik mind a Tesztek isteneiben hisznek, és tőlük várnak megváltást minden funkció kipróbálására teljes lefedettséggel. Vannak köztük mágiahasználók is, akik mindenféle tesztelési mágikus praktikák bevetésére képesek.", 1, 1, 1, 5, -1, 0);
            DataManager.Races.Add(race2);
        }

        public void loadClasses() {
            CharacterClass baseClass = new CharacterClass();
            baseClass.Name = "Teszt alap kaszt";
            baseClass.Description = "Segít gyerekkorban elindulni a tesztelés felé";
            baseClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 1, 0, 3, 0));
            baseClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 2, 1, 4, 0));
            baseClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 3, 2, 5, 1));
            baseClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 4, 3, 6, 2));
            baseClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 5, 4, 7, 3));
            baseClass.FpPerLvl = new DiceValue(2, Dice.d8);
            baseClass.SpPerLvl = 6;

            CharacterClass baseClass2 = new CharacterClass();
            baseClass2.Name = "Teszt alap kaszt2";
            baseClass2.Description = "Segít gyerekkorban elindulni a tesztelés felé";
            baseClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 0, 3, 0, 1));
            baseClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 0, 4, 1, 2));
            baseClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 1, 5, 2, 3));
            baseClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 2, 6, 3, 4));
            baseClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 3, 7, 4, 5));
            baseClass2.FpPerLvl = new DiceValue(2, Dice.d8);
            baseClass2.SpPerLvl = 6;

            AdventurerCharacterClass adventurerCharClass = new AdventurerCharacterClass();
            adventurerCharClass.Name = "Teszt kalandozó kaszt";
            adventurerCharClass.Description = "Már egy szinttel fejlettebb tesztelők";
            adventurerCharClass.AvailableForRaces.Add("Teszt faj");
            adventurerCharClass.IdealBackground = "Teszt alap kaszt 3";
            adventurerCharClass.StatRequirements.Add(getStatRequirement());
            adventurerCharClass.AttackValueRequirement = 1;
            adventurerCharClass.PerkRequirements.Add(getBasePerk());
            adventurerCharClass.SkillRequirements.Add(getSkillRequirement());
            adventurerCharClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk> { getBasePerk() }, 5, 0, 3, 0));
            adventurerCharClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 6, 1, 4, 0));
            adventurerCharClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 7, 2, 5, 1));
            adventurerCharClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 8, 3, 6, 2));
            adventurerCharClass.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 9, 4, 7, 3));
            adventurerCharClass.FpPerLvl = new DiceValue(3, Dice.d10);
            adventurerCharClass.SpPerLvl = 10;

            AdventurerCharacterClass adventurerCharClass2 = new AdventurerCharacterClass();
            adventurerCharClass2.Name = "Teszt kalandozó kaszt2";
            adventurerCharClass2.Description = "Már egy szinttel fejlettebb tesztelők";
            adventurerCharClass2.AvailableForRaces.Add("Teszt faj2");
            adventurerCharClass2.IdealBackground = "Teszt alap kaszt 3";
            adventurerCharClass2.StatRequirements.Add(getStatRequirement());
            adventurerCharClass2.AttackValueRequirement = 1;
            adventurerCharClass2.PerkRequirements.Add(getBasePerk());
            adventurerCharClass2.SkillRequirements.Add(getSkillRequirement());
            adventurerCharClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 1, 0, 3, 5));
            adventurerCharClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 2, 1, 4, 6));
            adventurerCharClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 3, 2, 5, 7));
            adventurerCharClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 4, 3, 6, 8));
            adventurerCharClass2.ValuesPerLvl.Add(new ClassValuesPerLvl(new List<Perk>(), 5, 4, 7, 9));
            adventurerCharClass2.FpPerLvl = new DiceValue(3, Dice.d10);
            adventurerCharClass2.SpPerLvl = 10;

            DataManager.BaseClasses.Add(baseClass);
            DataManager.BaseClasses.Add(baseClass2);
            DataManager.Classes.Add(baseClass);
            DataManager.Classes.Add(baseClass2);
            DataManager.Classes.Add(adventurerCharClass);
            DataManager.Classes.Add(adventurerCharClass2);
        }

        public void loadPerks() {
            DataManager.Perks.Add(getBasePerk());
            DataManager.Perks.Add(getPerk());
        }

        public void loadSkills() {
            DataManager.Skills.Add(getSkill());
        }

        public void loadCommonItems() {
            Item item = new Item("Kulacs", new Cash(0,0,0,10), 1, false, "");
            DataManager.CommonItems.Add(item);
        }

        public void loadArmors() {
            Armor armor = new Armor("Tesztpáncél", new Cash(0,0,5,15), 15, true, "Tesztium", 3, 5, 1);
            DataManager.Armors.Add(armor);
        }

        public void loadShields() {
            Shield shield = new Shield("Tesztshield", new Cash(0,0,2,21), 8, true, "Tesztium", 5);
            DataManager.Shields.Add(shield);
        }

        public void loadWeapons() {
            Weapon weapon = new Weapon("Tesztblade", new Cash(0,0,1,12), 5, true, "Tesztium", WeaponCategory.LongBlade, WeaponHandlingAttribute.FromStrengthAndDextirity, new DiceValue(2, Dice.d10), 3, WeaponSize.oneHanded, new Range(0,2));
            DataManager.Weapons.Add(weapon);
        }

        public void loadMaterials() {
            Material material = new Material("Tesztium", 1,1,-1,1,1,1,1,1,-20,2,true);
            DataManager.Materials.Add(material);
        }

        public void loadDeities() {
            PriestDeity deity = new PriestDeity("Cthulhu", "A tesztelés nagy istene. Mindent tud róla, amit lehet a világon", new List<GreaterSphere>{getGreaterSphere()}, new List<SmallerSphere>{getSmallerSphere()});
            DataManager.Deities.Add(deity);
        }

        public void loadMagicShools() {
            MagicSchool school = new MagicSchool("Tesztelés varázsiskola", "Minden ami a teszteléssel kapcsolatos 'magic'", new List<MagicMastery>{getMagicMastery()}, 6, 0);
            MagicSchool priestSchool = new MagicSchool("Tesztelés az istenektől", "Minden fohász, ami csak a tesztelést segítheti", new List<MagicMastery> { getPriestMastery() }, 0, 0);
            DataManager.MagicShools.Add(school);
            DataManager.MagicShools.Add(priestSchool);
        }

        public GreaterSphere getGreaterSphere() {
            List<Skill> primarySkills = new List<Skill>();
            List<Perk> perksGranted = new List<Perk>();
            primarySkills.Add(getSkill());
            perksGranted.Add(getBasePerk());
            return new GreaterSphere("Teszt nagy szféra", primarySkills, perksGranted);
        }

        public SmallerSphere getSmallerSphere() {
            List<Skill> primarySkills = new List<Skill>();
            List<Perk> perksGranted = new List<Perk>();
            List<GiftOfGods> giftsGranted = new List<GiftOfGods>();
            primarySkills.Add(getSkill());
            perksGranted.Add(getBasePerk());
            giftsGranted.Add(getGiftOfGods());
            return new SmallerSphere("Teszt kisebb szféra", primarySkills, perksGranted, giftsGranted);
        }

        public GiftOfGods getGiftOfGods() {
            return new GiftOfGods("Teszt papi képesség", "Teszt istenek hagyatéka, segíti a kód javulását.");
        }

        public MagicMastery getMagicMastery() {
            List<Spell> spells = new List<Spell>();
            spells.Add(getMagicSpell());
            return new MagicMastery("Tesztelési praktikák", "Mágiák azon csoportja a tesztelésen belül, amik a fizikai világot érintik.", spells);
        }

        public MagicMastery getPriestMastery() {
            List<Spell> spells = new List<Spell>();
            spells.Add(getPriestSpell());
            return new MagicMastery("Tesztelés arkánum litániái", "Fohászok azon csoportja a teszt istenekhez, amik a fizikai világot érintik.", spells);
        }

        public MagicSpell getMagicSpell() {
            return new MagicSpell("Teszt mágia", "Teszteli a varázslatok megjelenítését", 8, "15 láb", 2, "Egy embert", ResistanceType.Mental, 5, 5, false);
        }

        public PriestSpell getPriestSpell() {
            List<GreaterSphere> greatSupport = new List<GreaterSphere>();
            List<SmallerSphere> smallSupport = new List<SmallerSphere>();
            greatSupport.Add(getGreaterSphere());
            smallSupport.Add(getSmallerSphere());
            return new PriestSpell("Teszt papi mágia", "Teszteli a papi mágiákát kezelését", 5, "5 láb sugarú kör", 10, "Területre", ResistanceType.Physical, 4, 25, greatSupport, new List<GreaterSphere>(), smallSupport);
        }

        public Skill getSkill() {
            return new Skill("Teszt képzettség", "A Magus program tesztelésére.", StatDependency.Intellect, false, true);
        }

        public Perk getPerk() {
            List<Perk> perkList = new List<Perk>();
            List<SkillRequirement> skillList = new List<SkillRequirement>();
            List<StatRequirement> statList = new List<StatRequirement>();
            perkList.Add(getBasePerk());
            skillList.Add(getSkillRequirement());
            statList.Add(getStatRequirement());
            return new Perk("Teszt képesség", "A Magus program tesztelésére jó, kalandozóknak sajnos nem.", perkList, skillList, statList, PerkCategory.Background);
        }

        public Perk getBasePerk() {
            return new Perk("Teszt képesség követelménye", "A Magus program tesztelésére jó, kalandozóknak sajnos nem.", new List<Perk>(), new List<SkillRequirement>(), new List<StatRequirement>(), PerkCategory.Background);
        }

        public SkillRequirement getSkillRequirement() {
            return new SkillRequirement(getSkill(), 15);
        }

        public StatRequirement getStatRequirement() {
            return new StatRequirement(StatDependency.Intellect, 15);
        }
    }
}
