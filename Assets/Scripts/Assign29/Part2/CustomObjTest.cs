using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace assign29
{
    public class CustomObjTest : MonoBehaviour
    {
        //Instantiates one CustomObject instance with a specific ID and a Name.
        CustomObject Player1 = new CustomObject(120220402, "Moahmmed");
        CustomObject Player2 = new CustomObject(120220401, "Maher");

        // Start is called before the first frame update
        void Start()
        {
            //Logs the instance object using the print() method.
            print(Player1.ToString());

            /*[Optional] Instantiates another CustomObject instance and logs the
            results of comparing the objects using the == and != operators, using the
            print() method.*/
            if (Player1 == Player2)
            {
                print("Player names are Equal");
            }
            else if (Player1 != Player2)
            {
                print("Player names are not Equal");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}