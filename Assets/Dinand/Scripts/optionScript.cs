using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class optionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PauseGame()
    {
        Time.timeScale = 0;
        //Disable scripts that still work while timescale is set to 0
    } 
    public void ContinueGame()
    {
        Time.timeScale = 1;
        //enable the scripts again
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void StartFFA()
    {
       SceneManager.LoadScene("Scenes/FFA Map");
    }
}
