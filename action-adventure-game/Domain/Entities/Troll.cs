using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public class Troll : Character {
	public override void Fight() {
		Console.WriteLine("I'm the Troll and I'm fighting!");
	}

	public Troll(IWeaponBehavior weapon) : base(weapon) { }
}
