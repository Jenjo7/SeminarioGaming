using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour {

    public Vector3 startingPosition;

    public Vector3 unitsPerSecond;

    Vector3 currentPosition;
	// Use this for initialization
	void Start () {
        transform.position = startingPosition;
        currentPosition = startingPosition;
	}
	
	// Update is called once per frame
	void Update () {
        currentPosition += unitsPerSecond * Time.deltaTime;

        transform.position = currentPosition;
	}
}
