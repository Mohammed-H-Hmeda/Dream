using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign35{
public class MulticastDelegateExample : MonoBehaviour
{
    public delegate void MathOperation(int num);
    MathOperation operations;
    public void Doublenum(int num)=>print(num*2);
    public void SquareNumber(int num)=>print(num*num);
    public void CubeNumber(int num)=>print(num*num*num);



    // Start is called before the first frame update
    void Start()
    {

        operations+=Doublenum;
        operations+=SquareNumber;
        operations+=CubeNumber;

        operations(5);


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}