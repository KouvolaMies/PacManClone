using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private int direction;
    private bool xvel;
    private bool yvel;
    private int stucktime;
    public PacMan pacman;

    private void Start(){
        rb = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>();
        rb.velocity = new Vector2(0, 4);
    }

    private void Update(){
        if(rb.velocity.x == 0){
            xvel = false;
        }
        else{
            xvel = true;
        }
        if(rb.velocity.y == 0){
            yvel = false;
        }
        else{
            yvel = true;
        }
        if(xvel == false && yvel == false){
            stucktime++;
        }
        else{
            stucktime = 0;
        }
        if(stucktime > 100){
            NodeHit();
        }
        if(pacman.power == true){
            sprite.color = new Color(0, 0, 255, 255);
        }
        else{
            sprite.color = new Color(255, 0, 210, 255);
        }
    }

    public void NodeHit(){
        direction = Random.Range(0, 4);
        if(direction < 1){
            rb.velocity = new Vector2(0, 4);
        }
        else if(direction > 0 && direction < 2){
            rb.velocity = new Vector2(0, -4);
        }
        else if(direction > 1 && direction < 3){
            rb.velocity = new Vector2(4, 0);
        }
        else{
            rb.velocity = new Vector2(-4, 0);
        }
    }

    public void Eaten(){
        transform.position = new Vector2(0.5f, 0.5f);
    }
}