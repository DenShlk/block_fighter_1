using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatonInputFromKeyboardHandler : MonoBehaviour
{

    void Update()
    {
        float angle = 0;
        if (Input.GetKey(KeyCode.D)) angle = -90;
        if (Input.GetKey(KeyCode.A)) angle = 90;
        if (Input.GetKey(KeyCode.S)) angle = 180;
        transform.localRotation = Quaternion.Euler(0, 0, angle);
    }
}
