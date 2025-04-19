using System;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private const string IS_WALKING= "IsWalking";

    [SerializeField] private Animator unitAnimator;

    private const float STOPPING_DISTANCE = .1f;

    private Vector3 targetPosition;
    private float rotateSpeed = 7f;

    private void Update()
    {
        
        if(Vector3.Distance(transform.position, targetPosition) > STOPPING_DISTANCE)
        {
            Vector3 moveDirection = (this.targetPosition - transform.position).normalized;
            float moveSpeed = 4f;
            transform.position += moveDirection * Time.deltaTime * moveSpeed;

            transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * rotateSpeed);
            unitAnimator.SetBool(IS_WALKING, true);
        }
        else
        {
            unitAnimator.SetBool(IS_WALKING, false);
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