using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    // Public variables can be adjusted in the Unity editor
    public float maxSwingAngle = 70.0f; // How far the pendulum swings
    public float speed = 2.0f; // How fast the pendulum swings

    // We need a Transform to act as the point where the pendulum hangs from
    private Transform pivotPoint;

    // Start is called before the first frame update
    void Start()
    {
        // Creating a new GameObject to act as our pivot point
        GameObject pivotGameObject = new GameObject("Pivot");
        pivotPoint = pivotGameObject.transform;

        // Positioning the pivot point just above our pendulum
        pivotPoint.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);

        // Making our pendulum a child of the pivot point
        // This means when we rotate the pivot, the pendulum will swing
        transform.SetParent(pivotPoint);
    }

    // Update is called once per frame
    void Update()
    {
        // We use a sine function to get a nice swinging motion
        // Time.time * speed makes the angle change over time
        float swingAngle = maxSwingAngle * Mathf.Sin(Time.time * speed);

        // Apply this angle to our pivot's rotation
        // We rotate around the Z axis because we're in 2D
        pivotPoint.rotation = Quaternion.Euler(0, 0, swingAngle);
    }
}
