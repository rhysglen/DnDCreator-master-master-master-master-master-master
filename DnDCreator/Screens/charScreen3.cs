using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDCreator
{
    public partial class charScreen3 : UserControl
    {
        public int skillNum = 0;

        public charScreen3()
        {
            InitializeComponent();

            //  skills limit
           
            if (Form1.newCharacter.background == "Acolyte")
            {
                insButton.Checked = true;
                religButton.Checked = true;
                insButton.Enabled = false;
                religButton.Enabled = false;
            }

            // class skill choices
            if (Form1.newCharacter.type == "Barbarian")
            {
                skillNum = skillNum + 2;

                aniButton.Enabled = true;
                athButton.Enabled = true;
                survButton.Enabled = true;
                intimButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
            }
            else if (Form1.newCharacter.type == "Bard")
            {
                skillNum = skillNum + 3;

                athButton.Enabled = true;
                acroButton.Enabled = true;
                handButton.Enabled = true;
                stealthButton.Enabled = true;
                arcaButton.Enabled = true;
                hisButton.Enabled = true;
                inveButton.Enabled = true;
                natButton.Enabled = true;
                religButton.Enabled = true;
                aniButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                percButton.Enabled = true;
                survButton.Enabled = true;
                decButton.Enabled = true;
                intimButton.Enabled = true;
                perfButton.Enabled = true;
                persuaButton.Enabled = true;
            }

            else if (Form1.newCharacter.type == "Cleric")
            {
                skillNum = skillNum + 2;

                hisButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Druid")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                aniButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
                religButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Fighter")
            {
                skillNum = skillNum + 2;

                acroButton.Enabled = true;
                aniButton.Enabled = true;
                athButton.Enabled = true;
                hisButton.Enabled = true;
                insButton.Enabled = true;
                percButton.Enabled = true;
                intimButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Monk")
            {
                skillNum = skillNum + 2;

                acroButton.Enabled = true;
                athButton.Enabled = true;
                hisButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                stealthButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Paladin")
            {
                skillNum = skillNum + 2;

                intimButton.Enabled = true;
                athButton.Enabled = true;
                medButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                persuaButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Ranger")
            {
                skillNum = skillNum + 3;

                aniButton.Enabled = true;
                athButton.Enabled = true;
                inveButton.Enabled = true;
                insButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
                stealthButton.Enabled = true;
                survButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Rogue")
            {
                skillNum = skillNum + 4;

                athButton.Enabled = true;
                acroButton.Enabled = true;
                handButton.Enabled = true;
                stealthButton.Enabled = true;
                inveButton.Enabled = true;
                insButton.Enabled = true;
                percButton.Enabled = true;
                decButton.Enabled = true;
                intimButton.Enabled = true;
                perfButton.Enabled = true;
                persuaButton.Enabled = true;
            }
            else if (Form1.newCharacter.type == "Sorcerer")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                decButton.Enabled = true;
                insButton.Enabled = true;
                intimButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Warlock")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                decButton.Enabled = true;
                hisButton.Enabled = true;
                intimButton.Enabled = true;
                inveButton.Enabled = true;
                religButton.Enabled = true;
                natButton.Enabled = true;

            }
            else if (Form1.newCharacter.type == "Wizard")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                insButton.Enabled = true;
                hisButton.Enabled = true;
                medButton.Enabled = true;
                inveButton.Enabled = true;
                religButton.Enabled = true;

            }
        }


        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (skillNum == 0)
            {
                athButton.Enabled = false;
                acroButton.Enabled = false;
                handButton.Enabled = false;
                stealthButton.Enabled = false;
                arcaButton.Enabled = false;
                hisButton.Enabled = false;
                inveButton.Enabled = false;
                natButton.Enabled = false;
                religButton.Enabled = false;
                aniButton.Enabled = false;
                insButton.Enabled = false;
                medButton.Enabled = false;
                percButton.Enabled = false;
                survButton.Enabled = false;
                decButton.Enabled = false;
                intimButton.Enabled = false;
                perfButton.Enabled = false;
                persuaButton.Enabled = false;
            }
            if (athButton.Checked == true)
            {
                Character.skills.Add("Athletics");          
            }
            if (acroButton.Checked == true)
            {
                Character.skills.Add("Acrobatics");
            }
            if (handButton.Checked == true)
            {
                Character.skills.Add("Sleight of Hand");
            }
            if (stealthButton.Checked == true)
            {
                Character.skills.Add("Stealth");
            }
            if (arcaButton.Checked == true)
            {
                Character.skills.Add("Arcana");
            }
            if (hisButton.Checked == true)
            {
                Character.skills.Add("History");
            }
            if (inveButton.Checked == true)
            {
                Character.skills.Add("Investigation");
            }
            if (natButton.Checked == true)
            {
                Character.skills.Add("Nature");
            }
            if (religButton.Checked == true)
            {
                Character.skills.Add("Religion");
            }
            if (aniButton.Checked == true)
            {
                Character.skills.Add("Animal Handling");
            }
            if (medButton.Checked == true)
            {
                Character.skills.Add("Medicine");
            }
            if (percButton.Checked == true)
            {
                Character.skills.Add("Perception");
            }
            if (survButton.Checked == true)
            {
                Character.skills.Add("Survival");
            }
            if (decButton.Checked == true)
            {
                Character.skills.Add("Deception");
            }
            if (intimButton.Checked == true)
            {
                Character.skills.Add("Intimidation");
            }
            if (perfButton.Checked == true)
            {
                Character.skills.Add("Performance");
            }
            if (persuaButton.Checked == true)
            {
                Character.skills.Add("Persuasion");
            }
        }

        private void athButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void skillList()
        {
            //adding skills
           
        }

        private void char3NextButton_Click(object sender, EventArgs e)
        {
           
        }

        private void char3BackButton_Click(object sender, EventArgs e)
        {

        }

        private void athButton_CheckedChanged_1(object sender, EventArgs e)
        {
            if (athButton.Checked && skillNum > 0)
            {
                skillNum--;
            }
            else
            {
                skillNum++;
            }

          
        }
    }

  
    
}
