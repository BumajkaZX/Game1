using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

using UnityEngine;

public class ShootStart : MonoBehaviour
{
    public GameObject User1;
    public GameObject User2;
    public AudioClip shoot;
    public AudioClip st;
    public AudioSource FM;
    public bool toch;
    public bool Checking;
    public GameObject exitbutton;
    public GameObject[] lights;
    public bool win;
    public bool loose;
    public AudioClip winc;
    public AudioClip loosec;


    public IEnumerator RunStart()
    {
        Checking = true;


        if (toch)
        {
            exitbutton.SetActive(false);
            for (int i = 0; i <= 2; i++)
            {
                Debug.Log("вызов1");
                yield return new WaitForSeconds(1f);
                lights[i].SetActive(false);
                FM.PlayOneShot(shoot);
              

            }
            Debug.Log("вызов");
            FM.clip = st;
            FM.Play();
            User2.GetComponent<Pers2>().isStart = true;
                User1.GetComponent<Pers1>().isStart = true;
                User1.GetComponent<Pers1>().SetStartPos();
                User2.GetComponent<Pers2>().running();
                exitbutton.SetActive(true);
                toch = false;
                Checking = false;
            
           
                
            
        }
    }
    public void Update()
    {
        if (Checking)
        {

            if ((Input.anyKey || Input.touchCount > 1) & !toch)
            {

                toch = true;
                StartCoroutine(RunStart());
            }

        }

        if (win)
        {
            FM.clip = null;
            FM.PlayOneShot(winc);
            win = false;

        }

    }     
    public void ButtonStart()
    {
        StartCoroutine(RunStart());
    }
    public void  SetToNormal()
    {
        for (int i= 0; i<=2; i++)
        {
            lights[i].SetActive(true);
        }
    }
}
