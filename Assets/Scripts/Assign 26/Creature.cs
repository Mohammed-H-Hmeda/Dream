using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace assign26
{
    public class Creature : MonoBehaviour
    {
        public virtual void Speak()
        {
            Debug.Log("Making sound");
        }  
    }
    public interface IJumpable
        {
            public void Jump();

        }
        public interface IRunable
        {
            public void Run();


        }
        public interface ISwimable
        {
            public void Swim();


        }
        public class Kangroo : Creature, IJumpable, IRunable
        {
            public void Jump()
            {
                Debug.Log("Kangroo jumps");
            }
            public void Run()
            {
                Debug.Log("Kangroo runs");
            }
            public override void Speak()
            {
                Debug.Log("Kangaroo says: Hop!");
            }


        }
        public class Duck : Creature, IRunable, ISwimable
        {
            public void Run()
            {
                Debug.Log("Duck runs");
            }
            public void Swim()
            {
                Debug.Log("Duck swims");
            }
            public override void Speak()
            {
                Debug.Log("Duck says:Quack!");
            }
        }
}