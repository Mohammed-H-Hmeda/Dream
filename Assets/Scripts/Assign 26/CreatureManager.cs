using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UIElements;
namespace assign26
{
    public class CreatureManager : MonoBehaviour
    {
        Kangroo rony = new Kangroo();
        Duck billy = new Duck();
        // Start is called before the first frame update
        void Start()
        {

            List<Creature> creaturesList = new List<Creature> { rony, billy };
            List<IJumpable> jumpers = new List<IJumpable> { rony };
            List<ISwimable> swimmers = new List<ISwimable> { billy };
            List<IRunable> runners = new List<IRunable> { rony, billy };

            foreach (Creature creature in creaturesList)
            {
                creature.Speak();
            }
            foreach (IRunable runner in runners)
            {

                 runner.Run();             
            }
            foreach(IJumpable jumper in jumpers)
            {
                jumper.Jump();
            }
            foreach(ISwimable swimmer in swimmers)
            {
                swimmer.Swim();
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}