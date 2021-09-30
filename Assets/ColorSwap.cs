using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
    private Sprite ballSprite;
    private string ballColor;

    [SerializeField]
    private Sprite purpleSprite;
    [SerializeField]
    private Sprite greenSprite;
    [SerializeField]
    private Sprite yellowSprite;
    [SerializeField]
    private Sprite redSprite;

    
    void Start()
    {
        ballSprite = GetComponent<Sprite>();
    }

    void colorChange()
    {
        if (ballColor == "purple")
        {
            ballSprite = purpleSprite;
        }

        if (ballColor == "green")
        {
            ballSprite = greenSprite;
        }

        if (ballColor == "yellow")
        {
            ballSprite = yellowSprite;
        }

        if (ballColor == "red")
        {
            ballSprite = redSprite;
        }
    }
}
