using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectablesController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 0.001f;
    float rotateSpeed = 0.1f;
    float lastRotateDirectionSwitchTime = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - lastRotateDirectionSwitchTime > 1f)
        {

            rotateSpeed = rotateSpeed * -1;
            lastRotateDirectionSwitchTime = Time.time;
        }

        gameObject.transform.Rotate(0, rotateSpeed, 0);

    }
}
