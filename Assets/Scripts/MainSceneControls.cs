using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using AudioControll;

public class MainSceneControls : MonoBehaviour
{
    private Sprite sprite1, sprite2, sprite3;
    private Button btnBuhaem;
    private GameObject image;

    private AudioController au;
    
    // Start is called before the first frame update
    
    void Start()
    {
        sprite1 = Resources.Load<Sprite>("Images/shsh1");
        sprite2 = Resources.Load<Sprite>("Images/shsh2");
        sprite3 = Resources.Load<Sprite>("Images/shsh3");
        image = GameObject.Find("MainImage");
        
        btnBuhaem = GameObject.Find("Button").GetComponent<Button>();
        au = new AudioController(GetComponent<AudioSource>());


        
    }
    
    public void buhaemOnClick()
    {
        setImage2();
        au.audioZaDruzhbu();
        Invoke("setImage3", 5);
        Invoke("setImage1", 7);
        Invoke("enabledButton", 7);
        
    }

    void enabledButton(){
        btnBuhaem.enabled = true;
        btnBuhaem.interactable = true;
    }

    private void setImage1(){
        image.GetComponent<Image>().sprite = sprite1;
    }
    private void setImage2(){
        image.GetComponent<Image>().sprite = sprite2;
    }
    private void setImage3(){
        image.GetComponent<Image>().sprite = sprite3;
    }

    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
       SceneManager.LoadScene("Scenes/Scene1");
    }
    


}
