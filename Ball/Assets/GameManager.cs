using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int coinCount = 0;
    void RestartGame(){
        Application.LoadLevel("Game");
    }

    void RedCoinStart(){
        DestroyObstacles();
    }

    void DestroyObstacles(){
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for(int i = 0; i < obstacles.Length; i++){
            Destroy(obstacles[i]);
        }
    }

    void GetCoin(){
        coinCount ++;
        Debug.Log(coinCount);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
