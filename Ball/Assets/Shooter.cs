using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject stone;
    float delta = -0.1f;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
        Vector3 direction = transform.position - collision.gameObject.transform.position;
        direction = direction.normalized * 1000;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(direction);
    }
    void Start()
    {
    }

    float timeCount = 0;
    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        if(timeCount > 3){
            Instantiate(stone, transform.position, Quaternion.identity);
            timeCount = 0;
        }
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