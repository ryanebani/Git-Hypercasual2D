using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colourRotation : MonoBehaviour
{
    private float rotationZ;

    [SerializeField] private float rotationSpeed;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rotationZ += Time.deltaTime * rotationSpeed;
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }
}
