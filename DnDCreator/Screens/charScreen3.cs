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
            
            // background skills

            if (Character.background == "Acolyte")
            {
                insButton.Checked = true;
                religButton.Checked = true;
                insButton.Enabled = false;
                religButton.Enabled = false;
            }

            // class skill choices
            if (Character.type == "Barbarian")
            {
                skillNum = skillNum + 2;

                aniButton.Enabled = true;
                athButton.Enabled = true;
                survButton.Enabled = true;
                intimButton.Enabled = true;
                natButton.Enabled = true;
                percButton.Enabled = true;
            }
            else if (Character.type == "Bard")
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

            else if (Character.type == "Cleric")
            {
                skillNum = skillNum + 2;

                hisButton.Enabled = true;
                insButton.Enabled = true;
                medButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Character.type == "Druid")
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
            else if (Character.type == "Fighter")
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
            else if (Character.type == "Monk")
            {
                skillNum = skillNum + 2;

                acroButton.Enabled = true;
                athButton.Enabled = true;
                hisButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                stealthButton.Enabled = true;

            }
            else if (Character.type == "Paladin")
            {
                skillNum = skillNum + 2;

                intimButton.Enabled = true;
                athButton.Enabled = true;
                medButton.Enabled = true;
                insButton.Enabled = true;
                religButton.Enabled = true;
                persuaButton.Enabled = true;

            }
            else if (Character.type == "Ranger")
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
            else if (Character.type == "Rogue")
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
            else if (Character.type == "Sorcerer")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                decButton.Enabled = true;
                insButton.Enabled = true;
                intimButton.Enabled = true;
                persuaButton.Enabled = true;
                religButton.Enabled = true;

            }
            else if (Character.type == "Warlock")
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
            else if (Character.type == "Wizard")
            {
                skillNum = skillNum + 2;

                arcaButton.Enabled = true;
                insButton.Enabled = true;
                hisButton.Enabled = true;
                medButton.Enabled = true;
                inveButton.Enabled = true;
                religButton.Enabled = true;

            }
            // limiter for skills
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
            if (athButton.Checked == true)
            {
                Character.skills.Add("Athletics");
                skillNum--;
            }
            if (acroButton.Checked == true)
            {
                Character.skills.Add("Acrobatics");
                skillNum--;
            }
            if (handButton.Checked == true)
            {
                Character.skills.Add("Sleight of Hand");
                skillNum--;
            }
            if (stealthButton.Checked == true)
            {
                Character.skills.Add("Stealth");
                skillNum--;
            }
            if (arcaButton.Checked == true)
            {
                Character.skills.Add("Arcana");
                skillNum--;
            }
            if (hisButton.Checked == true)
            {
                Character.skills.Add("History");
                skillNum--;
            }
            if (inveButton.Checked == true)
            {
                Character.skills.Add("Investigation");
                skillNum--;
            }
            if (natButton.Checked == true)
            {
                Character.skills.Add("Nature");
                skillNum--;
            }
            if (religButton.Checked == true)
            {
                Character.skills.Add("Religion");
                skillNum--;
            }
            if (aniButton.Checked == true)
            {
                Character.skills.Add("Animal Handling");
                skillNum--;
            }
            if (medButton.Checked == true)
            {
                Character.skills.Add("Medicine");
                skillNum--;
            }
            if (percButton.Checked == true)
            {
                Character.skills.Add("Perception");
                skillNum--;
            }
            if (survButton.Checked == true)
            {
                Character.skills.Add("Survival");
                skillNum--;
            }
            if (decButton.Checked == true)
            {
                Character.skills.Add("Deception");
                skillNum--;
            }
            if (intimButton.Checked == true)
            {
                Character.skills.Add("Intimidation");
                skillNum--;
            }
            if (perfButton.Checked == true)
            {
                Character.skills.Add("Performance");
                skillNum--;
            }
            if (persuaButton.Checked == true)
            {
                Character.skills.Add("Persuasion");
                skillNum--;

            }
        }

        private void char3NextButton_Click(object sender, EventArgs e)
        {
           
        }

        private void char3BackButton_Click(object sender, EventArgs e)
        {

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            skillList();
        }
    }

  
    
}
