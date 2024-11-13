using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assign18
{
    /*Define a new class CharacterTest inheriting from MonoBehaviour for
    testing.*/
    public class CharacterTest : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            /*Inside CharacterTest, create instances of Soldier and Officer,
            storing them in a Character[] array.*/
            Character[] Characters = new Character[2];
            //Use the parameterized constructor for Officer
            Officer Max = new Officer("Max", 500, new Position(100, 200, 500));
            //and the default constructor for Soldier.
            Soldier Steve=new Soldier();
            Characters[0] = Max;
            Characters[1] = Steve;
            
            //Use a for loop to call DisplayInfo() on each element in the array, demonstrating polymorphism.
            for (int index = 0; index < 2; index++)
            {
                Characters[index].DisplayInfo();
            };
            //Make the object of Officer attack the object of Soldier and output the Soldier's Health before and after the attack.
            Debug.Log("soilder health before=" + Steve.Health);
            Max.Attack(10, Steve, "Shoot");
            Debug.Log("soilder health after=" + Steve.Health);


        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}