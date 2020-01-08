using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AudioControll;
using ImageControll;

public class MainSceneControls : MonoBehaviour
{
    private Button btnBuhaem;
    private AudioController au;

    private ImagesController im;
    // Start is called before the first frame update
    
    void Start()
    {
        au = new AudioController(GetComponent<AudioSource>());
        im = new ImagesController(GameObject.Find("MainImage"));
        btnBuhaem = GameObject.Find("Button").GetComponent<Button>();
    }
    
    public void buhaemOnClick()
    {
        im.setImage2();
        au.audioZaDruzhbu();
        Invoke("setImage3", 5);
        Invoke("setImage1", 7);
        Invoke("enabledButton", 7);
        
    }

    void setImage1(){
        im.setImage1();
    }
    void setImage3(){
        im.setImage3();
    }

    void enabledButton(){
        btnBuhaem.enabled = true;
        btnBuhaem.interactable = true;
    }

    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
       SceneManager.LoadScene("Scenes/Scene1");
    }
    


}
