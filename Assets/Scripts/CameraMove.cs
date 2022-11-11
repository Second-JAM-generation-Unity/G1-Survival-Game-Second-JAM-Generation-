using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.LookAt(player.transform);
        transform.position = new Vector3(transform.position.x, player.transform.position.y + 4, player.transform.position.z);
    }
}
