﻿using UnityEngine;
using System.Collections;

public class cameraFollow2 : MonoBehaviour
{

    public Transform target;
    public float damping = 1;
    public float lookAheadFactor = 3;
    public float lookAheadReturnSpeed = 0.5f;
    public float lookAheadMoveThreshold = 0.1f;

    private float offsetZ;
    private Vector3 lastTargetPosition;
    private Vector3 currentVelocity;
    private Vector3 lookAheadPos;

    // Use this for initialization
    void Start()
    {
        lastTargetPosition = target.position;
        offsetZ = transform.position.z - target.position.z;
        transform.parent = null;
    }

    // Update is called once per frame
    void Update()
    {
        // only update lookahead pos if accelerating or changed direction
        float xMoveDelta = target.position.x - lastTargetPosition.x;
        bool updateLookAheadTarget = Mathf.Abs(xMoveDelta) > lookAheadMoveThreshold;
        if (updateLookAheadTarget)
        {
            lookAheadPos = lookAheadFactor * Vector3.right * Mathf.Sign(xMoveDelta);
        }
        else
        {
            lookAheadPos = Vector3.MoveTowards(lookAheadPos, Vector3.zero, Time.deltaTime * lookAheadReturnSpeed);
        }
        Vector3 aheadTargetPos = target.position + lookAheadPos + Vector3.forward * offsetZ;
        Vector3 newPos = Vector3.SmoothDamp(transform.position, aheadTargetPos, ref currentVelocity, damping);
        transform.position = newPos;
        lastTargetPosition = target.position;
    }
}

