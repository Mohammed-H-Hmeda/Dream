using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
namespace Assign18
{
    //Within the same namespace, define a base class named Character.
    public class Character
    {
        //Add a public string name field,
        public string name;
        //a private int health field,
        private int health;
        //protected Position position field.
        protected Position position;
        /*Create a Health property with custom logic to restrict health to a
        minimum of 0 and a maximum of 100.*/
        public int Health
        {
            get
            {
                return this.health;

            }
            set
            {
                health = value;
                if (health < 0)
                {
                    health = 0;
                }
                else if (health > 100)
                {
                    health = 100;
                }
            }


        }
        //Implement two constructors:
        /*A parameterized constructor to initialize name, Health, and
        position.*/
        public Character(string charName, int charhealth, Position charposition)
        {

            this.name = charName;
            this.Health = charhealth;
            this.position = charposition;

        }
        /*A default constructor that uses constructor chaining to call the
        parameterized constructor with default values:*/
        public Character() : this("No name", 100, new Position(0, 0, 0))
        {

        }
        /*Add a virtual DisplayInfo() method to display name, Health, and use
        the printPosition() method from Position struct to output the
        position.*/
        virtual public void DisplayInfo()
        {
            Debug.Log("character Name is:" + name);
            Debug.Log("character health=" + Health);
            position.printPosition();

        }
        //Overload the Attack() method:
        /*The first overload of Attack takes int damage and Character
        target, reducing the target's Health by the specified damage
        amount.*/
        public void Attack(int damage, Character targert)
        {
            targert.Health -= damage;

        }
        /*The second overload takes int damage, Character target, and a
        string attackType (e.g., "shooting" or "kicking"). This method
        performs the same action as the first overload, while additionally printing
        the attackType (no need to store it).*/
        public void Attack(int damage, Character targert, string attackType)
        {
            /*Apply the DRY principle to avoid code duplication between the two
            overloaded methods.*/
            Attack(damage, targert);
            Debug.Log(attackType);

        }

    }
}