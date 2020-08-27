using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int whatChild = 0;
    GameObject[] slots;
    public float maxStackSize = 5;

    // Start is called before the first frame update
    void Start()
    {
        WithForLoop();
        //slots[whatChild].transform.GetChild(0).GetComponent<Image>().color = Color.black;
        for(int i = 0; i < 10; i++)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(1);
        }
        print(slots[whatChild]);
    }

    // Update is called once per frame
    void Update()
    {
        
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

    /* TODO LIST FOR INVENTORY
     * 1 add items into the game to test with
     * 2 make items only join with items of the same knd
     * 3 pass data associated with the item
     * 4 fix join items over the limit
     *      -currently not subtracting the items added to the slot
     * 5 make a way to split items
     * 6 have items follow the curser
     */ 

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
        else if(mouseHasItem && stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack <= maxStackSize)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack);
            mouseHasItem = false;
            whereItemWasTaken = 27;
        }/*else if(mouseHasItem && stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack > maxStackSize)
        {
            slots[i].transform.GetChild(0).GetComponent<Slot>().placeItem(5);
            stack = ((stack + slots[i].transform.GetChild(0).GetComponent<Slot>().stack) - 5);
            //mouseHasItem = false;
            //whereItemWasTaken = 27;
        }*/
        //give you extra items
    }

    public void TestButtonPress()
    {
        Debug.Log("Button was pressed" + gameObject);
    }
}
