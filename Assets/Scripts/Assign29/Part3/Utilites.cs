using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
namespace assign29
{

}
public static class Utilites
{
    /*Adds a static method Add(params int[] numbers) that calculates
    and returns the sum of an array of numbers.*/
    public static int Add(params int[] numbers)
    {
        int sum = 0;
        foreach (int nums in numbers)
        {
            sum += nums;
        }
        return sum;
    }

    /*Write an extension method called RepeatString that repeats a string a
    specific number of times.*/
    public static string RepeatString(this string text, int number)
    {
        string sentance = "";
        while (number > 0)
        {
            sentance += text;
            number--;

        }
        return sentance;

    }
}
