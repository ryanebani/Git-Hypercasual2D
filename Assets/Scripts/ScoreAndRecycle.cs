using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAndRecycle : MonoBehaviour
{
    [SerializeField] private ColorSwap swapScript;
    
    private Transform star;
    [SerializeField] private Transform ball;
    [SerializeField] private Transform wheel;

    public Vector3 triggerCoord;
    [SerializeField] private float starDistance;

    void Start()
    {
        star = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.position.y >= triggerCoord.y)
        {
            star.position = wheel.position;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other)
        {
            swapScript.AddScore();
            SetStarTrigger();
            star.position = new Vector3(5, star.position.y, star.position.z);
        }
    }

    private Vector3 SetStarTrigger()
    {
        triggerCoord = star.position + new Vector3(0, starDistance, 0);
        return triggerCoord;
    }
}
