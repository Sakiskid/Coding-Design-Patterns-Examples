using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer {
    public interface ISubject {
        void Attach(IObserver observer);

        void Detach(IObserver observer);

        void Notify();
    }

    public class Subject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        public string colorOfTheWeek = "black";

        public void Attach (IObserver observer) {
            observers.Add(observer);
            GUIConsole.Instance.Log("Subject: Adding observer to subscription list!");
        }

        public void Detach (IObserver observer) {
            observers.Add(observer);
            GUIConsole.Instance.Log("Subject: Removing observer from subscription list :(");
        }

        public void Notify () {
            GUIConsole.Instance.Log("Subject: Notifying observers of new color of the week...");
            foreach (IObserver observer in observers)
            {
                observer.UpdateNewColor(colorOfTheWeek);
            }
        }

        public void ChangeColorOfTheWeek() {
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