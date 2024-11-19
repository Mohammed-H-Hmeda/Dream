using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign16
{
    /*In the same namespace, create two child classes Soldier that inherit from Character.*/
    public class Soldier : Character
    {
        /*Each child class should have a parameterized constructor to initialize
        name, Health, and position by calling the base constructor.*/
        public Soldier(string charName, int charhealth, Position charposition) : base(charName, charhealth, charposition)
        {

        }
        // //and the default constructor for Soldier.
        public Soldier() : base()
        {

        }
        /*Override the DisplayInfo() method in both child classes:
■       Add Debug.Log("Soldier") for Soldier*/
        override public void DisplayInfo()
        {
            Debug.Log("soldier");
            /*Call the base DisplayInfo() method using
            base.DisplayInfo() to display information from Character.*/
            base.DisplayInfo();
        }
    }
}