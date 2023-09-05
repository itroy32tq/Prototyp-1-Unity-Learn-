using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Controls;

public class PropellerController : MonoBehaviour
{
    private Controls _controls;
    private string _name;

    [SerializeField] private float rotationSpeed = 5f;

    private void Awake()
    {
        _controls = new Controls();
        _controls.Player.Enable();

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }
}
