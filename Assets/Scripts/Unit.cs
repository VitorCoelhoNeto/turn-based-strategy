using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private const float STOPPING_DISTANCE = .1f;

    private Vector3 targetPosition;

    private void Update()
    {
        if(Vector3.Distance(transform.position, targetPosition) > STOPPING_DISTANCE)
        {
            Vector3 moveDirection = (this.targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * Time.deltaTime * moveSpeed;
        }

        if(Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;
    }
}