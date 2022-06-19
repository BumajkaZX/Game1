using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextRot : MonoBehaviour
{
    public bool startrot;
    public bool other;
    public float angle;



    public void starttext()
    {
        startrot = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (startrot)
        {
            StartCoroutine(rotrot());
        }

    }
    IEnumerator rotrot()
    {
        if (!other)
        {
            gameObject.transform.Rotate(0, 0, -angle, Space.Self);
            yield return new WaitForSeconds(0.05f);
            other = true;
        }
        else
        {

            gameObject.transform.Rotate(0, 0, angle, Space.Self);
            yield return new WaitForSeconds(0.05f);
            other = false;
        }
    }
}

