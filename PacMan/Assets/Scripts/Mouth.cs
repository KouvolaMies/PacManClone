using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Mouth : MonoBehaviour
{
    public gameManager gamemanager;
    public PacMan pacman;
    [SerializeField] private GameObject Pellets;
    private Tilemap pelletmap;
    [SerializeField] private GameObject Fruit;
    private Tilemap fruitmap;
    [SerializeField] private GameObject PowerPellets;
    private Tilemap powerpelletmap;
    [SerializeField] private Transform PacPos;
    void Start(){
        pelletmap = Pellets.GetComponent<Tilemap>();
        fruitmap = Fruit.GetComponent<Tilemap>();
        powerpelletmap = PowerPellets.GetComponent<Tilemap>();
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("pellet")){
            gamemanager.score += 10;
            Vector2 hitPosition = new Vector2(transform.position.x, transform.position.y);
            pelletmap.SetTile(pelletmap.WorldToCell(hitPosition), null);
        }
        if(collision.CompareTag("fruit")){
            gamemanager.score += 100;
            Vector2 hitPosition = new Vector2(transform.position.x, transform.position.y);
            fruitmap.SetTile(fruitmap.WorldToCell(hitPosition), null);
        }
        if(collision.CompareTag("powerpellet")){
            gamemanager.score += 20;
            pacman.power = true;
            Invoke("PowerOff", 5);
            Vector2 hitPosition = new Vector2(transform.position.x, transform.position.y);
            powerpelletmap.SetTile(powerpelletmap.WorldToCell(hitPosition), null);
        }
    }

    private void PowerOff(){
        pacman.power = false;
    }
}