using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Define a namespace named Assignment18 to contain all classes and structs
for this assignment.*/
namespace Assign18
{
/*Inside the namespace, create a Position struct.*/
    public struct Position
    {
        //Add three public fields: float X, float Y, and float Z.
        public float x;
        public float y;
        public float z;
        //Implement a constructor to initialize these fields.
        public Position(float posX, float posY, float posZ)
        {
            x = posX;
            y = posY;
            z = posZ;

        }
        /*Add a printPosition() method to output X, Y, and Z values using
        Debug.Log().*/
        public void printPosition()
        {
            Debug.Log("x position is:" + x);
            Debug.Log("y position is:" + y);
            Debug.Log("z position is:" + z);

        }
    }
}