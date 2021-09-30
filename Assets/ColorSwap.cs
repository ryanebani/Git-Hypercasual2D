using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
    private SpriteRenderer ballSprite;
    public string ballColor;

    [SerializeField]
    private Sprite[] spriteArray;
    
    void Start()
    {
        ballSprite = GetComponent<SpriteRenderer>();
    }

    public void colorChange()
    {
        colorChoose();

        if (ballColor == "purple")
        {
            ballSprite.sprite = spriteArray[0];
        }

        if (ballColor == "green")
        {
            ballSprite.sprite = spriteArray[1];
        }

        if (ballColor == "yellow")
        {
            ballSprite.sprite = spriteArray[2];
        }

        if (ballColor == "red")
        {
            ballSprite.sprite = spriteArray[3];
        }
    }

    private void colorChoose()
    {
        float randomValue = Random.Range(0, 4);

        if (randomValue >= 0 && randomValue < 1)
        {
            ballColor = "purple";
        }

        if (randomValue >= 1 && randomValue < 2)
        {
            ballColor = "green";
        }

        if (randomValue >= 2 && randomValue < 3)
        {
            ballColor = "yellow";
        }

        if (randomValue >= 3 && randomValue < 4)
        {
            ballColor = "red";
        }
    }
}
