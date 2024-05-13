using action_adventure_game.Domain.Interfaces;

namespace action_adventure_game.Domain.Entities;

public abstract class Character {
	public IWeaponBehavior Weapon { get; private set; }

	public void SetBehavior(IWeaponBehavior weaponBehavior) {
		Weapon = weaponBehavior;
	}
	public abstract void Fight();
}
