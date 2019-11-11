using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BuhaemOnClick : MonoBehaviour
{
    private Sprite sprite1, sprite2, sprite3;
    private GameObject image;
    // Start is called before the first frame update
    void Start()
    {
        sprite1 = Resources.Load<Sprite>("Images/first_image");
        sprite2 = Resources.Load<Sprite>("Images/second_image");
        sprite3 = Resources.Load<Sprite>("Images/third_image");
        image = GameObject.Find("MainImage");
        Button btnBuhaem = GetComponent<Button>();
        btnBuhaem.onClick.AddListener(buhaemOnClick);
    }
    
    public void buhaemOnClick()
    {
        setImage2();
        Invoke("setImage3", 5);
        Invoke("setImage1", 7);
    }

    public void setImage1(){
        image.GetComponent<Image>().sprite = sprite1;
    }
    public void setImage2(){
        image.GetComponent<Image>().sprite = sprite2;
    }
    public void setImage3(){
        image.GetComponent<Image>().sprite = sprite3;
    }


    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
       SceneManager.LoadScene("Scenes/Scene1");
    }
    


}
