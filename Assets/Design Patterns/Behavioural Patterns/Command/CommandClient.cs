using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Command {
    public class CommandClient : MonoBehaviour
    {
        [SerializeField] private string playerName = "Tyler";
        Flag flag;
        CommandPlayer player;

        private void Awake() {
            flag = new Flag();
            player = new CommandPlayer(playerName);
        }

        public void SpawnPlayer () {
            player.Execute(new Spawn(this.player, "Red Team HQ"));
        }

        public void HealPlayer () {
            player.Execute(new HealSelf(this.player, 100));
        }

        public void CaptureFlag () {
            player.Execute(new CaptureFlag(flag, player));
        }
    }
}