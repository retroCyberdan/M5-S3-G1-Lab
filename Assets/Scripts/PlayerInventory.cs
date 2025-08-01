using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<ItemSO> items = new List<ItemSO>();

    public void AddItem(ItemSO item)
    {
        items.Add(item);
        Debug.Log($"Raccolto: {item.itemName}");
    }

    public void UseItemById(string id) // <- uso l`item relativo al tasto premuto (id = tasto premuto)
    {
        ItemSO itemToUse = items.Find(i => i.itemId == id);
        if (itemToUse != null)
        {
            itemToUse.Use(gameObject);
            items.Remove(itemToUse);
        }
        else
        {
            Debug.Log($"Nessun item con id {id} trovato nell'inventario.");
        }
    }
}
