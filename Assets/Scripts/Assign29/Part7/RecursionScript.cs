using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursionScript : MonoBehaviour
{
    /*Write a recursive method FibonacciRecursive(int n) that calculates the
    nth Fibonacci number.*/
    int FibonacciRecursive(int num)
    {
        if (num == 1) return 1;
        if (num <= 0) return 0;
        else { return FibonacciRecursive(num - 1) + FibonacciRecursive(num - 2); }
    }

    /*Write an iterative method (using a loop) FibonacciIterative(int n) that
    calculates the nth Fibonacci number using a loop.*/
    int FibonacciIterative(int num)
    {

        int result = 1;
        int prev = 0;
        for (int i = 2; i <= num; i++)
        {
            result = result + prev;
            prev = result - prev;
        }
        return result;

    }






    // Start is called before the first frame update
    void Start()
    {
        //Log the results of both methods for n = 10 and n = 30.
        int recResult = FibonacciRecursive(10);
        Debug.Log(recResult);
        int IteResult = FibonacciIterative(5);
        Debug.Log(IteResult);
    }

    // Update is called once per frame
    void Update()
    {


    }
}
