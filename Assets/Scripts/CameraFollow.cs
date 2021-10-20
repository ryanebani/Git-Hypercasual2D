using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private Vector3 offset;

    [Range(0.1f, 20)]
    [SerializeField]
    private float smoothFactor;

    [SerializeField]
    private float limitY;
    private float limitCheck;
    [SerializeField]
    private float limitOff;

    public bool isCam;


    private void FixedUpdate()
    {
            Follow();
    }
    private void Follow()
    {
        Vector3 targetPosition = target.position + offset;
        //Vector3 smoothPosition = Vector3.Lerp(transform.position, targetPosition, smoothFactor * Time.fixedDeltaTime);
        transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
    }
}
