using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Xml;

namespace CoreBuildInternshipProblem
{
    class Utils
    {
        public List<Character> LoadJsonFileCharacters(string fileName)
        {
            List<Character> characters;
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                characters = JsonConvert.DeserializeObject<List<Character>>(json);
            }
            return characters;
        }

        public List<Character> LoadXmlFileCharacters(string fileName)
        {
            List<Character> characters = new List<Character>();
            Character character = new Character();
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "description":
                                // Detect this element.
                                if (reader.Read())
                                {
                                    character.Description = reader.Value.Trim();
                                }
                                break;
                            case "id":
                                if (reader.Read())
                                {
                                    character.Id = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "name":
                                if (reader.Read())
                                { 
                                    character.Name = reader.Value.Trim();
                                }
                                break;
                            case "attack":
                                if (reader.Read())
                                {
                                    character.Attack = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "health":
                                if (reader.Read())
                                {
                                    character.Health = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "isVillain":
                                if (reader.Read())
                                {
                                    character.IsVillain = Boolean.Parse(reader.Value.Trim());
                                }
                                break;
                            
                        }
                    }
                    else
                    {
                        if (reader.Name == "character")
                        {
                            characters.Add(character);
                            character = new Character();
                        }

                    }
            
                }
            }



            return characters;
        }

        public List<Planet> LoadJsonFilePlanets(string fileName)
        {
            List<Planet> characters;
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                characters = JsonConvert.DeserializeObject<List<Planet>>(json);
            }
            return characters;
        }

        public List<Planet> LoadXmlFilePlanets(string fileName)
        {
            List<Planet> planets = new List<Planet>();
            Planet planet = new Planet();
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "description":
                                // Detect this element.
                                if (reader.Read())
                                {
                                    planet.Description = reader.Value.Trim();
                                }
                                break;
                            case "id":
                                if (reader.Read())
                                {
                                    planet.Id = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "name":
                                if (reader.Read())
                                {
                                    planet.Name = reader.Value.Trim();
                                }
                                break;
                            case "heroAttackModifier":
                                if (reader.Read())
                                {
                                    planet.HeroAttackModifier= Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "heroHealthModifier":
                                if (reader.Read())
                                {
                                    planet.HeroHealthModifier = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "villainAttackModifier":
                                if (reader.Read())
                                {
                                    planet.VillainAttackModifier = Int32.Parse(reader.Value.Trim());
                                }
                                break;
                            case "villainHealthModifier":
                                if (reader.Read())
                                {
                                    planet.VillainHealthModifier = Int32.Parse(reader.Value.Trim());
                                }
                                break;

                        }
                    }
                    else
                    {
                        if (reader.Name == "planet")
                        {
                            planets.Add(planet);
                            planet = new Planet();
                        }

                    }

                }
            }



            return planets;
        }
    }
}
