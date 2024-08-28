using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothTime = 0.1f;

    public Vector3 velocity = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 targetPosition = player.position + offset;
    //  targetPosition.z = transform.position.z;
    //  targetPosition.x = transform.position.x;
    //  Debug.Log(targetPosition.z);
     transform.position = Vector3.SmoothDamp(transform.position,targetPosition,ref velocity,smoothTime);

    //  float mx = Input.GetAxis("Mouse X");
    //  float my = Input.GetAxis("Mouse Y");

    //  if(Mathf.Abs(mx) > 0.001f)
    //  {
    //     transform.RotateAround(player.transform.position,Vector3.up,mx);
    //  }

    //  if(Mathf.Abs(my) > 0.001f)
    //  {
    //     transform.RotateAround(player.transform.position,Vector3.up,my);
    //  }
    }
}
