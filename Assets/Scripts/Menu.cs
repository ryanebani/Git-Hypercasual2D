using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string jogo;
    public string telaInicial;
    public GameObject optionsMenu;
    public GameObject creditsMenu;

    [SerializeField] SpriteRenderer playOff;
    [SerializeField] SpriteRenderer configOff;
    [SerializeField] SpriteRenderer quitOff;
          
    public void Perdeu()
    {
        SceneManager.LoadScene(telaInicial);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(jogo);
    }

    public void Quit()
    {
       //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        Debug.Log("fechou o jogo");
    }

    public void Options()
    {
        optionsMenu.SetActive(true);
        playOff.enabled = false;
        configOff.enabled = true;
        quitOff.enabled = true;
    
    }

    public void Back()
    {
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        playOff.enabled = true;
        configOff.enabled = true;
        quitOff.enabled = true;
    }

    public void Credits()
    {
        creditsMenu.SetActive(true);
        playOff.enabled = false;
        configOff.enabled = false;
        quitOff.enabled = false;

    }
}
