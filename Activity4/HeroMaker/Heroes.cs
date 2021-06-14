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
    public partial class Heroes : Form
    {
        SuperHeroList heroList;

        BindingSource heroListBinding = new BindingSource();
        public Heroes(SuperHero hero)
        {
            InitializeComponent();
            heroList = new SuperHeroList();
            heroList.listOfHeroes.Add(hero);
            Console.Out.WriteLine(heroList.listOfHeroes[0].ToString());
            // Bind ArrayList to ListBox
            heroListBinding.DataSource = heroList.listOfHeroes;
            heroesListBox.DataSource = heroListBinding;
            heroesListBox.DisplayMember = "name";
            heroesListBox.ValueMember = "name";
        }

       

        

        private void heroesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SuperHero selectedItem = (SuperHero)heroesListBox.Items[heroesListBox.SelectedIndex];
            heroInfoBox.Text = selectedItem.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            HeroForm previousForm = new HeroForm();
            this.Hide();
            previousForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
