using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreBuildInternshipProblem.Properties;
using Newtonsoft.Json; 
using Newtonsoft.Json.Serialization;


namespace CoreBuildInternshipProblem
{
    public partial class Form1 : Form
    {
        List<Character> characters;
        List<Planet> planets;
        Character hero = new Character();
        Character villain = new Character();
        Planet planet = new Planet();
        List<Character> heros = new List<Character>();
        List<Character> villains = new List<Character>();
        Utils utils = new Utils();

        string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        
        public Form1()
        {
            InitializeComponent();
            progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            avengersList.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string appPath = Path.GetDirectoryName(Application.ExecutablePath);
            string platesFile = appPath + @"\Resources\planets.xml";
            string charactersFile = appPath + @"\Resources\characters.xml";

            try
            {
                planets = utils.LoadXmlFilePlanets(platesFile);
                characters = utils.LoadXmlFileCharacters(charactersFile);  
            }
            catch(Exception ex)
            {
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
                planets = utils.LoadXmlFilePlanets(projectDirectory + @"\Resources\planets.xml");
                characters = utils.LoadXmlFileCharacters(projectDirectory + @"\Resources\characters.xml");
            }

            populateComboBox();
            avengersList.Visible = false;


        }

        private void populateComboBox()
        {
            planetComboBox.DataSource = planets;

            planetComboBox.DisplayMember = "Name";

            Character hero = new Character();
            Character villain = new Character();
            Planet planet = new Planet();

            try
            {
                foreach (Character character in characters)
                {
                    if (character.IsVillain)
                    {
                        villains.Add(character);
                    }
                    else
                    {
                        heros.Add(character);
                    }
                }

                heroComboBox.DataSource = heros;
                heroComboBox.DisplayMember = "Name";

                villainComboBox.DataSource = villains;
                villainComboBox.DisplayMember = "Name";

                int indexP = planetComboBox.SelectedIndex;
                modifyHealthAndAttack();


                
            }
            catch(Exception ex)
            {

            }
        }

        private void modifyHealthAndAttack()
        {          
            int indexP = planetComboBox.SelectedIndex;
            if (indexP >= 0) planet = (Planet) planets[indexP].Clone();

            int indexH = heroComboBox.SelectedIndex;
            if (indexH >= 0) hero = (Character) heros[indexH].Clone();

            int indexV = villainComboBox.SelectedIndex;
            if (indexV >= 0)  villain = (Character) villains[indexV].Clone();

            hero.Attack += planet.HeroAttackModifier;
            hero.Health += planet.HeroHealthModifier;

            villain.Attack += planet.VillainAttackModifier;
            villain.Health += planet.VillainHealthModifier;

            updateHealth();

        }

        private void updateHealth()
        {
            heroLife.Text = hero.Health.ToString();
            villainLife.Text = villain.Health.ToString();
        }

        private void heroComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyHealthAndAttack();
            progressBar2.Value = 100;
            progressBar1.Value = 100;

        }

        private void villainComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyHealthAndAttack();
            progressBar2.Value = 100;
            progressBar1.Value = 100;
        }

        private void planetComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            modifyHealthAndAttack();
            progressBar2.Value = 100;
            progressBar1.Value = 100;

        }

        private void warButton_Click(object sender, EventArgs e)
        {
            modifyHealthAndAttack();
            progressBar2.Value = 100;
            progressBar1.Value = 100;
            avengersList.Visible = false;
            textBox1.Text = "";
            textBox1.ScrollBars = ScrollBars.Vertical;
            Random random = new Random();
            int initialHealthHero = hero.Health;
            int initialHealthVillain = villain.Health;
            int randomAttack;

            while (hero.Health > 0 && villain.Health > 0)
            {
               
                if (hero.Health > 0 && villain.Health >  0)
                {
                    randomAttack = random.Next(60, 100);
                    int villainAttack = (villain.Attack * randomAttack) / 100;
                    textBox1.Text += "Attack " + villain.Name + " with " + villainAttack.ToString() + " damage." + Environment.NewLine;
                    hero.Health -= villainAttack;

                    if (hero.Health > 0)
                        progressBar1.Value = (hero.Health * 100) / initialHealthHero;
                    else
                        progressBar1.Value = 0;

                }

                updateHealth();

                if (hero.Health > 0 && villain.Health > 0)
                {
                    randomAttack = random.Next(60, 100);
                    int heroAttack = (hero.Attack * randomAttack) / 100;
                    textBox1.Text += "Attack " + hero.Name + " with " + heroAttack.ToString() + " damage." + Environment.NewLine;
                    villain.Health -= heroAttack;

                    if (villain.Health > 0)
                        progressBar2.Value = (villain.Health * 100) / initialHealthVillain;
                    else
                        progressBar2.Value = 0;
                }

                updateHealth();

            }
            if (hero.Health > 0)
            {
                textBox1.Text += Environment.NewLine + hero.Name + " won!" + Environment.NewLine;
            }
            else
            {
                textBox1.Text += Environment.NewLine + villain.Name + " won!" + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Character> avengers = new List<Character>();
            avengersList.Visible = true;
            textBox1.Text = "";

            int indexP = planetComboBox.SelectedIndex;
            if (indexP >= 0) planet = (Planet)planets[indexP].Clone();

            int indexV = villainComboBox.SelectedIndex;
            if (indexV >= 0) villain = (Character)villains[indexV].Clone();

            hero.Attack += planet.HeroAttackModifier;
            hero.Health += planet.HeroHealthModifier;

            villain.Attack += planet.VillainAttackModifier;
            villain.Health += planet.VillainHealthModifier;


            textBox1.ScrollBars = ScrollBars.Vertical;
            progressBar2.Value = 100;
            progressBar1.Value = 100;
            avengersList.Text = "Avengers List:" + Environment.NewLine;
            Random random = new Random();
            int initialHealthHero = 0;
            int initialHealthVillain = villain.Health;
            int numberOfAvengers = random.Next(3, heros.Count);
            int avengersHealth = 0;
            while(avengers.Count < numberOfAvengers)
            {
                int index = random.Next(0, heros.Count - 1);
                Character avenger = (Character)heros[index].Clone();
                bool isFound = false;
                foreach(Character character in avengers)
                {
                    if(character.Id == avenger.Id)
                    {
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    avengersList.Text += avenger.Name + Environment.NewLine;

                    avenger.Attack += planet.HeroAttackModifier;
                    avenger.Health += planet.HeroHealthModifier;

                    avengers.Add(avenger);
                    initialHealthHero += avenger.Health;
                }
            }
            avengersHealth = initialHealthHero;

            heroLife.Text = avengersHealth.ToString();
            villainLife.Text = villain.Health.ToString();

            int randomAttack;

            while (avengersHealth > 0 && villain.Health > 0)
            {

                if (avengersHealth > 0 && villain.Health > 0)
                {
                    randomAttack = random.Next(60, 100);
                    int villainAttack = (villain.Attack * randomAttack) / 100;
                    textBox1.Text += "Attack " + villain.Name + " with " + villainAttack.ToString() + " damage." + Environment.NewLine;
                    avengersHealth -= villainAttack;

                    if (avengersHealth > 0)
                        progressBar1.Value = (avengersHealth * 100) / initialHealthHero;
                    else
                        progressBar1.Value = 0;

                }

                updateHealth();

                if (avengersHealth > 0 && villain.Health > 0)
                {
                    randomAttack = random.Next(60, 100);
                    int randomAvenger = random.Next(0, avengers.Count - 1);
                    int heroAttack = (avengers[randomAvenger].Attack * randomAttack) / 100;
                    textBox1.Text += "Attack " + avengers[randomAvenger].Name + " with " + heroAttack.ToString() + " damage." + Environment.NewLine;
                    villain.Health -= heroAttack;

                    if (villain.Health > 0)
                        progressBar2.Value = (villain.Health * 100) / initialHealthVillain;
                    else
                        progressBar2.Value = 0;
                }

                updateHealth();
            }
            if (avengersHealth > 0)
            {
                textBox1.Text += Environment.NewLine + "Avengers won!" + Environment.NewLine;
            }
            else
            {
                textBox1.Text += Environment.NewLine + villain.Name + " won!" + Environment.NewLine;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            //this.Width = Screen.PrimaryScreen.Bounds.Width;
            //this.Height = Screen.PrimaryScreen.Bounds.Height;

            //float widthratio = this.width / 815f;
            //float heightratio = this.height / 490f;

            //sizef scale = new sizef(widthratio, heightratio);

            //this.scale(scale);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void uploadCharactersFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string extension = Path.GetExtension(openFileDialog1.FileName);
            if (extension == "json")
            {
                characters = utils.LoadJsonFileCharacters(openFileDialog1.FileName);
            }
            else
            {
                if (extension == "xml")
                {
                    characters = utils.LoadXmlFileCharacters(openFileDialog1.FileName);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Please select a JSON or XML file!", "File extension error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            populateComboBox();

            heroLife.Text = "";
            villainLife.Text = "";
        }

        private void uploadPlanetsFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.ShowDialog();
            string extension = Path.GetExtension(openFileDialog1.FileName);
            if (extension == "json")
            {
                planets = utils.LoadJsonFilePlanets(openFileDialog1.FileName);
            }
            else
            {
                if (extension == "xml")
                {
                    planets = utils.LoadXmlFilePlanets(openFileDialog1.FileName);
                }
                else
                {
                    DialogResult result;
                    result = MessageBox.Show("Please select a JSON or XML file!", "File extension error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

            populateComboBox();

            heroLife.Text = "";
            villainLife.Text = "";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string message = "Solution for CoreBuild Intership Problem \n (c) 2019, Pascalau Loredana Nicoleta";
            string caption = "About";
            result = MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
