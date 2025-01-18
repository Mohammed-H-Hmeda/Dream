using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using UnityEngine.Events;
namespace assign35
{


    public class UnityEventExample : MonoBehaviour
    {
        UnityEvent onEventTriggerd;
        void ListnerAction()
        {
            Debug.Log("The event has been triggered!");
        }
        // Start is called before the first frame update
        void Start()
        {
            onEventTriggerd = new UnityEvent();
            onEventTriggerd.AddListener(ListnerAction);
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                onEventTriggerd.Invoke();
            }



        }
    }
}