using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [Header("Life Properties")]
    [SerializeField] private int _maxHP = 100;
    [SerializeField] private int _currentHP;
    [SerializeField] private float _speed = 5f;
    [SerializeField] private TextMeshProUGUI _healthText;

    private Rigidbody _rb;
    private Vector3 _movement;
    private PlayerInventory _inventory;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _inventory = GetComponent<PlayerInventory>();
        _currentHP = _maxHP;
        UpdateHealthUI();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v =Input.GetAxis("Verival");
        _movement = new Vector3(h, 0f, v).normalized;

        for (int i = 1; i <= 9; i++) // <- uso item premendo il rispettivo tasto da tastiera
        {
            if (Input.GetKeyDown(i.ToString())) // <- converte il valore di i in stringa testuale
            {
                _inventory.UseItemById(i.ToString());
            }
        }
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * (_speed * Time.fixedDeltaTime));
    }

    public void RestoreHealth(int amount)
    {
        _currentHP = Mathf.Min(_currentHP + amount, _maxHP);
        UpdateHealthUI();
    }

    void UpdateHealthUI()
    {
        if (_healthText != null)
        {
            _healthText.text = $"HP: {_currentHP}";
        }
    }
}
