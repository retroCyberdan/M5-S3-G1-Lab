using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    [SerializeField] private int _maxHP = 100;
    [SerializeField] private int _currentHP;
    [SerializeField] private TextMeshProUGUI _healthText;

    void Start()
    {
        _currentHP = _maxHP / 2;
        UpdateHealthUI();
    }

    public void RestoreHealth(int amount)
    {
        _currentHP = Mathf.Min(_currentHP + amount, _maxHP);
        UpdateHealthUI();
    }

    public void TakeDamage(int amount)
    {
        _currentHP = Mathf.Max(_currentHP - amount, 0);
       
        UpdateHealthUI();
        
        if (_currentHP <= 0) Debug.Log("Player morto!");
    }

    private void UpdateHealthUI()
    {
        if (_healthText != null)
        {
            _healthText.text = $"HP: {_currentHP}";
        }
    }
}
