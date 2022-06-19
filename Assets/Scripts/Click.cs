using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public float ToNext;
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        ToNext++;
        Debug.Log(ToNext);

    }
    
}
