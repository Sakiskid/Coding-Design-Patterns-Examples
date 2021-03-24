using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer {
    public interface IObserver {
        void UpdateNewColor(string colorOfTheWeek);
    }

    public class Observer : IObserver
    {
        private int id;

        public Observer (int id) {
            this.id = id;
        } 

        public void UpdateNewColor (string colorOfTheWeek) {
            GUIConsole.Instance.Log($"Observer #{id}: Recieved new color of the week! Going to be wearing {colorOfTheWeek} all week!");
        }
    }
}