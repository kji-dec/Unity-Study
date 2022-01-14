using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text coinText;
    public int coinCount = 0;
    public void RestartGame(){
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
        coinText.text = coinCount + "개";
    }

    // Start is called before the first frame update
    void Start()
    {
        coinText.text = coinCount + "개";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
