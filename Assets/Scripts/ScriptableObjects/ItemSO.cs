using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemSO : ScriptableObject // <- gli SO non sono sempre abstract (solo quando intendo usare esclusivamente le classi che estendono)
{
    [Header("Common Items Properties")]
    public string itemId;
    public string itemName;
    public string itemDescription;
    public Sprite itemSprite;

    public abstract void Use(GameObject gameObject); // <- metodo astratto che ogni item dovrà implementare
}
