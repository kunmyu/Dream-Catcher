using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public GameObject[] Encounter;
    public GameObject FollowCamera;
    public int EncounterNumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Encounter[EncounterNumber].SetActive(true);
        for (int index = 0; index < Encounter.Length; index++)
        {
            if (index != EncounterNumber)
            {
                Encounter[index].SetActive(false);

            }
        }


    }
}
