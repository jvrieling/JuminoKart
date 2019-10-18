using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float jumpHeight = 3;
    [SerializeField]
    [Tooltip("Movement speed in units per second")]
    private float movementSpeed = 1;
    private float maxSpeedX = 5;

    private Rigidbody2D rigidBody2DComponent;

    private void Awake()
    {
        rigidBody2DComponent = GetComponent<Rigidbody2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        //Vector2 movement = new Vector2(rigidBody2DComponent.position.x + movementSpeed * Time.deltaTime, rigidBody2DComponent.position.y) ;
        //rigidBody2DComponent.MovePosition(movement);


        Vector2 movement = new Vector2(movementSpeed, 0);
        

        if(rigidBody2DComponent.velocity.x >= maxSpeedX)
        {
            movement.x = 0;
        }

        rigidBody2DComponent.AddForce(movement);
    }
}
