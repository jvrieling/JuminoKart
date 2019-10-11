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

    private Collider2D colliderComponent;

    private void Awake()
    {
        colliderComponent = GetComponent<Collider2D>();       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
