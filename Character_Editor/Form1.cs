using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Character_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.comboBoxRace.DataSource = Enum.GetValues(typeof(CharacterRace));
            
        }

         
        private void skillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBoxSkills.Visible = !groupBoxSkills.Visible;
            skillToolStripMenuItem.Checked = !skillToolStripMenuItem.Checked;
        }

        private void listBoxCharacter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (-1 != listBoxCharacter.SelectedIndex)
            {
                Character c = (Character)listBoxCharacter.Items[listBoxCharacter.SelectedIndex];
                textBoxFirstName.Text = c.FirstName;
                textBoxLastName.Text = c.LastName;
                numericUpDownAge.Value = c.Age;
                comboBoxRace.SelectedItem = c.Race;
                numericUpDownBravery.Value = c.Skills.Bravery;
                numericUpDownCheating.Value = c.Skills.Cheating;
                numericUpDownDisguise.Value = c.Skills.Disguise;
                numericUpDownEndurance.Value = c.Skills.Endurance;
                numericUpDownHealing.Value = c.Skills.Healing;
                numericUpDownKnowledge.Value = c.Skills.Knowledge;
                numericUpDownLeadership.Value = c.Skills.Leadership;
                numericUpDownStealth.Value = c.Skills.Stealth;
                updateCharacterToolStripMenuItem.Enabled = true;
                deselectCharacterToolStripMenuItem.Enabled = true;
                deleteCharacterToolStripMenuItem.Enabled = true;
            }
            else
            {
                textBoxFirstName.Clear();
                textBoxLastName.Clear();
                numericUpDownAge.Value = 0;
                comboBoxRace.SelectedIndex = 0;
                numericUpDownBravery.Value = 0;
                numericUpDownCheating.Value = 0;
                numericUpDownDisguise.Value = 0;
                numericUpDownEndurance.Value = 0;
                numericUpDownHealing.Value = 0;
                numericUpDownKnowledge.Value = 0;
                numericUpDownLeadership.Value = 0;
                numericUpDownStealth.Value = 0;
                updateCharacterToolStripMenuItem.Enabled = false;
                deselectCharacterToolStripMenuItem.Enabled = false;
                deleteCharacterToolStripMenuItem.Enabled = false;
            }
        }

        private void addCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character c = new Character();
            c.FirstName = textBoxFirstName.Text; 
            c.LastName = textBoxLastName.Text;
            c.Age = numericUpDownAge.Value;
            c.Race = (CharacterRace)comboBoxRace.Items[comboBoxRace.SelectedIndex];

            CharacterSkills cskills = new CharacterSkills();
            cskills.Bravery = numericUpDownBravery.Value;
            cskills.Cheating = numericUpDownCheating.Value;
            cskills.Disguise = numericUpDownDisguise.Value;
            cskills.Endurance = numericUpDownEndurance.Value;
            cskills.Healing = numericUpDownHealing.Value;
            cskills.Knowledge = numericUpDownKnowledge.Value;
            cskills.Leadership = numericUpDownLeadership.Value;
            cskills.Stealth = numericUpDownStealth.Value;

            c.Skills = cskills;

            listBoxCharacter.Items.Add(c);
        }

        private void updateCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Character c = (Character)listBoxCharacter.Items[listBoxCharacter.SelectedIndex];
           c.FirstName = textBoxFirstName.Text;
           c.LastName = textBoxLastName.Text;
           c.Age = numericUpDownAge.Value;
           c.Race = (CharacterRace)comboBoxRace.Items[comboBoxRace.SelectedIndex];

           CharacterSkills cskills = new CharacterSkills();
           cskills.Bravery = numericUpDownBravery.Value;
           cskills.Cheating = numericUpDownCheating.Value;
           cskills.Disguise = numericUpDownDisguise.Value;
           cskills.Endurance = numericUpDownEndurance.Value;
           cskills.Healing = numericUpDownHealing.Value;
           cskills.Knowledge = numericUpDownKnowledge.Value;
           cskills.Leadership = numericUpDownLeadership.Value;
           cskills.Stealth = numericUpDownStealth.Value;
           c.Skills = cskills;
           listBoxCharacter.Items.Insert(listBoxCharacter.SelectedIndex, c);
           listBoxCharacter.Items.RemoveAt(listBoxCharacter.SelectedIndex);
           
        }

        private void deselectCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxCharacter.SelectedIndex = -1;
        }

        private void deleteCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxCharacter.Items.RemoveAt(listBoxCharacter.SelectedIndex);
        }

        private void buttonRandomize_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numericUpDownBravery.Value = rand.Next(10,90);
            numericUpDownCheating.Value = rand.Next(10, 90);
            numericUpDownDisguise.Value = rand.Next(10, 90);
            numericUpDownEndurance.Value = rand.Next(10, 90);
            numericUpDownHealing.Value = rand.Next(10, 90);
            numericUpDownKnowledge.Value = rand.Next(10, 90);
            numericUpDownLeadership.Value = rand.Next(10, 90);
            numericUpDownStealth.Value = rand.Next(10, 90);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a size file dialog
            SaveFileDialog dlg = new SaveFileDialog();
            // Set the filter strings
            dlg.Filter = "All Files(*.*)|*.*|csv(*.csv)|*.csv";
            // Set the default extension
            dlg.DefaultExt = "csv";
            // Display the dialog to the user
            if (DialogResult.OK == dlg.ShowDialog())
            {
                // Open a stream for writing
                System.IO.StreamWriter writer = new System.IO.StreamWriter(dlg.FileName);
                // Write the string
               foreach(Character value in listBoxCharacter.Items)
               {
                   writer.WriteLine(value.ToFile());
               }
                // Close the stream
                writer.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            // Create an open file dialog
            OpenFileDialog dlg = new OpenFileDialog();
            // Set the filter strings
            dlg.Filter = "All Files(*.*)|*.*|csv(*.csv)|*.csv";
            // Display the dialog to the user
            if (DialogResult.OK == dlg.ShowDialog())
            {
                listBoxCharacter.Items.Clear();
                // Open a stream for reading
                System.IO.StreamReader reader = new System.IO.StreamReader(dlg.FileName);
                // Write a line to the stream
                while(reader.Peek() >= 0 )
                {
                    string[] subs = reader.ReadLine().Split(new Char[] { ',' });
                    Character c = new Character();

                    c.FirstName = subs[0];
                    c.LastName = subs[1];
                    c.Age = decimal.Parse(subs[2]);
                    c.Race = (CharacterRace)Enum.Parse(typeof(CharacterRace), subs[3]);

                    CharacterSkills cskills = new CharacterSkills();
                    cskills.Bravery = decimal.Parse(subs[4]);
                    cskills.Cheating = decimal.Parse(subs[5]);
                    cskills.Disguise = decimal.Parse(subs[6]);
                    cskills.Endurance = decimal.Parse(subs[7]);
                    cskills.Healing = decimal.Parse(subs[8]);
                    cskills.Knowledge = decimal.Parse(subs[9]);
                    cskills.Leadership = decimal.Parse(subs[10]);
                    cskills.Stealth = decimal.Parse(subs[11]);
                    c.Skills = cskills;
                   listBoxCharacter.Items.Add(c);
                }
                
                // Close the stream
                reader.Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxCharacter.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



      

   
     

 
    }
}
