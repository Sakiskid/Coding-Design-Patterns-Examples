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
        List<IObserver> observers = new List<IObserver>();

        public void Attach (IObserver observer) {
            observers.Add(observer);
        }

        public void Detach (IObserver observer) {
            observers.Add(observer);
        }

        public void Notify () {

        }
    }
}