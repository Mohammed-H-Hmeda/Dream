using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace assign27{
public class CallByValue : MonoBehaviour
{
    public void addition(int num)
    {
        num+=10;
    }
    public void refaddition(ref int num)
    {
        num+=10;
    }
    public void outaddition(out int num1)
    {
        num1=25;
    }
    // Start is called before the first frame update
    void Start()
    { 
        int num1=5;
        int num2=10;
        addition(num1);
        //result is 5 (doesn't change)
        Debug.Log("Calling by value "+num1);
        refaddition(ref num2);
        //result is 20
        Debug.Log("Calling by refernce "+ num2);
        outaddition(out num1);
        //result is 25
        Debug.Log("Calling by out "+ num1);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}