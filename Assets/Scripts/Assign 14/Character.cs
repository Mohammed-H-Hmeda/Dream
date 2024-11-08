using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Character
{
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }
    public int Health
    {
        get
        {
            return Health;
        }
        set
        {
            if (value <= 100)
            {
                Health = value;
            }
            else
                Debug.LogWarning("health should'nt be more than 100");
        }
    }
    public Character(string playername, int playerhealth)
    {
        Health = playerhealth;
        Name = playername;
    }


}
