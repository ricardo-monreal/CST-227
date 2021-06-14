using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroMaker
{
    public partial class HeroForm : Form
    {
        SuperHero newHero;
        public HeroForm()
        {
            InitializeComponent();
            newHero = new SuperHero();
        }

        private int getTotalPhysicalAttrPoints()
        {
            return newHero.strength + newHero.strength + newHero.stamina + newHero.agility + newHero.intelligence;
        }

        private void adjustPhysicalAttrPoints(int except)
        {
            // decrease overall value if points > 100
            bool decremented = false;
            while (getTotalPhysicalAttrPoints() > 100)
            {
                decremented = false;
                if (except != 0 && newHero.speed > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Speed
                    newHero.speed -= 1;
                    speedScrollBar.Value = newHero.speed;
                    speedValueLabel.Text = String.Format("{0}", newHero.speed);
                    decremented = true;
                }
                if (except != 1 && newHero.strength > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Strength
                    newHero.strength -= 1;
                    strengthScrollBar.Value = newHero.strength;
                    strengthValueLabel.Text = String.Format("{0}", newHero.strength);
                    decremented = true;
                }
                if (except != 2 && newHero.stamina > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Stamina
                    newHero.stamina -= 1;
                    staminaScrollBar.Value = newHero.stamina;
                    staminaValueLabel.Text = String.Format("{0}", newHero.stamina);
                    decremented = true;
                }
                if (except != 3 && newHero.agility > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Agility
                    newHero.agility -= 1;
                    agilityScrollBar.Value = newHero.agility;
                    agilityValueLabel.Text = String.Format("{0}", newHero.agility);
                    decremented = true;
                }
                if (except != 4 && newHero.intelligence > 0 && (getTotalPhysicalAttrPoints() > 100 || decremented))
                {
                    // Adjust Intellect
                    newHero.intelligence -= 1;
                    intellectScrollBar.Value = newHero.intelligence;
                    intelligenceValueLabel.Text = String.Format("{0}", newHero.intelligence);
                    decremented = true;
                }
            }
        }

       

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            newHero.name = nameTextBox.Text;
        }
        private void agePicker_ValueChanged(object sender, EventArgs e)
        {
            newHero.age = int.Parse(agePicker.Value.ToString());
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            newHero.age = int.Parse(agePicker.Value.ToString());
        }



        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            newHero.inception = dateTimePicker1.Value;
        }

        

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            newHero.daySavedEarth = dateTimePicker2.Value;
        }


        private void dateTimePicker3_ValueChanged_1(object sender, EventArgs e)
        {
            newHero.death = dateTimePicker3.Value;
        }

        private void experiencePicker_ValueChanged_1(object sender, EventArgs e)
        {
            newHero.yearsActive = int.Parse(experiencePicker.Value.ToString());
        }

        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            moralLeanVal.Text = string.Format("{0}", trackBar1.Value);
            newHero.moralLevel = trackBar1.Value;
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            // Challenge Open Color Picker Dialog
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = colorDialog1.Color;
            newHero.symbolColor = colorDialog1.Color.Name;

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Calculate All Abilities
            foreach (CheckBox c in abilitiesGroupBox.Controls.OfType<CheckBox>())
            {
                if (c.Checked == true)
                {
                    newHero.stats.Add(c.Text);
                }
            }

            // Calculate all Allegiences selected in allegiencesListBox
            for (int i = 0; i < affiliationListBox.Items.Count; i++)
            {
                if (affiliationListBox.GetItemChecked(i))
                {
                    newHero.teamAffiliation.Add(affiliationListBox.Items[i]);
                }
            }

            // Get office
            newHero.location = locationListBox.SelectedItem.ToString();

            // Get transport
            newHero.trasnportation = transportGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(n => n.Checked).Text;

            Console.Out.WriteLine("The Hero We're Sending Over...");
            Console.Out.Write(newHero.ToString());

            // Send hero to Display Form
            Heroes nextForm = new Heroes(newHero);

            this.Hide();
            nextForm.Show();

        }

        private void speedScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            speedValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.speed = e.NewValue;

            adjustPhysicalAttrPoints(0);
        }

        private void strengthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            strengthValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.strength = e.NewValue;

        }

        private void staminaScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            staminaValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.stamina = e.NewValue;

            adjustPhysicalAttrPoints(2);
        }

        private void agilityScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            agilityValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.agility = e.NewValue;

            adjustPhysicalAttrPoints(3);
        }

        private void intellectScrollBar_Scroll_1(object sender, ScrollEventArgs e)
        {
            intelligenceValueLabel.Text = String.Format("{0}", e.NewValue);
            newHero.intelligence = e.NewValue;

            adjustPhysicalAttrPoints(4);
        }

        private void abilitiesGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
