using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageTransition : MonoBehaviour
{
    public StageManager Manager;
    public GameObject ColliderPair;

    public bool EnterStage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            this.gameObject.SetActive(false);
            ColliderPair.SetActive(true);
       
            if (EnterStage == true)
            {
                print("Trigger");
                Manager.EncounterNumber++;
                //EnterStage = false;
            }
            if (EnterStage == false)
            {
                Manager.EncounterNumber--;
                //EnterStage = true;
            }


        }
    }

    
}


