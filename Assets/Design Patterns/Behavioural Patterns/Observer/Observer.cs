using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer {
    public interface IObserver {
        /// <summary>When the Observer is notified, this method runs.</summary>
        /// <param name="colorOfTheWeek">The color of the week the observer is looking for.</param>
        void OnNotify(string colorOfTheWeek);
    }

    /// <summary>Observer to watch for Subject events.</summary>
    public class Observer : IObserver
    {
        // Constructor for Observer to set ID of the observer created
        public Observer (int id) {
            this.id = id;
        } 
        
        private int id;

        public void OnNotify (string colorOfTheWeek) {
            GUIConsole.Instance.Log($"Observer #{id}: Recieved new color of the week! Going to be wearing {colorOfTheWeek} all week!");
        }
    }
}