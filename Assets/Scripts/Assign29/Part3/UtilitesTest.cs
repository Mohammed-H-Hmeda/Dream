using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign29
{

}
public class UtilitesTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Uses the Utilities.Add method to log the sum of numbers.
        Debug.Log(Utilites.Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        /*Uses the RepeatString extension method with any string to log that
        string repeated n times on the same line*/
        Debug.Log(Utilites.RepeatString("Games", 5));

    }

    // Update is called once per frame
    void Update()
    {

    }
}
