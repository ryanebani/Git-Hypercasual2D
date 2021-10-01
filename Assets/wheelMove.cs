using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelMove : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private float rotationZ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rotationZ += Time.deltaTime * rotationSpeed;
        wheelRotate();
    }

    private void wheelRotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}