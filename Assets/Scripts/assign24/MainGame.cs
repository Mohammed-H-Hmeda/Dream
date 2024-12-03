using System.Collections;
using System.Collections.Generic;
using assing21;
using JetBrains.Annotations;
using UnityEngine;
namespace assing21{

public class MainGame : MonoBehaviour
{
    public Racestate raceState;
    public void Simulaterace(){
        switch(raceState){
            case Racestate.Start:
            Debug.Log("Ready...Steady...set...GO!");
            break;
            case Racestate.Accelerate:
            Debug.Log("Faster! Faster! FASTER!!!");
            break;
            case Racestate.Turn:
            Debug.Log("Be careful on that turn");
            break;
            case Racestate.Crash:
            Debug.Log("Ohhhhhh....That hurts");
            break;
            case Racestate.Finish:
            Debug.Log("We have a winnnerrrr!!!!");
            break;
            default:Debug.Log("Waiting");
            break;
        
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Simulaterace();
        
    }
}
}