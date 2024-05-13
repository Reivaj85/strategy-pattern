using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public class King : Character {
	public override void Fight() {
		Console.WriteLine("I'm the King and I'm fighting!");
	}

	public King(IWeaponBehavior weapon) : base(weapon) { }
}
