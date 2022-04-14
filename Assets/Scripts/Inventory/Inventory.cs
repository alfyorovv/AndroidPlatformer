using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull; //Заполнена ли ячейка инвентаря
    public GameObject[] slots;
    public GameObject inventory;
    bool isOpened; //Открыт ли инвентарь

    void Start()
    {
        isOpened = false;
    }

    public void InventoryButton()
    {
        if(!isOpened)
        {
            isOpened = true;
            inventory.SetActive(true);
        }
        else
        {
            isOpened = false;
            inventory.SetActive(false);
        }
    }
}
