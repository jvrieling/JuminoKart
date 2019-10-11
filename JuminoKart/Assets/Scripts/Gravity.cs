using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    [SerializeField]
    private float weight = 1;

    [SerializeField]
    float terminalVelocity = 10;

    [SerializeField]
    private float gravityPull = 9.8f;

    [SerializeField]
    Vector2 velocity;

    private Collider2D colliderComponent;

    private void Awake()
    {
        colliderComponent = GetComponent<Collider2D>();
    }

    void FixedUpdate()
    {
        Vector2 velocityModification = new Vector2
        {
            y = -(weight * gravityPull * Time.fixedDeltaTime)
        };
        velocity += velocityModification;

        transform.Translate(velocity);
    }

    void checkCollisions()
    {
        Collider2D[] collisions = new Collider2D[0];        
    }
}
