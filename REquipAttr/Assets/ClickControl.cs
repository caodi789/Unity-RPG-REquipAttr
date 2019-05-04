using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickControl : MonoBehaviour
{
    GameObject Bag;


    public void EquipClick()
    {
        Bag.SetActive(!Bag.activeSelf);
    }

    private void Start()
    {
        Bag = GameObject.FindGameObjectWithTag("Bag");
        Bag.SetActive(!Bag.activeSelf);
    }
}
