﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        Debug.Log(collision.gameObject.name);
    }

}
