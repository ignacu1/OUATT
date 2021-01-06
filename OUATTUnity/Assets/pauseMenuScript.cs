using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseMenuScript : MonoBehaviour
{
    public GameObject menuUI;
    public GameObject pasueMenuUI;
    public GameObject healthText;
    public GameObject startMenuUI;
    
    
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
    }

    // Update is called once per frame
    void Update()
    {


        
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isPaused == false){
                PauseGame();
            }
        }
    }

    public void Return(){
        pasueMenuUI.SetActive(false);
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void QuitGame(){
        Application.Quit();
        Debug.Log("Quiting...");
    }

    public void GoToMenu(){
        SceneManager.LoadScene("scena1");
    }

    public void backFromMenu(){
        menuUI.SetActive(false);
        pasueMenuUI.SetActive(true);
    }

    void PauseGame(){
        Time.timeScale = 0f;
        isPaused = true;
        pasueMenuUI.SetActive(true);
    }


}
