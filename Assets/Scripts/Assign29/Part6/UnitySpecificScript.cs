using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Rendering;
namespace assign29
{
    public class UnitySpecificScript : MonoBehaviour
    {
        public GameObject targetObj;
        /*Use the OnEnable() method to print() "GameObject Enabled" when the
        GameObject is enabled in the scene.*/
        void OnEnable()
        {
            print("GameObject Enabled");
        }

        /*Use the OnDisable() method to print() "GameObject Disabled" when the
        GameObject is disabled in the scene.*/
        void OnDisable()
        {
            print("GameObject Disabled");
        }

        /*Use the Start() method to print() "Game started!" when the game begins
        (Play Mode).*/
        void Start()
        {
            print("Game Started");

            //Use GameObject.Find() to locate "TargetObject" by its name.
            if (GameObject.Find("TargetObj") == null)
            {
                /*print() the name of the object if found, or print() "No TargetObject found."
                if it doesn’t exist.*/
                Debug.Log("No object was found");
            }
            else Debug.Log("Found object by name: " + GameObject.Find("TargetObj").name);

            //Use GameObject.FindGameObjectWithTag() to locate the "Joker" object by its tag.
            if (GameObject.FindGameObjectWithTag("Joker") == null)
            {
                /*print() the name of the object if found, or log "No Joker object found." if it
                doesn’t exist.*/
                Debug.Log("No such object exists");
            }
            else { Debug.Log("Found Game object with tag:" + GameObject.FindGameObjectWithTag("Joker").name); }

            //Use GameObject.FindObjectOfType<>() to locate an object of type Light.
            if (GameObject.FindAnyObjectByType<Light>() == null)
            {
                /*print() the name of the object if found, or log "No Light object found." if it
                doesn’t exist.*/
                Debug.Log("No such object exists");
            }
            else { Debug.Log("Light was found of type:" + GameObject.FindAnyObjectByType<Light>().type); }

        }
        // Update is called once per frame
        void Update()
        {
            //Use SetActive() to deactivate TargetObject when the "D" key is pressed.
            if (Input.GetKeyUp(KeyCode.D))
            {

                targetObj.SetActive(false);
                //print() "TargetObject deactivated!" to confirm that the object has been deactivated.
                print("TargetObject was Disabled");
            }

        }

    }
}