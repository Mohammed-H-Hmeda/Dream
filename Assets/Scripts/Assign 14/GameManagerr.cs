using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign14
{
    public class GameManagerr : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Player Player = new Player("MO", 100);
            Enemy Enemy = new Enemy("KIDO", 100);
            Player.health = 10;
            Enemy.health = 90;
            Debug.Log(Player.Name);
            Debug.Log(Player.Health);
            Debug.Log(Enemy.Name);
            Debug.Log(Enemy.Health);
            Player.Heal(20);
            Enemy.attack(10);
            Debug.Log(Player.Health);










        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}