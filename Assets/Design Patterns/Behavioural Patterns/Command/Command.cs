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
            GUIConsole.Instance.Log($"{player.GetPlayerName()} spawned at {location}.");
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

    // complex command
    public class CaptureFlag : ICommand {
        private CommandPlayer player;

        // Constructor for player reference
        public CaptureFlag(CommandPlayer player) {
            this.player = player;
        }

        public void Execute () {
            GUIConsole.Instance.Log($"{player.GetPlayerName()} has the flag!");
        }
    }
}