using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _smoothTime = 0.3f;
    private Vector3 velocity = Vector2.zero;

    [SerializeField] private Vector3 _positionToLook;

    private void FixedUpdate()
    {
        Vector3 _targetPosition = _target.TransformPoint(_positionToLook);

        transform.position = Vector3.SmoothDamp(transform.position, _targetPosition, ref velocity, _smoothTime);
    }
}
