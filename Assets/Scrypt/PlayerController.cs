using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField, Range(1, 30f)] private float _moveSpeed;
    [SerializeField, Range(1, 20f)] private float _rotationSpeed;
    [SerializeField] private Rigidbody _rigidbody;

    [SerializeField] private string _namePlayerOne;
    [SerializeField] private string _namePlayerTwo;

    private Controls _controls;
    private InputAction _action;
    

    private void Awake()
    {
        _controls = new Controls();
        _controls.Player.Enable();
        if (gameObject.name == _namePlayerOne) _action = _controls.Player.MovementPlayerOne;
        else _action = _controls.Player.MovementPlayerTwo;

    }

    void FixedUpdate()
    {

        Vector3 direction = _action.ReadValue<Vector2>();
        _rigidbody.velocity += transform.forward * Time.deltaTime * _moveSpeed * direction.y;
        transform.Rotate(transform.up, _rotationSpeed * Time.deltaTime * direction.x);
    }

}
