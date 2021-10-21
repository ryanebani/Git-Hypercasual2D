using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelMove : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    private float randomSpeed;

    private float rotationZ;
    private float gameRotation;

    [SerializeField] private float minRandom;
    [SerializeField] private float maxRandom;
    [SerializeField] private float moreSpeed;

    public bool limitWheel;
    void Start()
    {
        SetSpeed();
    }

    
    void Update()
    {
        rotationZ += Time.deltaTime * rotationSpeed;
        gameRotation += Time.deltaTime * randomSpeed;

        if (limitWheel)
        {
            limitWheelRotate();
        }
        else
        {
            gameWheelRotate();
        }
    }

    private void limitWheelRotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }

    private void gameWheelRotate()
    {
        transform.rotation = Quaternion.Euler(0, 0, gameRotation);
    }

    public float SetSpeed()
    {
        randomSpeed = Random.Range(minRandom, maxRandom);
        return randomSpeed;
    }

    public void AddRange()
    {
        minRandom += moreSpeed;
        maxRandom += moreSpeed;
    }
}