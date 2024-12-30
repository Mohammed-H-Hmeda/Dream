using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
namespace assign29
{
    public class CustomObject
    {
        //Properties:
        int id;
        string name;

        int ID
        {
            get { return id; }
            set { id = value; }

        }
        string Name
        {
            get { return name; }
            set { name = value; }

        }
        //A constructor to initialize ID and Name.
        public CustomObject(int ID, string Name)
        {
            this.Name = Name;
            this.ID = ID;
        }
        //An overridden ToString() method that returns a formatted string,
        public override string ToString()
        {
            return $"Object[ID:{ID},Name:{Name}]";

        }
        /*[Optional] An overridden Equals(object obj) method to compare
        two CustomObject instances. Then please comment out this entire
        method!*/

        public override bool Equals(object obj)
        {
            CustomObject obj1 = obj as CustomObject;
            if (obj != null)
            {
                if (this == obj1)
                {
                    return true;
                }
                else return false;
            }

            else return false;
        }

        /*[Optional] Overloaded == and != operators to check equality between
    two objects of type CustomObject.*/
        public static bool operator ==(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj1.Equals(null))
            {
                if (obj1.name.Equals(obj2.name))
                {
                    return true;
                }
                else return false;

            }
            else return false;
        }
        public static bool operator !=(CustomObject obj1, CustomObject obj2)
        {
            if (!obj1.Equals(null) && !obj1.Equals(null))
            {
                if (!obj1.name.Equals(obj2.name))
                {
                    return true;
                }
                else return false;

            }
            else return false;

        }


    }
}