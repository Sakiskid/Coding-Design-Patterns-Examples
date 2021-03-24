namespace DesignPatterns.Command {
    public interface ICommand {
        /// <summary>Execute the command</summary>
        void Execute();
    }

    public class Spawn : ICommand {
        private CommandPlayer player;
        private string location;

        public Spawn (CommandPlayer player, string location) {
            this.player = player;
            this.location = location;
        }

        public void Execute () {
            GUIConsole.Instance.Log($"{player.GetPlayerName()} respawned at {location}.");
        }
    }

    // simple command
    public class HealSelf : ICommand
    {
        private CommandPlayer player;
        private int health;

        public HealSelf (CommandPlayer player, int health) {
            this.player = player;
            this.health = health;
        }

        public void Execute () {
            GUIConsole.Instance.Log($"Healing {player.GetPlayerName()} with {health} health! <3");
        }
    }

    // complex commands are sent to a receiver
    public class CaptureFlag : ICommand {
        private Flag flag;
        private CommandPlayer player;

        // Constructor for player reference
        public CaptureFlag(Flag flag, CommandPlayer player) {
            this.player = player;
            this.flag = flag;
        }

        public void Execute () {
            flag.PickUp(player);
        }
    }
}