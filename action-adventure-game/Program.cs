using action_adventure_game.Domain.Entities;
using action_adventure_game.Domain.Services;

Console.WriteLine("Starting the game!");

//Create characters
Character king = new King();
Character queen = new Queen();
Character knight = new Knight();
Character troll = new Troll();

//Set behaviors of weapons
king.SetBehavior(new KnifeBehavior());
queen.SetBehavior(new BowAndArrowBehavior());
knight.SetBehavior(new SwordBehavior());
troll.SetBehavior(new AxeBehavior());

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
Console.ReadKey();