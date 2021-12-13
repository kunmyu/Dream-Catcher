using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectOption : MonoBehaviour
{
    public ObjectManager manager;
    public int objectnumber;

   public void OnClick()
    {

        manager.ObjectNumber = objectnumber;
        manager.ChangeObjectFunction();

    }
   
}
