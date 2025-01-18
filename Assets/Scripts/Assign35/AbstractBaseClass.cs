using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign35
{
    public class TestAbstractClass : MonoBehaviour
    {
        void Start()
        {
            DerivedClassExample instance = new DerivedClassExample();
            instance.performaction();
            instance.printinfo();
        }

        void Update()
        {

        }
    }
    public abstract class TheAbstractBaseClass
    {
        public abstract void performaction();
        public void printinfo()
        {
            Debug.Log("This is a concrete method in the abstract base class");

        }

    }

    public class DerivedClassExample : TheAbstractBaseClass
    {
        public override void performaction()
        {
            Debug.Log("PerformAction is implemented in the derived class");
        }

    }
}
