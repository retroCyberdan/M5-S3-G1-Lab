using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewPoisonPotion", menuName = "Data/Items/Poison Potion")]

public class PoisonPotionSO : ItemSO
{
    [Header("Poison Potion Properties")]
    [SerializeField] private int _damageFactor;

    public override void Use(GameObject target)
    {
        LifeController life = target.GetComponent<LifeController>();
        if (life != null)
        {
            life.TakeDamage(_damageFactor);
            Debug.Log($"Usato {itemName}: -{_damageFactor} HP");
        }
    }
}
