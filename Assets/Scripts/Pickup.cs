using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    [SerializeField] private ItemSO _item;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
            {
            PlayerInventory inventory = collider.GetComponent<PlayerInventory>();
            if (inventory != null)
            {
                inventory.AddItem(_item);
                Destroy(gameObject);
            }
        }        
    }
}