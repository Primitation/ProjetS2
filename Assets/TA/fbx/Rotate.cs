using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationTime = 1f; // The time it takes to complete one rotation
    public GameObject objectToRotate; // The object you want to rotate

    private float rotationSpeed; // The speed at which the object rotates
    private float rotationAngle; // The angle the object has rotated so far

    void Start()
    {
        // Calculate the rotation speed based on the rotation time
        rotationSpeed = 360f / rotationTime;
    }

    void Update()
    {
        // Rotate the object based on the rotation speed and the elapsed time
        float rotationAmount = rotationSpeed * Time.deltaTime;
        rotationAngle += rotationAmount;
        objectToRotate.transform.rotation = Quaternion.Euler(0f, rotationAngle, 0f);

        // If the object has completed a full rotation, reset the rotation angle
        if (rotationAngle >= 360f)
        {
            rotationAngle = 0f;
        }
    }
}
