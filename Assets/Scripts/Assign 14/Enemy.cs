using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{


    public int attack(int amount)
    {
        Health -= amount;
        return Health;
    }

}
