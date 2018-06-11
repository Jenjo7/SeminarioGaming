using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{

    public float movementSpeed = 2f;

    public Rigidbody2D myRigidbody
    {
        get;
        protected set;
    }

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = Vector2.left * movementSpeed;
    }

    public float minX = -10;

    private void Update()
    {
        if (transform.position.x < minX)
        {
            Destroy(gameObject);
        }
    }

}
