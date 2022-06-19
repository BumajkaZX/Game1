using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ButtonChange : MonoBehaviour
{
    public GameObject CurrentLevel;
    public GameObject NewLevel;
    public GameObject CurrentOtherSideBC;
    public float timer = 5f;
    public float obratka = 5f;
    [Range(-10,10)]
    public float XMAX;
    [Range(-10, 10)]
    public float XMIN;
    [Range(-10, 10)]
    public float YMAX;
    [Range(-10, 10)]
    public float YMIN;
    [Range(-10, 10)]
    public float ZoMin;
    [Range(-10, 10)]
    public float ZoMax;
    public GameObject sun;
    public float lightx;
    Camera camerahash;
    public bool isDid;
     void Awake()
    {
        camerahash = Camera.main;
    }

    public void OnMouseDrag()
    { if (!isDid)
        {
            camerahash.GetComponent<CameraZoom>().touchUI = true;
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                camerahash.GetComponent<LevelChange>().CurrentLevel = CurrentLevel;
                camerahash.GetComponent<LevelChange>().NewLevel = NewLevel;
                camerahash.GetComponent<LevelChange>().CurrentOtherSide = CurrentOtherSideBC;
                camerahash.GetComponent<LevelChange>().SpawnLevel();
                Debug.Log("Сработал");
                timer = obratka;
                sun.GetComponent<Light>().intensity = lightx;
                camerahash.GetComponent<CameraZoom>().xMax = XMAX;
                camerahash.GetComponent<CameraZoom>().yMax = YMAX;
                camerahash.GetComponent<CameraZoom>().xMin = XMIN;
                camerahash.GetComponent<CameraZoom>().yMin = YMIN;
                camerahash.GetComponent<CameraZoom>().zoomMax = ZoMax;
                camerahash.GetComponent<CameraZoom>().zoomMin = ZoMin;
                camerahash.GetComponent<CameraZoom>().touchUI = false;
            }
        }
        
    }
        private void OnMouseUp()
        {
        camerahash.GetComponent<CameraZoom>().touchUI = false;
        timer = obratka;
        }
}


