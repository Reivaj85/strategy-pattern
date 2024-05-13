using action_adventure_game.Domain.Entities;
using action_adventure_game.Services;

Console.WriteLine("Starting the game!");

//Create characters and set their weapons
Character king = new King(new KnifeBehavior());
Character queen = new Queen(new BowAndArrowBehavior());
Character knight = new Knight(new SwordBehavior());
Character troll = new Troll(new AxeBehavior());

//Fight
king.Fight();
king.Weapon.UseWeapon();

queen.Fight();
queen.Weapon.UseWeapon();

knight.Fight();
knight.Weapon.UseWeapon();

troll.Fight();
troll.Weapon.UseWeapon();

Console.WriteLine("Ending the game!");