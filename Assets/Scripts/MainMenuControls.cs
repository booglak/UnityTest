using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenuControls : MonoBehaviour
{
   public void pressStart(){
       SceneManager.LoadScene("Scenes/Scene2");
   }
   public void pressSettings(){
       SceneManager.LoadScene("Scenes/Scene3");
   }

    // Update is called once per frame
    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
    Application.Quit(); 
    }
}
