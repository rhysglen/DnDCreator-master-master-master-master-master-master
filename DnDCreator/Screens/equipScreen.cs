using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator.Screens
{
    public partial class equipScreen : UserControl
    {
        public equipScreen()
        {
            InitializeComponent();

           // // equipment screen set up 
           // if (Form1.newCharacter.type == "Barbarian")
           // {
           //     primary1Button.Enabled = true;
           //     primary1Button.Visible = true;
           //     second2Button.Visible = true;
           //     second2Button.Enabled = true;
           //     primary2Button.Visible = true;
           //     primary2Button.Enabled = true;
           //     second1Button.Enabled = true;
           //     second1Button.Visible = true;

           //     primary1Button.Text = "A Greataxe";
           //     primary2Button.Text = "Any Martial Weapon";
               
           //     second1Button.Text = "Two Handaxes";
           //     second2Button.Text = "Any Simple Weapon";

           //     if (primary1Button.Checked == true)
           //     {
           //         Character.weapon.Add(greataxe);
           //     }
           //     else if (primary2Button.Checked == true)
           //     {

           //         primary2Box.Enabled = true;
           //         primary2Box.Visible = true;

           //         primary2Box.Items.Add("Flail");
           //         primary2Box.Items.Add("Glaive");
           //         primary2Box.Items.Add("Battleaxe");
           //         primary2Box.Items.Add("Greatsword");
           //         primary2Box.Items.Add("Hailberd");
           //         primary2Box.Items.Add("Lance");
           //         primary2Box.Items.Add("Longsword");
           //         primary2Box.Items.Add("Maul");
           //         primary2Box.Items.Add("Morningstar");
           //         primary2Box.Items.Add("Pike");
           //         primary2Box.Items.Add("Rapier");
           //         primary2Box.Items.Add("Scimitar");
           //         primary2Box.Items.Add("Shortsword");
           //         primary2Box.Items.Add("Trident");
           //         primary2Box.Items.Add("War Pick");
           //         primary2Box.Items.Add("Warhammer");
           //         primary2Box.Items.Add("Whip");

           //         Character.clickedWeapons.Add(primary2Box.Text);
           //     }
           //     if (second1Button.Checked == true)
           //     {
           //         Character.weapon.Add(handaxe);
           //         Character.weapon.Add(handaxe);
           //     }
           //     else if (second2Button.Checked == true)
           //     {

           //         second2Box.Enabled = true;
           //         second2Box.Visible = true;

           //         primary2Box.Items.Add("Club");
           //         primary2Box.Items.Add("Dagger");
           //         primary2Box.Items.Add("Greatclub");
           //         primary2Box.Items.Add("Handaxe");
           //         primary2Box.Items.Add("Javelin");
           //         primary2Box.Items.Add("Light Hammer");
           //         primary2Box.Items.Add("Mace");
           //         primary2Box.Items.Add("Quarterstaff");
           //         primary2Box.Items.Add("Sickle");
           //         primary2Box.Items.Add("Spear");
           //         primary2Box.Items.Add("Rapier");
           //         primary2Box.Items.Add("Light Crossbow");
           //         primary2Box.Items.Add("Dart");
           //         primary2Box.Items.Add("Shortbow");
           //         primary2Box.Items.Add("Sling");

           //         Character.clickedWeapons.Add(second2Box.Text);
           //     }
           // }
           // else if (Form1.newCharacter.type == "Bard")
           // {

           //     primary1Button.Enabled = true;
           //     primary1Button.Visible = true;
           //     second2Button.Visible = true;
           //     second2Button.Enabled = true;
           //     primary2Button.Visible = true;
           //     primary2Button.Enabled = true;
           //     second1Button.Enabled = true;
           //     second1Button.Visible = true;
           //     primary3Button.Enabled = true;
           //     primary3Button.Visible = true;
           //     other1Button.Visible = true;
           //     other1Button.Enabled = true;
           //     other2Button.Visible = true;
           //     other2Button.Enabled = true;

           //     primary1Button.Text = "A Rapier";
           //     primary2Button.Text = "A Longsword";
           //     primary3Button.Text = "Any Simple Weapon";

           //     second1Button.Text = "Diplomat's Pack";
           //     second2Button.Text = "Entertainer's Pack";

           //     other1Button.Text = "A Lute";
           //     other2Button.Text = "Any Musical Instrument";

           //     if (primary1Button.Checked == true)
           //     {
           //         Character.weapon.Add(rapier);
           //     }
           //     else if (primary2Button.Checked == true)
           //     {
           //         Character.weapon.Add(longsword);
           //     }
           //     else if (primary3Button.Checked == true)
           //     {
           //         primary3Box.Visible = true;
           //         primary3Box.Enabled = true;

           //         primary3Box.Items.Add("Club");
           //         primary3Box.Items.Add("Dagger");
           //         primary3Box.Items.Add("Greatclub");
           //         primary3Box.Items.Add("Handaxe");
           //         primary3Box.Items.Add("Javelin");
           //         primary3Box.Items.Add("Light Hammer");
           //         primary3Box.Items.Add("Mace");
           //         primary3Box.Items.Add("Quarterstaff");
           //         primary3Box.Items.Add("Sickle");
           //         primary3Box.Items.Add("Spear");
           //         primary3Box.Items.Add("Rapier");
           //         primary3Box.Items.Add("Light Crossbow");
           //         primary3Box.Items.Add("Dart");
           //         primary3Box.Items.Add("Shortbow");
           //         primary3Box.Items.Add("Sling");

           //         Character.clickedWeapons.Add(second2Box.Text);
           //     }

           //     if (second1Button.Checked == true)
           //     {
           //         Character.equipment.Add("Diplomat's Pack");
           //     }
           //     else if (second2Button.Checked == true)
           //     {
           //         Character.equipment.Add("Explorer's Pack");
           //     }

           //     if (other1Button.Checked == true)
           //     {
           //         Character.equipment.Add("Lute");
           //     }
           //     else if (other2Button.Checked == true)
           //     {
           //         Character.equipment.Add("Any Musical Instrument");
           //     }

           // }

           // else if (Form1.newCharacter.type == "Cleric")
           // {
           //     primary1Button.Enabled = true;
           //     primary1Button.Visible = true;
           //     second2Button.Visible = true;
           //     second2Button.Enabled = true;
           //     primary2Button.Visible = true;
           //     primary2Button.Enabled = true;
           //     second1Button.Enabled = true;
           //     second1Button.Visible = true;
           //     primary3Button.Enabled = true;
           //     primary3Button.Visible = true;
           //     other1Button.Visible = true;
           //     other1Button.Enabled = true;
           //     other2Button.Visible = true;
           //     other2Button.Enabled = true;
           //     armor1Button.Visible = true;
           //     armor1Button.Enabled = true;
           //     armor2Button.Enabled = true;
           //     armor2Button.Visible = true;

           //     primary1Button.Text = "A Mace";
           //     primary2Button.Text = "A WarHammer (Only if Proficient)";

           //     second1Button.Text = "Light Crossbow + 20 Bolts";
           //     second2Button.Text = "Any Simple Weapon";

           //     armor1Button.Text = "Scale Mail";
           //     armor2Button.Text = "Leather Armor";

           //     other1Button.Text = "A Priest's Pack";
           //     other2Button.Text = "An Explorer's Pack";
           //     if (Character.proficiencies.Contains("Martial Weapons"))
           //     {
           //         primary2Button.Enabled = true;
           //     }
           //     else
           //     {
           //         primary2Button.Enabled = false;
           //     }
           //     if (primary1Button.Checked == true)
           //     {
           //         Character.weapon.Add(mace);
           //     }
           //else if (primary2Button.Checked == true)
           //     {
           //         Character.weapon.Add(warhammer);
           //     }
           //     if (second1Button.Checked == true)
           //     {
           //         Character.weapon.Add(lightCB);
                    
           //     }
           //     else if (second2Button.Checked == true)
           //     {
           //         second2Box.Visible = true;
           //         second2Box.Enabled = true;

           //         primary3Box.Items.Add("Club");
           //         primary3Box.Items.Add("Dagger");
           //         primary3Box.Items.Add("Greatclub");
           //         primary3Box.Items.Add("Handaxe");
           //         primary3Box.Items.Add("Javelin");
           //         primary3Box.Items.Add("Light Hammer");
           //         primary3Box.Items.Add("Mace");
           //         primary3Box.Items.Add("Quarterstaff");
           //         primary3Box.Items.Add("Sickle");
           //         primary3Box.Items.Add("Spear");
           //         primary3Box.Items.Add("Rapier");
           //         primary3Box.Items.Add("Light Crossbow");
           //         primary3Box.Items.Add("Dart");
           //         primary3Box.Items.Add("Shortbow");
           //         primary3Box.Items.Add("Sling");

           //         Character.clickedWeapons.Add(second2Box.Text);
           //     }
           //     if (other1Button.Checked == true)
           //     {
           //         Character.equipment.Add("Priest's Pack");
           //     }
           //     else if (other2Button.Checked == true)
           //     {
           //         Character.equipment.Add("Explorer's Pack");
           //     }
           // }
           // else if (Form1.newCharacter.type == "Druid")
           // {


           // }
           // else if (Form1.newCharacter.type == "Fighter")
           // {


           // }
           // else if (Form1.newCharacter.type == "Monk")
           // {


           // }
           // else if (Form1.newCharacter.type == "Paladin")
           // {


           // }
           // else if (Form1.newCharacter.type == "Ranger")
           // {


           // }
           // else if (Form1.newCharacter.type == "Rogue")
           // {

           // }
           // else if (Form1.newCharacter.type == "Sorcerer")
           // {


           // }
           // else if (Form1.newCharacter.type == "Warlock")
           // {

           // }
           // else if (Form1.newCharacter.type == "Wizard")
           // {

           // }

        }
        //// Simple weapons
        //weapons club = new weapons("Club", Character.strMod + Character.proficiency, "1d4 Bludgeoning");
        //weapons dagger = new weapons("Dagger", Character.strMod + Character.proficiency, "1d4 Piercing");
        //weapons greatclub = new weapons("Greatclub", Character.strMod + Character.proficiency, "1d8 Bludgeoning");
        //weapons handaxe = new weapons("Handaxe", Character.strMod + Character.proficiency, "1d6 Slashing");
        //weapons javelin = new weapons("Javelin", Character.strMod + Character.proficiency, "1d6 Piercing");
        //weapons lighthammer = new weapons("Light Hammer", Character.strMod + Character.proficiency, "1d4 Bludgeoning");
        //weapons mace = new weapons("Mace", Character.strMod + Character.proficiency, "1d6 Bludgeoning");
        //weapons quarterstaff = new weapons("Quarterstaff", Character.strMod + Character.proficiency, "1d6 Bludgeoning");
        //weapons sickle = new weapons("Sickle", Character.strMod + Character.proficiency, "1d4 Slashing");
        //weapons spear = new weapons("Spear", Character.strMod + Character.proficiency, "1d6 Piercing");
        //weapons lightCB = new weapons("Light Crossbow", Character.dexMod + Character.proficiency, "1d8 Piercing");
        //weapons dart = new weapons("Dart", Character.dexMod + Character.proficiency, "1d4 Piercing");
        //weapons shortbow = new weapons("Shortbow", Character.dexMod + Character.proficiency, "1d6 Piercing");
        //weapons sling = new weapons("Sling", Character.dexMod + Character.proficiency, "1d4 Bludgeoning");

        ////Martial Weapons
        //weapons battleaxe = new weapons("Battleaxe", Character.strMod + Character.proficiency, "1d8 Slashing");
        //weapons flail = new weapons("Flail", Character.strMod + Character.proficiency, "1d8 Bludgeoning");
        //weapons glaive = new weapons("Glaive", Character.strMod + Character.proficiency, "1d10 Slashing");
        //weapons greataxe = new weapons("Greataxe", Character.strMod + Character.proficiency, "1d12 Slashing");
        //weapons greatsword = new weapons("Greatsword", Character.strMod + Character.proficiency, "2d6 Slashing");
        //weapons hailberd = new weapons("Hailberd", Character.strMod + Character.proficiency, "1d10 Slashing");
        //weapons lance = new weapons("Lance", Character.strMod + Character.proficiency, "1d12 Piercing");
        //weapons longsword = new weapons("Longsword", Character.strMod + Character.proficiency, "1d8 Slashing");
        //weapons maul = new weapons("Maul", Character.strMod + Character.proficiency, "2d6 Bludgeoning");
        //weapons morningstar = new weapons("Morningstar", Character.strMod + Character.proficiency, "1d8 Piercing");
        //weapons pike = new weapons("Pike", Character.strMod + Character.proficiency, "1d10 Piercing");
        //weapons rapier = new weapons("Rapier", Character.strMod + Character.proficiency, "1d8 Piercing");
        //weapons scimitar = new weapons("Scimitar", Character.strMod + Character.proficiency, "1d6 Slashing");
        //weapons shortsword = new weapons("Shortsword", Character.strMod + Character.proficiency, "1d6 Piercing");
        //weapons trident = new weapons("Trident", Character.strMod + Character.proficiency, "1d6 Piercing");
        //weapons warpick = new weapons("War Pick", Character.strMod + Character.proficiency, "1d8 Piercing");
        //weapons warhammer = new weapons("Warhammer", Character.strMod + Character.proficiency, "1d8 Bludgeoning");
        //weapons whip = new weapons("Whip", Character.strMod + Character.proficiency, "1d4 Slashing");
        //weapons blowgun = new weapons("Blowgun", Character.dexMod + Character.proficiency, "1 piercing");
        //weapons handCB = new weapons("Hand Crossbow", Character.dexMod + Character.proficiency, "1d6 piercing");
        //weapons heavyCB = new weapons("Heavy Crossbow", Character.dexMod + Character.proficiency, "1d10 piercing");
        //weapons longbow = new weapons("LongBow", Character.dexMod + Character.proficiency, "1d8 piercing");


    }
}
