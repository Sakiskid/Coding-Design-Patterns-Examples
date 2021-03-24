using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DesignPatterns.Factory {
    public class Square : IShape
    {
        public string Details() {
            return "Heavy, metal square with sharp corners.";
        }
    }
}