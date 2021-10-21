using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wheelMove : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;

    [SerializeField]
    private ParticleSystem rainbowExplosion = null;

    [SerializeField]
    private ColorSwap colorScript;
    private float randomSpeed;

    private float rotationZ;
    private float gameRotation;

    [SerializeField] private float minRandom;
    [SerializeField] private float maxRandom;
    [SerializeField] private float moreSpeed;

    public bool limitWheel;

    [SerializeField] private SpriteRenderer[] aros;
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (colorScript.invencible)
        {
            rainbowExplosion.Play();
        }
    }
}