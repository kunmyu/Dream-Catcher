using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public int ObjectNumber;
    public GameObject[] ObjectChoice;
    public GameObject OriginalObject;
    // Start is called before the first frame update
   

    // Update is called once per frame
    
    public void ChangeObjectFunction()
    {
        ObjectChoice[ObjectNumber - 1].SetActive(true);
        OriginalObject.SetActive(false);


        for (int index = 0; index < ObjectChoice.Length; index++)
        {
            if(index != ObjectNumber - 1 )
            {
                ObjectChoice[index].SetActive(false);
             
            }
        }


       

           
        


    }




}
