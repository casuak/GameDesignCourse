using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCtrl : MonoBehaviour
{   //声明要分配组件的变量
    
    private Transform tr;
    private CharacterController controller;

    //声明键盘输入值变量
    private float h = 0.0f;
    private float v = 0.0f;

    //移动，旋转速度
    public float movSpeed = 5.0f;
    public float rotSpeed = 50.0f;

    private Vector3 movDir = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");
        //移动鼠标时模型的左右移动值
        tr.Rotate(Vector3.up * Input.GetAxis("Mouse X") * rotSpeed * Time.deltaTime);

        //向量加法，事先计算移动方向
        movDir = (tr.forward * v) + (tr.right * h);
        //改变y值使其受重力影响下落
        movDir.y -= 20f * Time.deltaTime;
        //移动玩家
        controller.Move(movDir * movSpeed * Time.deltaTime);
    }
}
