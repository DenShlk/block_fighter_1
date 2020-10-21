using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordTurnOnOffBehavior : MonoBehaviour
{
    [SerializeField]
    GameObject swordUp;
    [SerializeField]
    float turningDuration;

    enum SwordState { Opened, Closed, Opening, Closing };
    private SwordState state;
    private float timeSinceChanged;
    private bool isOpened;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeSinceChanged += Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (!isOpened)
            {
                timeSinceChanged = 0;
                isOpened = true;
            }
        }
        else
        {
            if (isOpened)
            {
                timeSinceChanged = 0;
                isOpened = false;
            }
        }

        float fraction = timeSinceChanged / turningDuration;

        Vector3 scale = swordUp.transform.localScale;


        if (isOpened)
        {
            // from 0 to 1
            scale.y = Interpolate(fraction);
        }
        else
        {
            //from 1 to 0
            scale.y = 1 - Interpolate(fraction);
        }

        scale.y = Mathf.Clamp(scale.y, 0, 1);

        swordUp.transform.localScale = scale;

    }

    private float Interpolate(float fraction)
    {
        return fraction * fraction;
    }
}
