using DesignPatterns.State;
using UnityEngine;

public class StateClient : MonoBehaviour
{
    Player player = new Player(new StateStand());
    // These methods would normally be called from player input, or other sources (for example, if the player is forced to crouch)

    public void StandUp () {
        player.StandUp();
    }

    public void LieDown () {
        player.LieDown();
    }
}
