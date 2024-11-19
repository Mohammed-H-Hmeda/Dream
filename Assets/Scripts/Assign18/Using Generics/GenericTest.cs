using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign18
{
    public class GenericTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            GameContainer<string> containers = new GameContainer<string>();

            containers.SetItem("Helath Potion");
            containers.Getitem();


            GameUtiles.DescribeItem(containers.itemsStorage);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}