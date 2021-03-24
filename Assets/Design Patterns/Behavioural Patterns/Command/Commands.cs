namespace DesignPatterns.Command {
    /// <summary>Interface which implements the Execute() method in all commands</summary>
    public interface ICommand {
        /// <summary>Execute the command</summary>
        void Execute();
    }

    // This is a simple command. Respawns the player.
    public class Spawn : ICommand {
        private CommandPlayer player;
        private string location;

        /// <summary>Respawn a player in a select location.</summary>
        public Spawn (CommandPlayer player, string location) {
            this.player = player;
            this.location = location;
        }

        public void Execute () {
            GUIConsole.Instance.Log($"{player.GetPlayerName()} respawned at {location}.");
        }
    }

    // This is a simple command. Heals the player.
    public class Heal : ICommand
    {
        private CommandPlayer player;
        private int health;

        /// <summary>Heal the player by a select amount.</summary>
        /// <param name="health">Amount of health to give the player.</param>
        public Heal (CommandPlayer player, int health) {
            this.player = player;
            this.health = health;
        }

        public void Execute () {
            GUIConsole.Instance.Log($"Healing {player.GetPlayerName()} with {health} health! <3");
        }
    }

    // This is a complex command. The execution is delegated to a "receiver", where the hard work is done.
    public class CaptureFlag : ICommand {
        private Flag flag;
        private CommandPlayer player;

        // Constructor for player and flag reference
        public CaptureFlag(Flag flag, CommandPlayer player) {
            this.player = player;
            this.flag = flag;
        }

        // Delegate hard work to the receiver
        public void Execute () {
            flag.PickUp(player);
        }
    }
}