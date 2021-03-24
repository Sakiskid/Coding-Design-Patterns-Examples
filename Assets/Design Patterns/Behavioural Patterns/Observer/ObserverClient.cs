using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Observer {
    /// <summary>Client for user interface, for user to manage Subjects and Observers.</summary>
    public class ObserverClient : MonoBehaviour
    {
        private Subject fashionCompany = new Subject();
        private int numOfFashionistas = 0;
        
        /// <summary>Creates a new fashionista and subscribes it to the Fashion Company</summary>
        public void CreateNewFashionista () {
            // Increase to keep track of id - not related to pattern
            numOfFashionistas++;
            // Create a new fashionista
            Observer newFashionista = new Observer(numOfFashionistas);
            // Let the fashion company know they have a new subscriber
            fashionCompany.Attach(newFashionista);
        }

        public void ChangeColorOfTheWeek () {
            fashionCompany.ChangeColorOfTheWeek();
        }
    }
}