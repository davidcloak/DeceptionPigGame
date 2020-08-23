using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DetermineRoleUI : MonoBehaviour
{
    public GameObject rollWolfAssign;
    public GameObject rollPigAssign;
    public GameObject WolfDescription;
    public GameObject PigDescription;

    public bool isPig = true;


    public void ShowUI()
    {
        if(isPig)
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
