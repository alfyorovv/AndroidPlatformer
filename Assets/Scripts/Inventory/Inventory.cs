using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public bool[] isFull; //��������� �� ������ ���������
    public GameObject[] slots;
    public GameObject inventory;
    bool isOpened; //������ �� ���������

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
