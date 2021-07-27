using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Text highscoretext;
    int highscore;

    void Awake()
    {
        if(PlayerPrefs.HasKey("Highscore")){
            highscore = PlayerPrefs.GetInt("Highscore");
        }
        else{
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        highscoretext.text = PlayerPrefs.GetInt("Highscore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play(){
        SceneManager.LoadScene(1);
    }
}
