using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Sprite UIImage;
    public float stackLimit = 5f;
    public string itemName;

    public void onPickUP()
    {
        /*
         * pass info to inventroy in return passes it to the slot
         * disables its box colider 
         */
    }

    public void onDrop()
    {
        /*
         * reables its box colider 
         * spawns it near the player
         */
    }


}
