using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign14
{
    public class Player : Character
    {

        public Player(string Charname, int Charhealth) : base(Charname, Charhealth)
        {

        }
        public int Heal(int amount)
        {
            Health = Health + amount;
            return Health;

        }

    }
}

