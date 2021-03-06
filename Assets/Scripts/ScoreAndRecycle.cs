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
    public float disappearRange;

    [SerializeField]
    private AudioSource catchStar;

    void Start()
    {
        star = GetComponent<Transform>();
    }

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
            catchStar.Play();
            swapScript.AddScore();
            SetStarTrigger();
            star.position = new Vector3(disappearRange, star.position.y, star.position.z);
        }
    }

    private Vector3 SetStarTrigger()
    {
        triggerCoord = star.position + new Vector3(0, starDistance, 0);
        return triggerCoord;
    }
}
