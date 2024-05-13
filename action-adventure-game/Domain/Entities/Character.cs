using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public abstract class Character {
	
	public IWeaponBehavior Weapon { get; private set; }
	protected Character(IWeaponBehavior weapon) {
		Weapon = weapon;
	}
	public abstract void Fight();
}
