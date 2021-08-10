using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text winText;
    public Image background;

    // Start is called before the first frame update
    void Start()
    {
        winText.gameObject.SetActive(false);
        background.gameObject.SetActive(false);
    }
    
    //Display the UI elements for the game's winner
    public void Display(string playerText)
    {
        winText.text = playerText + " wins!";
        winText.gameObject.SetActive(true);
        background.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
