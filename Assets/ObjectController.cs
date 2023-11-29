using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private float speed;

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;

    private void OnEnable() {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        float xVal = fixedJoystick.Horizontal;
        float yval = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, yval);
        rigidBody.velocity = movement * speed;

        if(xVal !=0 && yval !=0)
        transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yval)*Mathf.Rad2Deg, transform.eulerAngles.z);
    }
    // public CharacterController controller;

    // [Header("Movement")]
    // public float speed = 1f;
    // public float gravity = -9.10f;
    // public float jumpHeight = 1f; 

    // [Header("Ground Check")]
    // public Transform ground_check;
    // public float ground_distance = 0.4f;
    // public LayerMask ground_mask;

    // Vector3 velocity;
    // bool isGround;

    // void Start() {
        
    // }

    // private void Update() {
    //     isGround = Physics.CheckSphere(ground_check.position, ground_distance, ground_mask);

    //     if(isGround && velocity.y < 0){
    //         velocity.y = -2f;
    //     }

    //     float x = Input.GetAxis("Horizontal");
    //     float y = Input.GetAxis("Vertical");

    //     Vector3 move = transform.right * x + transform.forward * z;

    //     controller.Move(move * speed * Time.deltaTime);

    //     if (Input.GetButtonDown("Jump") && isGround)
    //     {
    //         velocity.y = Mathf.sqrt(jumpHeight * -2f * gravity);
    //     }

    //     velocity.y += gravity * Time.deltaTime;

    //     controller.Move(velocity * Time.deltaTime);
    // }
}
