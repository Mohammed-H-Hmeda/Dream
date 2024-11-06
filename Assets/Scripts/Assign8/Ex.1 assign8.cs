using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class Githubassign : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    int counter=20;
    while (counter>0){
        int numbers=Random.Range(1,21);
        if (numbers==5)
            continue;
        else if (numbers==15)
            break;
        Debug.Log(numbers);
        --counter;
    }
    
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
