using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public Sprite UIImage;
    public float stackLimit = 5f;
    public string itemName;
    GameObject inventroy;

    private void Start()
    {
        inventroy = GameObject.Find("InventoryBackgroundPanel");
    }

    public void onPickUP()
    {
        /*
         * pass info to inventroy in return passes it to the slot
         * disables its box colider 
         */
        gameObject.GetComponent<BoxCollider>().enabled = false;
    }

    public void onDrop()
    {
        /*
         * reables its box colider 
         * spawns it near the player
         */
        gameObject.SetActive(false);
        gameObject.GetComponent<BoxCollider>().enabled = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == GameObject.Find("Player"))
        {
            inventroy.GetComponent<Inventory>().PickingUpItem(gameObject);
            onPickUP();
        }
    }
}
