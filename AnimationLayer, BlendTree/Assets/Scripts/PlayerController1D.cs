using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1D : MonoBehaviour
{
    private Animator animator;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    private void Update() {
        float vertical = Input.GetAxis("Vertical");
        float offset = 0.5f + Input.GetAxis("Sprint") * 0.5f;
        float moveParameter = Mathf.Abs(vertical * offset);

        animator.SetFloat("moveSpeed", moveParameter);
    }
}
