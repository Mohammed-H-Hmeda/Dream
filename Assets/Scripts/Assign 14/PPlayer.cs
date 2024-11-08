using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PPlayer : Character
{


    public int Heal(int amount)
    {
        Health = Health + amount;
        return Health;

    }

}


