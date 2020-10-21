using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterDelay : MonoBehaviour
{
    [SerializeField]
    float delay;

    void FixedUpdate()
    {
        delay -= Time.fixedDeltaTime;
        if (delay < 0) Destroy(gameObject);
    }
}
