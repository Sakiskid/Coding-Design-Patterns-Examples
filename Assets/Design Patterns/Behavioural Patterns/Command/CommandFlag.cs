namespace DesignPatterns.Command {
    // receiver 
    public class Flag
    {
        public void PickUp (CommandPlayer player) {
                GUIConsole.Instance.Log($"{player.GetPlayerName()} has the flag!");
        }
    }
}