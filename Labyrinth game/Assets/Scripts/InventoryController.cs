using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public Image Inventory;
    public bool inventoryON = false;
    public KeyCode Open = KeyCode.E;
    public KeyCode Close = KeyCode.Escape;

    // Start is called before the first frame update
    void Start()
    {
        Inventory.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(Open))
        {
            Inventory.gameObject.SetActive(true);
            inventoryON = true;
            Time.timeScale = 0;
        }

        if(Input.GetKeyDown(Close))
        {
            Inventory.gameObject.SetActive(false);
            inventoryON = false;
            Time.timeScale = 1;
        }
    }
}
