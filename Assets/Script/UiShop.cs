using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiShop : MonoBehaviour
{
    public GameObject content;
    public GameObject slot;

    public int itemCount;
    void Start()
    {
        for (int i = 0; i<itemCount; i++)
        {
            Instantiate(slot, content.transform); // ������ content�ȿ� �־��ش�.
        }
    }

    void Update()
    {
        
    }
}

