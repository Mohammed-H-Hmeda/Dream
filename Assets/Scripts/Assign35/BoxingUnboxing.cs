using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign35
{
    

public class BoxingUnboxing : MonoBehaviour
{
    int speed=100;
    // Start is called before the first frame update
    void Start()
    {
        object box=speed;
        int unbox=(int)box;
        unbox+=10;
        Debug.Log(speed);
        Debug.Log(box);
        Debug.Log(unbox);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}