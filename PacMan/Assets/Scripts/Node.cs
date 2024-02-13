using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public Ghost gh;
    
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("node")){
            gh.NodeHit();
        }
    }
}