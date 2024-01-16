using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatingHearth : MonoBehaviour
{
    public float beatSpeed = 2.0f; // Speed of the heartbeat
    public float beatScale = 0.1f; // Scale factor of the heartbeat

    private Vector3 originalScale; // Original scale of the object

    // Start is called before the first frame update
    void Start()
    {
        originalScale = transform.localScale; // Store the original scale
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the scale factor using a sine wave
        float scale = 1 + Mathf.Sin(Time.time * beatSpeed) * beatScale;

        // Apply the scale to the object
        transform.localScale = originalScale * scale; // Multiply the original scale by the calculated factor
    }
}