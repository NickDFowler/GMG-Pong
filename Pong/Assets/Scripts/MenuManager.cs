using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Load single player
    public void LoadSingle()
    {
        SceneManager.LoadScene("Single");
    }

    //Load multi player
    public void LoadMulti()
    {
        SceneManager.LoadScene("Multi");
    }
    
    //Quit game
    public void Quit()
    {
        Application.Quit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
