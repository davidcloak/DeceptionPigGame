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
        for(int i = 0; i < 10; i++)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(1);
        }
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

    bool mouseHasItem = false;
    int whereItemWasTaken = 27;//27 because that slot does not exist
    float stack = 0;

    public void InvButtonPressed(int i)
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
        else if(mouseHasItem && stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack <= /*maxStackSize*/)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack);
            mouseHasItem = false;
            whereItemWasTaken = 27;
        }
    }


    //start here
    public void MouseAction(GameObject slot)
    {

    }

    public void PickingUpItem(GameObject item)
    {

    }

    public void TakeItem()
    {

    }

    public void DropItem()
    {

    }
}
