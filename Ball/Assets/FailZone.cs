using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FailZone : MonoBehaviour
{

    void OnTriggerEnter(Collider collider) {
        if(collider.gameObject.name == "Ball"){
            // GameObject.Find("GameManager").SendMessage("RestartGame");
            // GameObject gm = GameObject.Find("GameManager");
            // GameManager gmComponent = gm.GetComponent<GameManager>();
            GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
            gmComponent.RestartGame();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // GameManager gmComponent = GameObject.Find("GameManager").GetComponent<GameManager>();
        // Debug.Log(gmComponent.coinCount);
    }
}
