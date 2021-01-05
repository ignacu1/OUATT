using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class startMenuScript : MonoBehaviour
{

    public GameObject startMenuUI;

    public GameObject menuUI;

    public GameObject creatorsUI;
    

    public bool gameIsPaused;
    // Start is called before the first frame update
    void Start()
    {
        startMenuUI.SetActive(true);
        gameIsPaused = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Play(){
        
        startMenuUI.SetActive(false);
        
        Time.timeScale = 1f;

    }

    public void Menu(){
        startMenuUI.SetActive(false);
        menuUI.SetActive(true);
        
    }

    public void QuitGame(){
        Debug.Log("Quiting...");
        Application.Quit();
    }

    public void creators(){
        startMenuUI.SetActive(false);
        creatorsUI.SetActive(true);
        
    }

    public void backFromMenu(){
        menuUI.SetActive(false);
        startMenuUI.SetActive(true);
        
    }

    public void backFromCreators(){
        creatorsUI.SetActive(false);
        startMenuUI.SetActive(true);
    }
}
