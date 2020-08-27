using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    public float sensitivity = 100f;
    public Transform playerBody;
    float xRotate = 0f;
    float inventoryOnOf = -1f;
    GameObject inventory;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        inventory = GameObject.Find("InventoryBackgroundPanel");
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (inventoryOnOf == -1)
        {
            float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

            xRotate -= mouseY;
            xRotate = Mathf.Clamp(xRotate, -90f, 90f);

            transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
            playerBody.Rotate(Vector3.up * mouseX);
        }
        if (Input.GetKeyDown("e"))
        {
            toggleInventory();
        }
    }

    void toggleInventory()
    {
        if (inventoryOnOf == -1)
        {
            Cursor.lockState = CursorLockMode.None;
            inventory.SetActive(true);
            inventoryOnOf *= -1;
        }else if(inventoryOnOf == 1f)
        {
            Cursor.lockState = CursorLockMode.Locked;
            inventory.SetActive(false);
            inventoryOnOf *= -1;
        }
    }
}
