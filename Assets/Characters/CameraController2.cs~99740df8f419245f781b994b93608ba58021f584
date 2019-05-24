using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 1. Follow on player's X/Z plane
/// 2. Smooth rotation around the player ito 45 degree increments
/// </summary>
public class CameraController2 : MonoBehaviour
{
    public Transform target2;
    public Vector3 offsetPos2;
    public float moveSpeed2 = 5;
    public float turnSpeed2 = 10;
    public float smoothSpeed2 = 0.5f;

    Quaternion targetRotation2;
    Vector3 targetPos2;
    bool smoothRotating = false;

    void Update()
    {
        MoveWithTarget();
        LookAtTarget();

        if (Input.GetKeyDown(KeyCode.G) && !smoothRotating)
        {
            StartCoroutine("RotateAroundTarget", 45);
        }

        if (Input.GetKeyDown(KeyCode.H) && !smoothRotating)
        {
            StartCoroutine("RotateAroundTarget", -45);
        }
    }
    /// <summary>
    /// Move the camera to the player position + current camera offset
    /// Offset modified by RotateAroundTarget coroutine
    /// </summary>
    void MoveWithTarget()
    {
        targetPos2 = target2.position + offsetPos2;
        transform.position = Vector3.Lerp(transform.position, targetPos2, moveSpeed2 * Time.deltaTime);
    }
    /// <summary>
    /// Use the Look vector (target - current) to aim the camera towards the player
    /// </summary>
    void LookAtTarget()
    {
        targetRotation2 = Quaternion.LookRotation(target2.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation2, turnSpeed2 * Time.deltaTime);
    }
    /// <summary>
    /// This coroutine can only have an instance running at a time
    /// Determined by "smoothRotating"
    /// </summary>
    IEnumerator RotateAroundTarget(float angle)
    {
        Vector3 vel = Vector3.zero;
        Vector3 targetOffsetPos = Quaternion.Euler(0, angle, 0) * offsetPos2;
        float dist = Vector3.Distance(offsetPos2, targetOffsetPos);
        smoothRotating = true;

        while (dist > 0.02f)
        {
            offsetPos2 = Vector3.SmoothDamp(offsetPos2, targetOffsetPos, ref vel, smoothSpeed2);
            dist = Vector3.Distance(offsetPos2, targetOffsetPos);
            yield return null;
        }

        smoothRotating = false;
        offsetPos2 = targetOffsetPos;
    }
}
