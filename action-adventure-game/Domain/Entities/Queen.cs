namespace action_adventure_game.Domain.Entities;

public class Queen : Character {
	public override void Fight() {
		Console.WriteLine("I'm the Queen and I'm fighting!");
	}
}
