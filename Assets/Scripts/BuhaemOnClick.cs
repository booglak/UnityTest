using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuhaemOnClick : MonoBehaviour
{
    private Sprite sprite1, sprite2, sprite3;
    private Button btnBuhaem;
    private GameObject image;
    private AudioSource audioPlayer;
    private AudioClip zaDruzbu;
    // Start is called before the first frame update
    
    private void Awake ()
    {
        audioPlayer = GetComponent<AudioSource> ();
    }
    void Start()
    {
        sprite1 = Resources.Load<Sprite>("Images/first_image");
        sprite2 = Resources.Load<Sprite>("Images/second_image");
        sprite3 = Resources.Load<Sprite>("Images/third_image");
        image = GameObject.Find("MainImage");
        
        zaDruzbu = Resources.Load<AudioClip>("Audio/za_druzhbu");

        btnBuhaem = GetComponent<Button>();
        btnBuhaem.onClick.AddListener(buhaemOnClick);
    }
    
    public void buhaemOnClick()
    {
        btnBuhaem.enabled = false;
        btnBuhaem.interactable = false;
        setImage2();
        audioZaDruzhbu();
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

    private void audioZaDruzhbu(){
        audioPlayer.clip = zaDruzbu;
        audioPlayer.Play();
    }


    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
       SceneManager.LoadScene("Scenes/Scene1");
    }
    


}
