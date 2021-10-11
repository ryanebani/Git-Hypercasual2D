using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColorSwap : MonoBehaviour
{
    private SpriteRenderer _ballSprite;
    public string ballColor;

    [SerializeField]
    private Sprite[] spriteArray;

    public int score = 0;
    
    void Start()
    {
        _ballSprite = GetComponent<SpriteRenderer>();

    }

    public void colorChange()
    {
        colorChoose();

        switch (ballColor)
        {
            case "purple":
                _ballSprite.sprite = spriteArray[0];
                break;

            case "green":
                _ballSprite.sprite = spriteArray[1];
                break;

            case "yellow":
                _ballSprite.sprite = spriteArray[2];
                break;

            case "red":
                _ballSprite.sprite = spriteArray[3];
                break;
        }
    }

    private void colorChoose()
    {
        float randomValue = Random.Range(0, 4);

        if (randomValue >= 0 && randomValue < 1)
        {
            if (ballColor != "purple")
            ballColor = "purple";
            else
                colorChoose();
        }

        if (randomValue >= 1 && randomValue < 2)
        {
            if (ballColor != "green")
                ballColor = "green";
            else
                colorChoose();
        }

        if (randomValue >= 2 && randomValue < 3)
        {
            if (ballColor != "yellow")
                ballColor = "yellow";
            else
                colorChoose();
        }

        if (randomValue >= 3 && randomValue < 4)
        {
            if (ballColor != "red")
                ballColor = "red";
            else
                colorChoose();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag(ballColor) || other.CompareTag("colourBall")  || other.CompareTag("starScore"))
        {
            //
        }
        else Destroy(gameObject);
        
      //  {            
      //      SceneManager.LoadScene("Morreu");
      //  }
             
    }

    public void AddScore()
    {
        score++;
    }
}
