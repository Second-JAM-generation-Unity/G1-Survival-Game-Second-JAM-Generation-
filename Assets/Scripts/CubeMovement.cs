using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed=15f;
    [SerializeField] private Rigidbody rb;
    Vector3 mov;
    void Start()
    {
       rb=GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        mov=new Vector3(Input.GetAxis("Horizontal"),0,Input.GetAxis("Vertical"));
    }
    private void FixedUpdate()
    {
        movementPlayer(mov);
    }
    void movementPlayer(Vector3 direccion)
    {
        rb.MovePosition(transform.position + (direccion * speed * Time.deltaTime));
    }
}
