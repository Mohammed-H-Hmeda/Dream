using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character Player = new Character("MO", 100);
        Character Enemy = new Character("KID", 100);
        Debug.Log(Player.Name);
        Debug.Log(Player.Health);
        Debug.Log(Enemy.Name);
        Debug.Log(Enemy.Health);

        Player.Heal(100);
        Enemy.Attack(50);







    }

    // Update is called once per frame
    void Update()
    {

    }
}
