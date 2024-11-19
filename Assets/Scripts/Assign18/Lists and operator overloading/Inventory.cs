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

        public static Inventory operator +(Inventory invey1, Inventory invey2)
        {


            Inventory bigInv = new Inventory();
            foreach (string item in invey1.Invey)
            {
                bigInv.AddItem(item);
            }
            foreach (string item in invey2.Invey)
            {
                bigInv.AddItem(item);
            }
            return bigInv;


        }
    }
}