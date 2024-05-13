using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public class Knight :  Character {
	public override void Fight() {
		Console.WriteLine("I'm the Knight and I'm fighting!");
	}

	public Knight(IWeaponBehavior weapon) : base(weapon) { }
}
