using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign35
{
    public class BuiltInDelegatesExample : MonoBehaviour
    {
        Action logmessage = () => Debug.Log("Hello from Action delegate!");
        Func<int, int> squareNum = (int num) => num * num;
        Predicate<int> isEven = (int num) => num % 2 == 0;
        // Start is called before the first frame update
        void Start()
        {
            logmessage();
            Debug.Log($"Square:{squareNum(5)}");
            Debug.Log($"Is 4 even?{isEven(4)}");

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}