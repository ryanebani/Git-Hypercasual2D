using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecycleOutPrincipal : MonoBehaviour
{
    [SerializeField]
    private Transform ball;
    [SerializeField]
    private Transform principalWheel;
    private Transform myWheel;

    private Vector3 wheelTrigger;
    [SerializeField]
    private float wheelDistance;
    [SerializeField]
    private float outCam;

    [SerializeField] private wheelMove wheelMoveScript;

    public bool isALimit;

    void Start()
    {
        myWheel = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y >= wheelTrigger.y && isALimit == false)
        {
            wheelMoveScript.SetSpeed();
            myWheel.position = principalWheel.position + new Vector3(0, wheelDistance, 0);
        }
    }

    public Vector3 SetWheelTrigger()
    {
        wheelTrigger = principalWheel.position - new Vector3(0, outCam, 0);
        return wheelTrigger;
    }
}
