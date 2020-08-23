using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetermineRoleBackup : MonoBehaviour
{
    public GameObject rollWolfAssign;
    public GameObject rollPigAssign;
    public GameObject WolfDescription;
    public GameObject PigDescription;

    public int randomInt;

    

    //Random.Range(1, 8)

    // Start is called before the first frame update
    void Start()
    {
        randomInt = UnityEngine.Random.Range(1, 8);
        print(randomInt);

        if(randomInt >= 1 && randomInt <= 6)
        {
            rollPigAssign.SetActive(true);
            PigDescription.SetActive(true);
        }
        else
        {
            rollWolfAssign.SetActive(true);
            WolfDescription.SetActive(true);
        }
    }

    
}
