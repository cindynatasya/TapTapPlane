using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameStart;
    public GameObject bg;
    Rigidbody2D bgrb;
    
    void Awake()
    {
        if(instance==null){
            instance=this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameStart=false;
        bgrb = bg.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart){
            Runningbg();
        }
        else{
            bgrb.velocity = Vector2.zero;
        }
    }

    void Runningbg(){
        if(bgrb.transform.position.x > -6){
        bgrb.velocity = new Vector2(-0.5f,0);
        }
        else{
            bgrb.transform.position = new Vector2(0.84f, 0);
        }
    }

    public void home(){
        SceneManager.LoadScene(0);
    }
    public void ulang(){
        SceneManager.LoadScene(1);
    }
}
