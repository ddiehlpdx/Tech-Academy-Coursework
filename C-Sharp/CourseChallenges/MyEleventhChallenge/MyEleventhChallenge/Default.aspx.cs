using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyEleventhChallenge {
	public partial class Default : System.Web.UI.Page {

		public string attacker = "";
		public string defender = "";
		public int damage;
		string bonusText = "";

		protected void Page_Load(object sender, EventArgs e) {
			
				//INITIALIZE CHARACTER OBJECTS AND DECLARE STARTING STATS
				Character hero = new Character();
				hero.Name = "Elizabeth Warrin'";
				hero.Health = 666;
				hero.DamageMax = 100;
				hero.AttackBonus = false;

				Character monster = new Character();
				monster.Name = "Donald Troll";
				monster.Health = 600;
				monster.DamageMax = 85;
				monster.AttackBonus = false;

				Dice dice = new Dice();

				while(hero.Health > 0 && monster.Health > 0) {
					damage = hero.Attack(hero, dice);
					if(damage >= ((double)hero.DamageMax * .8)) {
						damage += hero.Attack(hero, dice);
						resultLabel.Text += "<br /><strong>" + hero.Name + " bonus attack! Critical hit for " + damage + "</strong><br />".ToString();
					}
					monster.Defend(damage);

					damage = monster.Attack(monster, dice);
					if (damage >= ((double)monster.DamageMax * .8)) {
						damage += monster.Attack(monster, dice);
						resultLabel.Text += "<br /><strong>" + monster.Name + " bonus attack! Critical hit for " + damage + "</strong><br />".ToString();
					}
					hero.Defend(damage);

					updateStatus(hero, monster);
				}
		}

		private void updateStatus(Character hero, Character monster) {
			resultLabel.Text += String.Format("<br /><strong>{0}</strong><br />Health: {1}<br />Max Damage: {2}<br />", hero.Name, hero.Health, hero.DamageMax);
			resultLabel.Text += String.Format("<br /><strong>{0}</strong><br />Health: {1}<br />Max Damage: {2}<br />", monster.Name, monster.Health, monster.DamageMax);
			if(hero.Health <= 0) {
				resultLabel.Text += "<br /><br />Somehow, in spite of his tiny hands and room-temperature IQ, " + monster.Name + " has won (again). It's a sad day for the internet";
			}
			else if(monster.Health <= 0) {
				resultLabel.Text += "<br /><br />" + hero.Name + " has crushed " + monster.Name + " with the powers of reason and common sense! The world makes sense again!";
			}
		}
	}

	class Character {
		public string Name { get; set; }
		public int Health { get; set; }
		public int DamageMax { get; set; }
		public bool AttackBonus { get; set; }

		//ATTACK METHOD - SET DICE SIDES PROP BASED ON CHARACTERS MAX DAMAGE PROP
		public int Attack(Character character, Dice dice) {
			dice.Sides = character.DamageMax;
			return dice.Roll(dice.Sides);
		}

		//DEFEND METHOD - APPLY DAMAGE INFLICTED BY ATTACK METHOD AND SET THE NEXT TURN
		public void Defend(int damage) {
			this.Health -= damage;
		}
	}

	class Dice {
		public int Sides { get; set; }
		Random random = new Random();
		
		public int Roll(int sides) {
			return random.Next(sides);
		}
	}
}