using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ImageControll {

public class ImagesController : MonoBehaviour
{
    private Sprite sprite1, sprite2, sprite3;
    private GameObject image;
    public ImagesController(GameObject image){
        sprite1 = Resources.Load<Sprite>("Images/shsh1");
        sprite2 = Resources.Load<Sprite>("Images/shsh2");
        sprite3 = Resources.Load<Sprite>("Images/shsh3");
        this.image = image;
        
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
}
}
