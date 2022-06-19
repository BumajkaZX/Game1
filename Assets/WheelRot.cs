using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRot : MonoBehaviour
{
    float x = 0;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * 400f;
        gameObject.transform.localEulerAngles = new Vector3(x, -90f, 90f);
    }
}
