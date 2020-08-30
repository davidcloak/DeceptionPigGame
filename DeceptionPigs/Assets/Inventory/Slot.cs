using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject[] TheItem;
    int itemPos = 0;
    public bool hasItem = false;
    public bool isTool = false;
    public float stack = 0;

    private void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.clear;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
    }

    public void AddItem(GameObject item, float stack)
    {
        if (itemPos == 0)
        {
            TheItem = new GameObject[(int)item.GetComponent<Item>().stackLimit];
        }
        TheItem[itemPos] = item;
        itemPos++;
        this.stack += stack;
        hasItem = true;

        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.white;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "" + this.stack;
        gameObject.transform.GetChild(0).GetComponent<Image>().sprite = TheItem[itemPos].GetComponent<Item>().UIImage;
    }

    public void ClearSlot()
    {
        for (int i = 0; i < TheItem.Length; i++)
        {
            TheItem[i] = new GameObject();
        }
        itemPos = 0;
        this.stack = 0;
        hasItem = false;


        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.clear;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
    }

    public void giveItem()//void for now should be GameObject later
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.clear;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
        hasItem = false;
        //return item;
    }
}
