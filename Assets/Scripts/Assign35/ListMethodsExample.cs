using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign35
{


    public class ListMethodsExample : MonoBehaviour
    {
        List<int> nums = new List<int> { 55, 10, 12, 10, 7, 8, 100 };
        List<int> nums2 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
        // Start is called before the first frame update
        void Start()
        {
            nums.Sort((int x, int y) => y.CompareTo(x));
            Debug.Log(string.Join(",", nums));

            List<int> FilteredList = nums2.FindAll((int num) => num % 2 == 0);
            Debug.Log(string.Join(",", FilteredList));
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}