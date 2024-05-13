using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public class Queen : Character {
	public override void Fight() {
		Console.WriteLine("I'm the Queen and I'm fighting!");
	}

	public Queen(IWeaponBehavior weapon) : base(weapon) { }
}
