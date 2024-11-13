using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
namespace Assign14
{
    public class Character
    {
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int health;
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (health<100)
                {
                    health = value;
                }
               
            }
        }
        public Character(string Charname, int Charhealth)
        {
            health = Charhealth;
            name = Charname;
        }


    }
}
