using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
namespace assign29
{
    public class TypeManagement : MonoBehaviour
    {
        void Start()
        {
            //Create a Cat object and upcast it (implicitly) to an Animal reference.
            Cat bsbs = new Cat();
            Animal WildCat = bsbs;

            //Call both MakeSound() and Move() on the upcasted reference.
            WildCat.Makesound();
            WildCat.Move();

            /*Downcast the Animal reference back to a Cat object using the as
            keyword.*/
            Cat bsbos = WildCat as Cat;

            //Call both MakeSound() and Move() on the downcasted object.
            bsbos.Makesound();
            bsbos.Move();

            Warrior Thor = new Warrior();

            /*Create a List of ICanFight objects containing instances of both Cat and
            Warrior.*/
            List<ICanFight> WeCanFight = new List<ICanFight> { bsbs, Thor };

            //Iterate through the list and call Attack() on each object.
            foreach (ICanFight fighter in WeCanFight)
            {
                fighter.attack();
            }

            //Use the is keyword to check whether the current object is a Cat or a Warrior.
            /*Log "The object is a Cat." or "The object is a Warrior." based
            on the result of checking.*/
            if (Thor is Warrior)
            {
                Debug.Log("Thor is a warrior");

            }
            if (bsbs is Cat)
            {
                Debug.Log("bsbs can be bsbesed");
            }


        }

    }

    //Create a Derived Class Cat:
    //Implement ICanFight in the Cat Class:
    public class Cat : Animal, ICanFight
    {
        //Override the MakeSound() method to log "Meow!".
        public override void Makesound()
        {
            Debug.Log("Meow");
        }
        //Add Move() method to log "Cat runs quickly.".
        public void Move()
        {
            Debug.Log("Cat runs quickly");
        }
        //Add an Attack() method that logs "Cat attacks with claws!".
        public void attack()
        {
            Debug.Log("Cat attacks with claws!");
        }

    }

    //Create a New Class Warrior:
    //Implement the ICanFight interface.
    public class Warrior : ICanFight
    {
        //Add an Attack() method that logs "Warrior attacks with a sword!".
        public void attack()
        {
            Debug.Log("Warrior attacks with a sword!");
        }
    }

    //Create an Interface ICanFight:
    public interface ICanFight
    {
        //Add a method Attack().
        public void attack();
    }

    //Create a Base Class Animal:
    public class Animal
    {

        //Add a virtual method MakeSound() that logs "Animal sound".
        public virtual void Makesound()
        {
            Debug.Log("Animal sound");
        }

        //Add a method Move() that logs "Animal moves.".
        public void Move()
        {
            Debug.Log("Animal moves");
        }

    }
}





