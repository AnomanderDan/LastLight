using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed = 5;
    private Vector3 _input;
    
    
    void Update() {
        GatherInput();
    }

    void FixedUpdate() {
        Move();
    }

    

    void GatherInput() {
            _input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
    }

    void Move() {
        _rb.MovePosition(transform.position + transform.forward * _speed * Time.deltaTime);
    }
}
