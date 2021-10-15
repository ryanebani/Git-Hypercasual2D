using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerForPowerup : MonoBehaviour
{
    [SerializeField] private ColorSwap swapScript;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other)
        {
            swapScript.ImortalHour();
            Destroy(gameObject);
        }
    }
}
