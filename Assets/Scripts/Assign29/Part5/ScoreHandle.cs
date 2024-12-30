using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign29
{
    public class ScoreHandle : MonoBehaviour
    {
        //Declare two int variables:
        public int score = 100;
        public int diviser = 0;
        public int result;

        void Start()
        {
            /*Attempt to calculate the player's total score by dividing playerScore by
            diviser.*/
            try
            {
                //Log "Attempting to calculate score multiplier...".
                Debug.Log("Attempt to calculate players score");

                //Use the formula: int totalScore = playerScore / diviser;
                result = score / diviser;
            }

            //Catch the DivideByZeroException.
            catch
            {

                /*Log an error message: "Error: Division by zero occurred
                while calculating score multiplier.".*/
                Debug.LogError("Error: Division by zero occurred while calculating score multiplier.");
            }

            finally
            {

                /*Log "Score calculation complete. Cleaning up
                resources.".*/
                Debug.Log("Score calculation complete. Cleaning up resources.");
            }
        }

        void Update()
        {

        }
    }
}