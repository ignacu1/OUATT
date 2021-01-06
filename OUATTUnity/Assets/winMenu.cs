using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winMenu : MonoBehaviour
{
    public GameObject winScreen;
    public GameObject StartMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void goToNextLevel(){
        winScreen.SetActive(false);
        SceneManager.LoadScene("scena2");
    }

    public void retryLevel(){
        winScreen.SetActive(false);
        SceneManager.LoadScene("RetryScene");
    }

    public void goToMenu(){
        winScreen.SetActive(false);
        StartMenu.SetActive(true);
    }
}
