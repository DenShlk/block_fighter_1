using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggeredDestroyerListener : MonoBehaviour
{
    [SerializeField]
    GameObject AfterDestroyFXPrefab;

    public enum State { Missed, Cut };
    public void SelfDestroy(State state)
    {
        if (state == State.Cut)
        {
            Instantiate(AfterDestroyFXPrefab, transform.position, transform.rotation);
        }
        gameObject.SetActive(false);
        Destroy(gameObject);
    }
}
