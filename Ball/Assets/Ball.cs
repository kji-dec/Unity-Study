using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // float startingPoint;
    // SphereCollider myCollider;
    // Start is called before the first frame update
    void Start()
    {
        // myCollider = GetComponent<SphereCollider>();
        // Rigidbody myRigidbody = GetComponent<Rigidbody>();
        // Debug.Log("UseGravity?: " + myRigidbody.useGravity);
        // Debug.Log("Start");
        // startingPoint = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        // myCollider.radius += 0.01f;
        // float distance;
        // distance = transform.position.z - startingPoint;
        // Debug.Log(distance);
        if(Input.GetKeyDown(KeyCode.Space)){
            GetComponent<Rigidbody>().AddForce(Vector3.up * 300);
        }
    }
}
