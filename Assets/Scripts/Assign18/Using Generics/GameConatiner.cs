using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
namespace Assign18
{
    public class GameContainer<T>
    {
        public T itemsStorage;
        public void SetItem(T item)
        {
            itemsStorage = item;

        }
        public T Getitem()
        {
            Debug.Log("Stored item is : " + itemsStorage);
            return itemsStorage;
        }


    }
}
