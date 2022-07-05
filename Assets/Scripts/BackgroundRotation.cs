using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    public float rotationSpeed = 0.01f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 0, rotationSpeed, Space.World);
    }
}
