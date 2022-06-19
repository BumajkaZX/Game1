using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleDestroy : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        Animation anim = GetComponent<Animation>();
        anim.Play();
        Destroy(gameObject, anim.clip.length);

    }

    // Update is called once per frame
  
}
