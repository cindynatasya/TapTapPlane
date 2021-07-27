using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pescontrol : MonoBehaviour
{
    Rigidbody2D rb;
    float nilainaik;
    public GameObject fpes;
    public GameObject gameover;
    public GameObject scorre;
    public GameObject bom;
    public Text yourscore;
    public Text highscore;

    AudioSource audioTap;
    AudioSource audiobom;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audioTap = GetComponent<AudioSource>();
        audiobom = bom.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            if(!GameManager.instance.gameStart){
                GameManager.instance.gameStart=true;
                rb.bodyType = RigidbodyType2D.Dynamic;
            }
            else{
                rb.velocity=Vector2.zero;
                rb.AddForce (new Vector2(0,200));
                audioTap.Play();
            }
        }
    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.gameObject.tag=="kotak"||obj.gameObject.tag=="batasB"||obj.gameObject.tag=="batasA"){
            if(scoremanager.instance.highscore < scoremanager.instance.score){
                PlayerPrefs.SetInt("Highscore", scoremanager.instance.score);
            }
            yourscore.text = scoremanager.instance.score.ToString();
            highscore.text = PlayerPrefs.GetInt("Highscore").ToString();

            audiobom.Play();

            fpes.transform.position = transform.position;
            Destroy(gameObject);
            fpes.SetActive(true);
            scorre.SetActive(false);
            gameover.SetActive(true);
            GameManager.instance.gameStart=false;
        }
    }
}
