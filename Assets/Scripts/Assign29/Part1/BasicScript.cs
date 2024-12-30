using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign29
{
    public class BasicScript : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            //Declare three variables using var (an integer, a string, and a boolean).
            var integer = 6;
            var str = "Mohammed";
            var boo = true;
            //Use the ternary operator ?: to check if the integer is even or odd.
            string EvenOdd = integer % 2 == 0 ? "is even" : "is odd";
            /*Use string interpolation to create a message such as "The number 5 is
            odd." and log it using Debug.Log.*/
            Debug.Log($"The number {integer} {EvenOdd}");
            //Log the current date using System.DateTime.
            Debug.Log(DateTime.Now.Date);
            //Log the current time using System.DateTime.
            Debug.Log(DateTime.Now.TimeOfDay);
            //Log the current day using System.DateTime.
            Debug.Log(DateTime.Now.Day);




        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}