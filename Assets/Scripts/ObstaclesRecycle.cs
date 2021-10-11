using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesRecycle : MonoBehaviour
{
    [SerializeField]
    private Transform ball;
    private Transform obstacle;

    [SerializeField]
    private float triggerDistance;
    [SerializeField]
    private float spawnDistance;

    private Vector3 triggerHeight;
    private Vector2 spawnHeight;

    void Start()
    {
        obstacle = GetComponent<Transform>();
        SetTrigger();
    }

    void Update()
    {
        if (ball.position.y == triggerHeight.y)
        {
            obstacle.position = triggerHeight + new Vector3(0, spawnDistance, 0); ;
            SetTrigger(); 
        }
    }

    private Vector3 SetTrigger()
    {
        triggerHeight = ball.position + new Vector3(0, triggerDistance, 0);
        return triggerHeight;
        
    }
}
