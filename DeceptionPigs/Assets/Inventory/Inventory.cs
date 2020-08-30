using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    GameObject[] slots;

    // Start is called before the first frame update
    void Start()
    {
        WithForLoop();
        //slots[whatChild].transform.GetChild(0).GetComponent<Image>().color = Color.black;
        /*for(int i = 0; i < transform.childCount; i++)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(1);
        }*/
    }

    void WithForLoop()
    {
        int children = transform.childCount;
        slots = new GameObject[children];
        for (int i = 0; i < children; ++i)
        {
            //print("For loop: " + transform.GetChild(i));
            slots[i] = transform.GetChild(i).gameObject;
        }
    } 

    /*public void InvButtonPressed(int i)
    {
        if (slots[i].transform.GetChild(0).GetComponent<Slot>().hasItem && !mouseHasItem)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().giveItem();
            mouseHasItem = true;
            whereItemWasTaken = i;
            stack = slots[i].transform.GetChild(0).GetComponent<Slot>().stack;
        }else if (mouseHasItem && !slots[i].transform.GetChild(0).GetComponent<Slot>().hasItem)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(stack);
            mouseHasItem = false;
            whereItemWasTaken = 27;
        }
        else if(mouseHasItem && stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack <= 1*//*maxStackSize*//*)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack);
            mouseHasItem = false;
            whereItemWasTaken = 27;
        }
    }*/


    //start here
    public void MouseAction(GameObject slot)
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("left "+slot);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            print("right "+slot);
        }
    }

    public void PickingUpItem(GameObject item)
    {
        for(int i = 0; i < slots.Length; i++)
        {
            if (!slots[i].GetComponent<Slot>().hasItem || 
                (slots[i].GetComponent<Slot>().stack + 1 <= item.GetComponent<Item>().stackLimit))
            {
                slots[i].GetComponent<Slot>().AddItem(item, 1);
            }
        }
    }

    public void TakeItem()
    {

    }

    public void DropItem(GameObject slot)
    {
        slot.SetActive(true);
    }
}
