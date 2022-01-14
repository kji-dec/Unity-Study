using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    float delta = -0.1f;
    // Start is called before the first frame update
    // void TestMethod(string name){
    //     float distance = Vector3.Distance(GameObject.Find(name).transform.position, transform.position);
    //     Debug.Log(name + "까지 거리: " + distance);
    // }
    void OnCollisionEnter(Collision collision) {
        // Debug.Log(collision.gameObject.name);
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }
    void Start()
    {
    }

    // Update is called once per frame
    protected void Update()
    {
        // TestMethod("Ball");

        float newXPosition = transform.localPosition.x + delta;
        transform.localPosition = new Vector3(newXPosition, transform.localPosition.y, transform.localPosition.z);
        if(transform.localPosition.x < -3.5){
            delta = 0.1f;
        }
        else if (transform.localPosition.x > 3.5){
            delta = -0.1f;
        }
    }
}
