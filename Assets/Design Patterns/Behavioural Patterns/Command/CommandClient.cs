using UnityEngine;

namespace DesignPatterns.Command {
    /// <summary>Client for the user to interact with. Sends new commands to the player to execute.
    /// <remark>
    /// Normally, this would be different classes calling these methods based on game logic.
    /// For example, SpawnPlayer and CaptureFlag wouldn't actually be called from the GUI.
    /// </remark>
    /// </summary>
    public class CommandClient : MonoBehaviour
    {
        Flag flag = new Flag();
        CommandPlayer player = new CommandPlayer("Tyler");

        // These methods all send commands to the player.

        public void SpawnPlayer () {
            player.Execute(new Spawn(this.player, "Red Team HQ"));
        }

        public void HealPlayer () {
            player.Execute(new Heal(this.player, 100));
        }

        public void CaptureFlag () {
            player.Execute(new CaptureFlag(flag, player));
        }
    }
}