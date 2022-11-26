using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] GameObject goPlayer;

    public Vector3 cameraOffset;
    private Transform target;
    [Range (0, 1)] public float lerpValue;

    // Start is called before the first frame update
    void Start()
    {
        target = goPlayer.transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + cameraOffset, lerpValue);
        // transform.LookAt(target);
    }
}
