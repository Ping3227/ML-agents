using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiObjective : MonoBehaviour
{
    public bool finished=false;
    [SerializeField] Vector3 CorrectDirection;
    [SerializeField] GameFlowManager GameFlowManager;
    [SerializeField] DisplayMessage LoseMessage;
    private void Start()
    {
        finished = false;
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("AI"))
        {
            if (Vector3.Dot(other.gameObject.transform.forward, CorrectDirection) > 0) {
                finished = true;
                
            }
        }
    }
}
