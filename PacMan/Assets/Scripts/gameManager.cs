using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public int score = 0;
    [SerializeField] TMP_Text scoretxt;

    void Update(){
        scoretxt.text = "score: " + score;
    }

    public void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}