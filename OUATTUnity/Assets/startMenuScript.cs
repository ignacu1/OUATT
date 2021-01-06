using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class startMenuScript : MonoBehaviour
{

    public GameObject startMenuUI;

    public GameObject menuUI;

    public GameObject creatorsUI;
    public pauseMenuScript pauseMenuScript;
    public GameObject healthText;

    public GameObject storyScreen;
    

    public bool gameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
        startMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(){
        
        startMenuUI.SetActive(false);
        
        Time.timeScale = 0f;
        pauseMenuScript.isPaused = false;
        healthText.SetActive(true);
        storyScreen.SetActive(true);
        

    }

    public void Menu(){
        startMenuUI.SetActive(false);
        menuUI.SetActive(true);
        healthText.SetActive(false);
        
    }

    public void QuitGame(){
        Debug.Log("Quiting...");
        Application.Quit();
    }

    public void creators(){
        startMenuUI.SetActive(false);
        creatorsUI.SetActive(true);
        healthText.SetActive(false);
        
    }

    public void backFromMenu(){
        menuUI.SetActive(false);
        startMenuUI.SetActive(true);
        
    }

    public void backFromCreators(){
        creatorsUI.SetActive(false);
        startMenuUI.SetActive(true);
    }

    public void story(){
        Time.timeScale = 1f;
        storyScreen.SetActive(false);
    }


}
