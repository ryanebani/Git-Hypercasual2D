using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColorSwap : MonoBehaviour
{
    //[SerializeField]
    //private CameraFollow camScript;

    private SpriteRenderer _ballSprite;
    public string ballColor;

    [SerializeField]
    private Sprite[] spriteArray;

    [SerializeField]
    private ParticleSystem fireStar = null;

    private int score = 0;
    private int powerScore = 0;
    private int hardScore = 0;

    public bool invencible;

    [SerializeField] private wheelMove wheelMoveScript;
    [SerializeField] private wheelMove wheelMoveScript1;

    [SerializeField]
    private Transform colour1;
    [SerializeField]
    private Transform colour2;

    [SerializeField]
    private Text scoreText;

    [SerializeField]
    private AudioSource becomeRocket;

    [SerializeField]
    private AudioSource crackWheel;

    void Start()
    {
        score = 0;
        invencible = false;
        _ballSprite = GetComponent<SpriteRenderer>();
        //camScript.enabled = true;
    }

    void Update()
    {
        if (invencible)
        {
            colour1.position = new Vector3 (10, 0, 0);
            colour2.position = new Vector3(10, 0, 0);
        }
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
        if (invencible == false)
        {
            if (other.CompareTag(ballColor) || other.CompareTag("colourBall") || other.CompareTag("starScore") || other.CompareTag("powerBall") || other.CompareTag("Explode"))
            {
                //
            }
            else
            {
                //camScript.enabled = false;
                Destroy(gameObject);
                SceneManager.LoadScene("Morreu");
            }
        }

        if (invencible)
        {
            if (other.CompareTag("purple") || other.CompareTag("green") || other.CompareTag("yellow") || other.CompareTag("red"))
            {
                if (!crackWheel.isPlaying)
                {
                    crackWheel.Play();
                }
            }
        }


    }

    public void AddScore()
    {
        score++;
        powerScore++;
        hardScore++;

        if (powerScore >= 3)
        {
            powerScore = 0;
            ImortalHour();
        }

        if (hardScore >= 7)
        {
            hardScore = 0;
            wheelMoveScript.AddRange();
            wheelMoveScript1.AddRange();
        }

        scoreText.text = "Pontos: " + score;
    }

    public void ImortalHour()
    {
        invencible = true;
        becomeRocket.Play();
        _ballSprite.sprite = spriteArray[4];
        fireStar.Play();
        StartCoroutine(WaitAndMortal());     
    }
    

    public IEnumerator WaitAndMortal()
    {
        yield return new WaitForSeconds(5);
        invencible = false;
        fireStar.Stop();
        colorChange();
    }
}
