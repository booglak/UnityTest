using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuhaemOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnBuhaem = GetComponent<Button>();
        btnBuhaem.onClick.AddListener(buhaemOnClick);
        
    }
    private Sprite sprite1, sprite2, sprite3;
    private GameObject image;
    public void buhaemOnClick()
    {
        image = GameObject.Find("MainImage");
        sprite2 = Resources.Load<Sprite>("Images/second_image");
        image.GetComponent<Image>().sprite = sprite2;
    }
    


}
