// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class UiManagerScript : MonoBehaviour
// {
//  public GameObject GameOverScreen;
//  public string currentColor;
//  private void Awake(){
//     GameOverScreen.SetActive(false);
//  }

//     // Update is called once per frame
//     void Update()
//     {
  
        
//     }


// }



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManagerScript : MonoBehaviour
{
    public static UiManagerScript instance; // Singleton pattern to allow other scripts to access UiManagerScript instance
    public GameObject GameOverScreen;

    private void Awake()
    {
        if (instance == null)
            instance = this;

        GameOverScreen.SetActive(false);
    }

    public void ShowGameOverScreen()
    {
        GameOverScreen.SetActive(true);
        // You can add additional logic here for the Game Over screen
    }

    // ... (rest of the code)
}

