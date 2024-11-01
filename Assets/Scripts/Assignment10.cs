using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      string table="";
    //Define the Multiply Function:
    int Multiply(int num1, int num2)
     {
        int mult = num1*num2;
        return mult;
     }   
    int num=1;
    //In the Start method, create a for loop
     for(;num<11;num+=1)
     {
      
        table+=num+"x"+"5"+'='+Multiply(5,num);
        if (num<10)
        {
         table+=",";
        }
        else if (num==10){
         Debug.Log(table);
        }
     }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
