using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;
    public int score;
    public int highscore;
    public Text textscore;
    // Start is called before the first frame update
    void Awake()
    {
        if(instance==null){
            instance=this;
        }
        if(PlayerPrefs.HasKey("Highscore")){
            highscore = PlayerPrefs.GetInt("Highscore");
        }
        else{
            PlayerPrefs.SetInt("Highscore", 0);
        }
    }

    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        textscore.text = score.ToString();
    }
}
