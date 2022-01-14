using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraWork : MonoBehaviour
{
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        // ball = GameObject.Find("Ball");
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("I am Camera. And Ball is at " + ball.transform.position.z);
        transform.position = new Vector3(0, ball.transform.position.y + 3, ball.transform.position.z - 14);
    }
}
