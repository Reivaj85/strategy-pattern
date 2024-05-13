using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Services;

public class KnifeBehavior : IWeaponBehavior {
	public void UseWeapon() {
		Console.WriteLine("I'm using a knife!");
	}
}
