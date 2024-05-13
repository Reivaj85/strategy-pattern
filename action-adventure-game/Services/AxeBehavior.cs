using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Services;

public class AxeBehavior : IWeaponBehavior {
	public void UseWeapon() {
		Console.WriteLine("I'm using an axe!");
	}
}
