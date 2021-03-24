namespace DesignPatterns.Command {
    /// <summary>
    /// This is the "Player". In the command pattern, this is known as the invoker.
    /// </summary>
    public class CommandPlayer
    {
        private string playerName;
        
        // Constructor
        public CommandPlayer (string playerName) {
            this.playerName = playerName;
        }
        
        // Custom get method
        public string GetPlayerName () {
            return playerName;
        }


        public void Execute (ICommand command) {
            command.Execute();
        }
    }
}