using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourAndRecycle : MonoBehaviour
{
    [SerializeField] private ColorSwap swapScript;
    [SerializeField] private ScoreAndRecycle triggerScript;

    private Transform colour;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform wheel;

    [SerializeField] private float colourDistance;
    private Vector3 colourCoord;

    

    void Start()
    {
        colour = GetComponent<Transform>();
        colourCoord = new Vector3(0, colourDistance, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y >= triggerScript.triggerCoord.y)
        {
            colour.position = wheel.position + colourCoord;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other)
        {
            swapScript.colorChange();
            colour.position = new Vector3(triggerScript.disappearRange, colour.position.y, colour.position.z);
        }
    }
}
