using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    int _points = 0;
    public int points
    {
        get
        {
            return _points;
        }
        set
        {
            _points = value;
            Debug.Log(_points);
        }
    }

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }
}
