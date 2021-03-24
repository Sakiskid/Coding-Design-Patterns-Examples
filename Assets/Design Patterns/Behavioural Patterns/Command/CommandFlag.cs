namespace DesignPatterns.Command {
    /// <summary>
    /// This class represents a flag in capture the flag.
    /// </summary>
    /// <remarks>This is considered the "Receiver" in the Command pattern</remarks>
    public class Flag
    {
        public void PickUp (CommandPlayer player) {
                GUIConsole.Instance.Log($"{player.GetPlayerName()} has the flag!");
        }
    }
}