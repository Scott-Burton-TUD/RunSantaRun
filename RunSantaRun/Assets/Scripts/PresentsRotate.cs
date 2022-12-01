using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PresentsRotate : MonoBehaviour
{
    public float rotateSpeed = 0.25f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}

