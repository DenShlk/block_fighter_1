using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggeredDestroyer : MonoBehaviour
{
    [SerializeField]
    GameObject parentObject;

    private void OnTriggerEnter(Collider other) 
    {
        OnTriggeredDestroyerListener.State state;
        if(other.gameObject.GetComponent<MissedObstaclesCatcher>() != null)
        {
            state = OnTriggeredDestroyerListener.State.Missed;
        }
        else
        {
            state = OnTriggeredDestroyerListener.State.Cut;
        }
        parentObject.SendMessage("SelfDestroy", state);
    }
}
