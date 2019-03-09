using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public string itemName;//Вводим имена в inspector

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Item collected: " + itemName);
        Destroy(gameObject);

    }
}
