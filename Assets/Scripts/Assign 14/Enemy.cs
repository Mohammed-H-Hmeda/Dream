using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign14
{
    public class Enemy : Character
    {
        Character Player=new Character("",0);
        public Enemy(string Charname, int Charhealth) : base(Charname, Charhealth)
        {

        }
        public int attack(int amount)
        {   
            Health -= amount;
            return Health;
        }


    }
}