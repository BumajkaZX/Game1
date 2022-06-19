using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class Pers1 : MonoBehaviour
{
    public GameObject cam;
    private Animator anim;
    public bool isStart;
    public bool endCam;
    public float speed;
    public Vector3 startPos;
    public Vector3 camPos;
    public float acceleration;
    public float accelerationD;
    public GameObject end;
    public bool isWin;
    public GameObject pers2;
    float speedContorl;
    public bool res;
    
    
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void SetStartPos()
    {
        isWin = false;
        speedContorl = speed;
        startPos = gameObject.transform.position;
        camPos = cam.transform.position;
        if (isStart)
        {
            anim.SetBool("RunningMain", true);
        }
    }
    public void FixedUpdate()
    {
   
        if (speed >= 0 && speed - (speed / accelerationD) > 0)
        {
            speed = speed -  (speed  / accelerationD )     ;
            if (isStart)
            {
                gameObject.transform.position = new Vector3(gameObject.transform.position.x + (speed * Time.deltaTime), gameObject.transform.position.y, gameObject.transform.position.z);
                if (!endCam)
                {
                    cam.transform.position = new Vector3(cam.transform.position.x + (speed * Time.deltaTime), cam.transform.position.y, cam.transform.position.z);
                }

                if (cam.transform.position.x + (speed * Time.deltaTime) >= 95.5)
                {
                    endCam = true;
                }
            }
        }
        if (gameObject.transform.position.x >= 100)
        {
            speed = -1;
            if (!pers2.GetComponent<Pers2>().isWin)
            {
                anim.SetBool("Win", true);
                isWin = true;
                if (!res)
                {
                    cam.GetComponent<ShootStart>().win = true;
                    res = true;
                }
                
            }
            else
            {
                anim.SetBool("RunningMain", false);
            }


        }
        if (isStart)
        {

            if (Input.anyKeyDown)
                speed = speed + acceleration;
        }

    }
    public void EndAnim()
    {
        speed = speedContorl;
        gameObject.transform.position = startPos;
        isStart = false;
        anim.SetBool("RunningMain", false);
        anim.SetBool("Win", false);
        cam.transform.position = camPos;
        endCam = false;
    }
  
}
    
    

