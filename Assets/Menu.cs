using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public string jogo;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(jogo);
    }

    public void Quit()
    {
        UnityEditor.EditorApplication.isPlaying = false;
       // Application.Quit();
    }
}
