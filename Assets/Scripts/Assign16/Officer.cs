using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign16
{
    /*and Officer that
i   nherit from Character.*/
    public class Officer : Character
    {
        /*Each child class should have a parameterized constructor to initialize
        name, Health, and position by calling the base constructor.*/
        public Officer(string charName, int charhealth, Position charposition) : base(charName, charhealth, charposition)
        {

        }
        //Override the DisplayInfo() method in both child classes:
        //Debug.Log("Officer") for Officer at the start of the method.
        override public void DisplayInfo()
        {
            Debug.Log("Officer");
            /*Call the base DisplayInfo() method using
            base.DisplayInfo() to display information from Character.*/
base.DisplayInfo();
        }
    }
}
