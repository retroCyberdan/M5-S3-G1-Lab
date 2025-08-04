using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    [Header("Life Properties")]
    [SerializeField] private float _speed = 5f;

    private Rigidbody _rb;
    private Vector3 _movement;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v =Input.GetAxis("Vertical");
        _movement = new Vector3(h, 0f, v).normalized;
    }

    void FixedUpdate()
    {
        _rb.MovePosition(_rb.position + _movement * (_speed * Time.fixedDeltaTime));
    }
}
