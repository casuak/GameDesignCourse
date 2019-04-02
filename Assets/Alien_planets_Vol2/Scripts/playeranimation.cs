using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playeranimation : MonoBehaviour
{
    public Animator animator;
    public int jump_flag;
    private Transform tr;
    private Vector3 localVelocity;
    private float speed;
    private float angle;
    private Vector3 lastPosition;
    private bool m_run;
    // Start is called before the first frame update
    void Start()
    {
        tr=transform;
        lastPosition = tr.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = GetComponent<Rigidbody>().velocity;

        //Vector3 velocity = (tr.position - lastPosition) / Time.deltaTime;
        //这是世界坐标系下的速度
        localVelocity = tr.InverseTransformDirection(velocity);
        //转换成本地速度
        localVelocity.y = 0;
        speed = localVelocity.magnitude;//取向量的模等于速度
        angle = (HorizontalAngle(localVelocity) + 360f) % 360f;

        lastPosition = tr.position;
        if (speed > 1)
        {
            animator.SetBool("Female Run",true);
        }
        if (speed < 1)
        {
            animator.SetBool("Female Run", false);
        }
        if (jump_flag==1)
        {
            animator.SetBool("Creepy Walk", true);
        }
        if (jump_flag == 0)
        {
            animator.SetBool("Creepy Walk", false);
        }
        Debug.Log("Speed:" + speed + "Angle:" + angle);
    }
    public void BtnTest1()
    {
        jump_flag = 1;
        
        Debug.Log("gotobtntest1" );
        
    }
    public void BtnTest2()
    {
        jump_flag = 0;

        Debug.Log("gotobtntest2");

    }
    static float HorizontalAngle(Vector3 direction)
    {
        return Mathf.Atan2(direction.z, direction.x) * Mathf.Deg2Rad;
    }
}
