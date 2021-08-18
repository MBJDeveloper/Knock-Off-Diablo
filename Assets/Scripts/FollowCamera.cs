using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform Camera;

    void Update()
    {
        transform.position = target.position;
    }
}
