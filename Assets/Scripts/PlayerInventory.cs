using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    [SerializeField] private List<ItemSO> _items = new List<ItemSO>();

    private PlayerInventory _inventory;

    private void Start()
    {
        _inventory = GetComponent<PlayerInventory>();
    }

    private void Update()
    {
        for (int i = 1; i <= 9; i++) // <- uso item premendo il rispettivo tasto da tastiera
        {
            if (Input.GetKeyDown(i.ToString())) // <- converte il valore di i in stringa testuale
            {
                _inventory.UseItemById(i.ToString());
            }
        }
    }

    public void AddItem(ItemSO item)
    {
        _items.Add(item);
        Debug.Log($"Raccolto: {item.itemName}");
    }

    public void UseItemById(string id) // <- uso l`item relativo al tasto premuto (id = tasto premuto)
    {
        ItemSO itemToUse = _items.Find(i => i.itemId == id);
        if (itemToUse != null)
        {
            itemToUse.Use(gameObject);
            _items.Remove(itemToUse);
            Debug.Log($"Usato item con id {id}. {itemToUse.name} rimosso dall`inventario.");
        }
        else
        {
            Debug.Log($"Nessun item con id {id} trovato nell'inventario.");
        }
    }
}
