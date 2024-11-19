using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign18
{
    public class GameInventory : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Inventory potionBag = new Inventory();
            potionBag.AddItem("Healing Potion");
            potionBag.AddItem("Strength Potion");
            Inventory ElixerBag = new Inventory();
            ElixerBag.AddItem("Elixer");
            ElixerBag.AddItem("Dark Elixer");
            Inventory Bigbag = potionBag + ElixerBag;
            Bigbag.ShowItem(Bigbag);



        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}