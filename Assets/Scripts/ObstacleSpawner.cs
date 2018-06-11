using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public float obstaclesDistance;
    public float maxHeightDelta;

    public float startingPosition;
    public float maxX;
    public float maxY;

    ObstacleMovement lastObstacle;

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        float newX = startingPosition;
        if (lastObstacle != null)
        {
            newX = lastObstacle.transform.position.x + obstaclesDistance;
        }

        float newY = Random.Range(-maxHeightDelta, maxHeightDelta);
        if (lastObstacle != null)
        {
            newY += lastObstacle.transform.position.y;
        }

        newY = Mathf.Clamp(newY, -maxY, maxY);

        GameObject newObject = Instantiate(obstaclePrefab, new Vector3(newX, newY), Quaternion.identity);

        lastObstacle = newObject.GetComponent<ObstacleMovement>();
    }

    void SpawnField()
    {
        while (lastObstacle == null || lastObstacle.transform.position.x < maxX)
        {
            SpawnObstacle();
        }
    }

    private void Update()
    {
        SpawnField();
    }

}
