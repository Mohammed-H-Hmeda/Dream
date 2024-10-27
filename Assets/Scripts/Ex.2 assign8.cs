using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class AGithubassign : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string [] words= {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int counter=7;
        string sentance="";
        while (counter>0){
            int index=Random.Range(0,10);
            string Randomword= words[index];
            sentance+=Randomword+" ";
            if (counter==1)
                Debug.Log(sentance);
            --counter;
         }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
