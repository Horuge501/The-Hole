using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HolePlayer : MonoBehaviour
{
    private HoleControl controller;

    [SerializeField] private float speed;

    private Rigidbody rb;

    public void Awake() 
    {
        controller = new HoleControl();
    }

    void Start()
    {
        controller.Enable();
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        
    }

    private void FixedUpdate() 
    {
        Move();
    }

    private void Move() 
    {
        Vector2 movementInput = controller.Move.Direction.ReadValue<Vector2>();

        float moveX = movementInput.x;
        float moveZ = movementInput.y;

        Vector3 movement = new Vector3(moveX, 0f, moveZ);

        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
