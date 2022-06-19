using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pers2 : MonoBehaviour
{
    private Animator anim;
    public bool isStart;
    public Vector3 startPos;
    public Vector3 currentPos;
    public float speed;
    public bool isWin;
    public GameObject pers1;
    public float speedCtrl;
    void Start()
    {

        anim = GetComponent<Animator>();
    }

    public void running()
    {
        isWin = false;
        speedCtrl = speed;
         currentPos = gameObject.transform.position;
        startPos = currentPos;
        if (isStart)
        {
            anim.SetBool("Running", true);
        }
    }

    public void EndAnim()
    {
        speed = speedCtrl;
        gameObject.transform.position = startPos;
        isStart = false;
        anim.SetBool("Running", false);
        anim.SetBool("Win2", false);
    }
    public void  FixedUpdate()
    {
        if (isStart)
        {
            gameObject.transform.position = currentPos;
            currentPos = new Vector3(gameObject.transform.position.x + speed, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x >= 100)
        {
            speed = 0;
            if (!pers1.GetComponent<Pers1>().isWin)
            {
                anim.SetBool("Win2", true);
                isWin = true;
            }
            else
            {
                anim.SetBool("Running", false);
            }
           
            
        }
        

    }
}
