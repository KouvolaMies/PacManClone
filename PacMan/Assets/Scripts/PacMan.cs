using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour
{
    private Rigidbody2D rb;
    public bool power;
    public gameManager gamemanager;
    public Ghost gh;
    public Ghost2 gh2;
    private void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update(){
        Movement();
    }

    private void Movement(){
        if(Input.GetAxis("Horizontal") > 0.1f){
            rb.velocity = new Vector2(5, rb.velocity.y);
        }
        if(Input.GetAxis("Horizontal") < -0.1f){
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        if(Input.GetAxis("Vertical") > 0.1f){
            rb.velocity = new Vector2(rb.velocity.x, 5);
        }
        if(Input.GetAxis("Vertical") < -0.1f){
            rb.velocity = new Vector2(rb.velocity.x, -5);
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        if(collision.collider.tag == "ghost"){
            if(power == true){
                gamemanager.score += 250;
                gh.Eaten();
            }
            else{
                gamemanager.GameOver();
            }
        }
        if(collision.collider.tag == "ghost2"){
            if(power == true){
                gamemanager.score += 250;
                gh2.Eaten2();
            }
            else{
                gamemanager.GameOver();
            }
        }
    }
}