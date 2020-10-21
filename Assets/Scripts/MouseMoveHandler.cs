using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveHandler : MonoBehaviour
{
    [SerializeField]
    float distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 direction = ray.direction;

        float zProjection = direction.z;
        float fraction = distance / zProjection;

        transform.position = Camera.main.transform.position + direction * fraction;
    }
}
