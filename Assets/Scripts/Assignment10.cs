using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    int num=1;
     for(;num<11;num+=1)
     {
        
        Debug.Log(num+"x"+"5"+'='+Multiply(5,num));

        
     }
     int Multiply(int num1, int num2)
     {
        int mult = num1*num2;
        return mult;
     }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
