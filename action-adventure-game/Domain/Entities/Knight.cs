namespace action_adventure_game.Domain.Entities;

public class Knight :  Character {
	public override void Fight() {
		Console.WriteLine("I'm the Knight and I'm fighting!");
	}
}
