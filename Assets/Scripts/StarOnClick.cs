using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StarOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Button btnStart = GetComponent<Button>();
        btnStart.onClick.AddListener(startOnClick);
    }

    void startOnClick(){
        SceneManager.LoadScene("Scenes/Scene2");
    }
    void Update(){
       if (Input.GetKeyDown(KeyCode.Escape)) 
    Application.Quit(); 
 }


}
