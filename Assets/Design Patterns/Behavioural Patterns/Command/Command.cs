namespace DesignPatterns.Command {
    public interface ICommand {
        /// <summary>Execute the command</summary>
        void Execute();
    }

    public class Spawn : ICommand {
        public void Execute () {
            GUIConsole.Instance.Log("");
        }
    }

    // simple command
    public class HealSelf : ICommand
    {
        public void Execute () {
            GUIConsole.Instance.Log("");
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
            GUIConsole.Instance.Log("");
        }
    }

    // reciever
    public class Flag {

    }
}