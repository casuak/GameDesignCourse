using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motivationmotor : MonoBehaviour
{
    [HideInInspector]
    public Vector3 movementDirection;

    [HideInInspector]
    public Vector3 movementTarget;

    [HideInInspector]
    public Vector3 facingDirection;

    public float walkingSpeed = 5.0f;
    public float walkingSnappyness = 50f;
    public float turningSmoothing = 0.3f;//旋转速度


   
    private void FixedUpdate()
    {
        Vector3 targetVelocity = movementDirection * walkingSpeed;//目标速度
        Vector3 deltaVelocity = targetVelocity - GetComponent<Rigidbody>().velocity;//目标速度-当前速度
        if (GetComponent<Rigidbody>().useGravity)
            deltaVelocity.y = 0;
        GetComponent<Rigidbody>().AddForce(deltaVelocity * walkingSnappyness, ForceMode.Acceleration);

        UpdateRotation();
    }
    void UpdateRotation()
    {
        Vector3 faceDir = facingDirection;//物体要面对的方向,目标方向
        if (faceDir == Vector3.zero)
            faceDir = movementDirection;
        if (faceDir == Vector3.zero)
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        else  
        {
            float rotatonAngle = AngleAroundAxis(transform.forward, faceDir, Vector3.up);
            //计算旋转角度
            //transform.forward是物体当前面对的方向
            GetComponent<Rigidbody>().angularVelocity = (Vector3.up * rotatonAngle*turningSmoothing);
             // 控制旋转 旋转轴是y轴 vector3.up
        }
         
    }
    static float AngleAroundAxis (Vector3 dirA,Vector3 dirB,Vector3 axis)
    {
        dirA = dirA - Vector3.Project(dirA, axis);
        dirB = dirB - Vector3.Project(dirB, axis);

        float angle = Vector3.Angle(dirA, dirB);
        return angle * (Vector3.Dot(axis, Vector3.Cross(dirA, dirB)) <0? -1 : 1);
    }
}
