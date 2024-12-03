using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
namespace Assign18
{
    public class Inventory
    {

        private List<string> Invey = new List<string>();
        public void AddItem(string item)
        {
            Invey.Add(item);

        }
        public void ShowItem(Inventory inventy)
        {
            foreach (string item in inventy.Invey)
            {
                Debug.Log(item);
            }
        }
        //operator overloading allow us to create a function of operators to make them do custom behaviour
        //the parameters in it define this behaviour (when you add 2 objects of type Inventory do:)
        public static Inventory operator +(Inventory invey1, Inventory invey2)
        {


            Inventory bigInv = new Inventory();
            //invey1 is an instance so we use .invey to access the field that contain its items
            //you can't access any item in a list without a loop
            foreach (string item in invey1.Invey)
            {
                bigInv.AddItem(item);
            }
            //invey2 is an instance so we use .invey to access the field that contain its items
            foreach (string item in invey2.Invey)
            {
                bigInv.AddItem(item);
            }
            return bigInv;
            //instances themselves doesn't contain nothing only the fields in them


        }
    }
}