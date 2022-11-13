using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Push : MonoBehaviour
{
    public float pushPower = 2.0f;
    public float targetMass = 10.0f;

    public Animator animator;
    public bool canPush = true;
    public AudioSource drag;
    public ThirdPersonController thirdPersonController;

    public void Start()
    {

    }

    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    Rigidbody body = hit.collider.attachedRigidbody;

    //    if(body == null || body.isKinematic)
    //    {
    //        return;
    //    }
    //    if(hit.moveDirection.y < -0.3f)
    //    {
    //        return;
    //    }

    //    animator.SetBool("Push", true);
    //    thirdPersonController.MoveSpeed = 1.0f;
    //    thirdPersonController.SprintSpeed = 1.0f;
    //    drag.Play();

    //    targetMass = body.mass;
    //    Vector3 pushDir = new Vector3(0, 0, hit.moveDirection.z);

    //    body.velocity = pushDir * pushPower/targetMass;
    //}


    private void OnCollisionEnter(Collision collision)
    {
        if (canPush)
        {
            PlayPush();
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if (canPush)
        {
            PlayPush();
        }
        else
        {
            StopPush();
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        StopPush();
    }

    private void PlayPush()
    {
        animator.SetBool("Push", true);
        thirdPersonController.MoveSpeed = 1.0f;
        thirdPersonController.SprintSpeed = 1.0f;
        drag.Play();
    }

    private void StopPush()
    {
        animator.SetBool("Push", false);
        thirdPersonController.MoveSpeed = 2.0f;
        thirdPersonController.SprintSpeed = 5.335f;
        drag.Pause();
    }
}
