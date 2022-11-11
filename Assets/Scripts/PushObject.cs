using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushObject : MonoBehaviour
{
    [SerializeField] private float pushForce = 2.0f;

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (body == null || body.isKinematic)
            {
                return;
            }
            if (hit.moveDirection.y < -0.3f)
            {
                return;
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                Vector3 pushDir = new Vector3(0, 0, hit.moveDirection.z);

                body.velocity = pushDir * pushForce;
            }
        }


    }
}
