using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node2 : MonoBehaviour
{
    public Ghost2 gh2;
    void Start(){
        
    }

    void Update(){
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("node")){
            gh2.NodeHit2();
        }
    }
}
