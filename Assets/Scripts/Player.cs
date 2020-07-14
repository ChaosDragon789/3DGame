using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Controls playerControls;
    
    [SerializeField] private Rigidbody rb = null;
    private float jumpForce = 400f;
    private float moveSpeed = 30f;
    private Vector3 direction;
    void Start(){

    }

    void Update(){

    }

    void FixedUpdate(){

    }

    public void OnJump(InputAction.CallbackContext context){
        Debug.Log("yay");
        rb.AddForce(new Vector3(0f, jumpForce, 0f));
    }

    public void OnMove(InputAction.CallbackContext context){
        direction = context.ReadValue<Vector2>();
        rb.velocity = (new Vector3(direction.x, 0f, direction.y)) * moveSpeed;
    }

}
