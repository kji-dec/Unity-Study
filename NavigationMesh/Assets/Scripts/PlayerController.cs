using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Movement3D movement3D;

    private void Awake() {
        movement3D = GetComponent<Movement3D>();
    }

    private void Update() {
        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity)){
                movement3D.MoveTo(hit.point);
            }
        }
    }
}
