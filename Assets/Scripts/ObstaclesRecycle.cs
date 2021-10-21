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

    [SerializeField] private RecycleOutPrincipal recycleScript;
    [SerializeField] private wheelMove wheelMoveScript;

    void Start()
    {
        obstacle = GetComponent<Transform>();
        SetTrigger();
    }

    void Update()
    {
        spawnObs();
    }

    private Vector3 SetTrigger()
    {
        triggerHeight = ball.position + new Vector3(0, triggerDistance, 0);
        return triggerHeight;
 
    }

    private void spawnObs()
    {
        if (ball.position.y >= triggerHeight.y && ball.position.y < (triggerHeight.y + 1))
        {
            wheelMoveScript.SetSpeed();
            obstacle.position = triggerHeight + new Vector3(0, spawnDistance, 0);
            SetTrigger();
            recycleScript.SetWheelTrigger();
        }
    }

}
