using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewHealthPotion", menuName = "Data/Items/Health Potion")]
public class HealthPotionSO : ItemSO
{
    [Header("Health Potion Properties")]
    [SerializeField] private int _healingFactor;

    public override void Use(GameObject target)
    {
        LifeController life = target.GetComponent<LifeController>();
        if (life != null)
        {
            life.RestoreHealth(_healingFactor);
            Debug.Log($"Usato {itemName}: +{_healingFactor} HP");
        }
    }
}