using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float walkspeed;
    
    public float rotSpeed=100.0f;

   // private Transform tr;
    //旋转速度
    private void Start()
    {
     //   tr = GetComponent<Transform>();
    }


    //public Vector3 character;



    // Update is called once per frame
    void Update()
    {
        // walkforward();
        
        //Vector3 direction = Input.GetAxis("Horizontal") * transform.right +
        //                    Input.GetAxis("Vertical") * transform.forward;

       // GetComponent<Rigidbody>().AddForce(direction.normalized * walkspeed, ForceMode.Acceleration);
        // transform.position = transform.position + walkspeed * direction * Time.deltaTime;
        //UpdateMovement();
       // tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
       // tr.Rotate(Vector3.left * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse Y"));
    }
    void walkforward()
    {
        transform.position = transform.position + transform.forward * Time.deltaTime;


    }
}
   