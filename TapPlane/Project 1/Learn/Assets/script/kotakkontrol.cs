using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kotakkontrol : MonoBehaviour
{
    float speed;
    float speednaik;
    Rigidbody2D rb;
    public GameObject kotak2;

    AudioSource audiopoin;
    void Awake()
    {
        float ran = Random.Range(2.5f, -1.5f);
        float rand = Random.Range(-4f, -5f);
        this.transform.position = new Vector2(2.85f, ran);
        kotak2.transform.position = new Vector2(3.9916f, rand);
    }
    // Start is called before the first frame update
    void Start()
    {
       speed=0.8f;
       speednaik=1;
       rb = GetComponent<Rigidbody2D>();
       InvokeRepeating("kotakjalan",1f,1f);
       audiopoin = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void kotakjalan(){
        if(GameManager.instance.gameStart){
            speednaik=-speednaik;
            rb.velocity = new Vector2(-speed,speednaik);
        } 
        else{
            rb.velocity = Vector2.zero;
        }
    }
    void OnTriggerEnter2D(Collider2D obj)
    {
        if(obj.gameObject.tag=="penghapuskotak"){
            Destroy(gameObject);
        }else if(obj.gameObject.tag=="poin"){
            scoremanager.instance.score++;
            audiopoin.Play();
        }
    }
}
