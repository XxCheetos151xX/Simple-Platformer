using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Transform cameraTransform;
    private Vector3 lastCameraPosition;
    [SerializeField] private float parallaxMultiplier;

    private void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;

        // Apply parallax effect on the x-axis only
        float parallaxX = deltaMovement.x * parallaxMultiplier;
        Vector3 parallaxOffset = new Vector3(parallaxX, 0f, 0f);

        transform.position += parallaxOffset;
        lastCameraPosition = cameraTransform.position;
    }
}

