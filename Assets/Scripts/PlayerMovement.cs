using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D myRigidbody;
    public float force;

    private void Awake()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetButton("Fire1"))
        {
            myRigidbody.AddForce(Vector2.up * force, ForceMode2D.Force);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Aumentare i punti
        GameManager.instance.points++;
    }

}
