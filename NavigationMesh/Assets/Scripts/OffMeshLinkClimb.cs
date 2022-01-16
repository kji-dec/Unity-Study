using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class OffMeshLinkClimb : MonoBehaviour
{
    [SerializeField]
    private int offMeshArea = 3;
    [SerializeField]
    private float climbSpeed = 1.5f;
    private NavMeshAgent navMeshAgent;

    private void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    IEnumerator Start(){
        while(true){
            yield return new WaitUntil(() => IsOnClimb());
            yield return StartCoroutine(ClimbOrDescend());
        }
    }

    public bool IsOnClimb(){
        if(navMeshAgent.isOnOffMeshLink){
            OffMeshLinkData linkData = navMeshAgent.currentOffMeshLinkData;

            if(linkData.offMeshLink != null && linkData.offMeshLink.area == offMeshArea){
                return true;
            }
        }
        return false;
    }

    private IEnumerator ClimbOrDescend(){
        navMeshAgent.isStopped = true;

        OffMeshLinkData linkData = navMeshAgent.currentOffMeshLinkData;
        Vector3 start = linkData.startPos;
        Vector3 end = linkData.endPos;

        float climbTime = Mathf.Abs(end.y - start.y) / climbSpeed;
        float currentTime = 0.0f;
        float percent = 0.0f;

        while(percent < 1){
            currentTime += Time.deltaTime;
            percent = currentTime/climbTime;
            transform.position = Vector3.Lerp(start, end, percent);

            yield return null;
        }

        navMeshAgent.CompleteOffMeshLink();
        navMeshAgent.isStopped = false;
    }
}
