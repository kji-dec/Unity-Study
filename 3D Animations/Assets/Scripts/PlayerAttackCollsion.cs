using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackCollsion : MonoBehaviour
{
    private void OnEnable(){
        StartCoroutine("AutoDisable");
    }

    private void OnTriggerEnter(Collider other) {
        other.GetComponent<EnemyController>().TakeDamage(10);
    }

    private IEnumerator AutoDisable(){
        yield return new WaitForSeconds(0.1f);

        gameObject.SetActive(false);
    }
}
