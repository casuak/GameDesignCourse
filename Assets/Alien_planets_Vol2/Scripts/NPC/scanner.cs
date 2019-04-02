using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scanner : MonoBehaviour
{
    public Animator animator;
    public int flag = 0;
    public float fieldOfViewAngle = 110f;
    public struct x
    {
        int s;
    }
    public x i;
   // public SignalSender playerInsightSignal = new SignalSender();
   // public SignalSender playerOutsightSignal = new SignalSender();
    [HideInInspector]//??
    public bool playerInsight;
    private SphereCollider col;
    private GameObject player;
    private Vector3 lastPlayerPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        col = GetComponent<SphereCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1)
        {
         animator.SetBool("New Bool", true);
        }
        if(flag==0)
        {
            animator.SetBool("New Bool", false);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {

            flag = 1;
        }
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject == player)
        {
            flag = 1;
            // if (DetectPlayer())
            //        playerInsightSignal.SendSignals(this, lastPlayerPosition);
            //   
        }
    }
    private void OnTriggerExit(Collider other)
    {
        
       if (other.gameObject==player)
        {
            flag = 0;
       //     if (!DetectPlayer())
       //     {
       //         playerInsight = false;
       //    playerOutsightSignal.SendSignals(this);
       //      }
        }
    }
    bool DetectPlayer()
    {
        playerInsight = false;
        Vector3 direction = player.transform.position - transform.position;
        float angle = Vector3.Angle(direction, transform.forward);
        if (angle<fieldOfViewAngle*0.5f)
        {
            RaycastHit hit;
          // if(hit.collider.gameObject==player)
            {
                playerInsight = true;
                lastPlayerPosition = player.transform.position;
            }
        }
        return playerInsight;
    }
    private void OnEnable()
    {
        
    }
}
