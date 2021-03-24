using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer {
    /// <summary>
    /// Interface for Subjects, they need to implement these methods because they are necessary to functionality for observer pattern
    /// </summary>
    public interface ISubject {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    /// <summary>
    /// Subject for observers to subscribe to.
    /// </summary>
    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private string colorOfTheWeek = "black";

        /// <summary>Subscribe an observer to the subject.</summary>
        /// <param name="observer">The observer to subscribe</param>
        public void Attach (IObserver observer) {
            observers.Add(observer);
            GUIConsole.Instance.Log("Subject: Adding observer to subscription list!");
        }

        /// <summary>Unsubscribe an observer from the subject.</summary>
        /// <param name="observer">The observer to unsubscribe</param>
        public void Detach (IObserver observer) {
            observers.Add(observer);
            GUIConsole.Instance.Log("Subject: Removing observer from subscription list :(");
        }

        /// <summary>Notify all observers of the new color of the week.</summary>
        /// <remarks>Note: This can also pass the current Subject to the observer if we want to access Properties or more from the observer.</remarks>
        public void Notify () {
            GUIConsole.Instance.Log("Subject: Notifying observers of new color of the week...");
            foreach (IObserver observer in observers)
            {
                observer.OnNotify(colorOfTheWeek);
            }
        }

        /// <summary>Change the color of the week, then Notify all observers.</summary>
        public void ChangeColorOfTheWeek() {
            // Declare colors and select a random color.
            string[] colors = {"black", "white", "red", "green", "blue", "mustard yellow", "tapioca purple", "titanium white"};
            int index = Random.Range(0, colors.Length - 1);
            colorOfTheWeek = colors[index];

            Notify();
        }

        public string GetColorOfTheWeek() {
            return colorOfTheWeek;
        }
    }
}