using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kotakmuncul : MonoBehaviour
{
    public GameObject kotak;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("kotakbaru",0.2f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void kotakbaru(){
        if(GameManager.instance.gameStart){
            Instantiate(kotak);
        }
    }
}
