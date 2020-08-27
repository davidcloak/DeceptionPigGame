using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    static GameObject item;
    public bool hasItem = false;
    public bool isTool = false;
    public float stack = 0;

    private void Start()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.clear;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
    }

    public void placeItem(float stack)
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.white;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = ""+stack;
        //gameObject.transform.GetChild(0).GetComponent<Image>().sprite = 
        hasItem = true;
        this.stack = stack;
    }

    public void giveItem()//void for now should be GameObject later
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = Color.clear;
        gameObject.transform.GetChild(1).GetComponent<Text>().text = "";
        hasItem = false;
        //return item;
    }
}
