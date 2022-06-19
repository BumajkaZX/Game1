using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    Vector3 touch;
    public float zoomMin = 1;
    public float zoomMax = 8;
    public bool ClickerMode;
    public bool MiniGameMode;
    public bool touchUI;
    public Vector3 CamPosition;
    [Range(-10, 10)]
    public float xMin;
    [Range(-10, 10)]
    public float xMax;
    [Range(-10, 10)]
    public float yMin;
    [Range(-10, 10)]
    public float yMax;
    Vector3 touchAnim;
   public GameObject cirlce;
    public GameObject Canvas;
    public GameObject DisableClick;
    public GameObject Click;
    Camera camerah;
    //public Animation anim;

    private void Awake()
    {
        camerah = Camera.main;
    }
    void Start()
    {
        CamPosition = Camera.main.transform.position;
    }


    void Update()
    {

        if (ClickerMode == false && MiniGameMode == false&& touchUI == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                touch = camerah.ScreenToWorldPoint(Input.mousePosition);
            }
            if (Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);
                Vector2 touchZeroLastPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOneLastPos = touchOne.position - touchOne.deltaPosition;
                float distanceTouch = (touchZeroLastPos - touchOneLastPos).magnitude;
                float currentDistance = (touchZero.position - touchOne.position).magnitude;

                float dif = currentDistance - distanceTouch;
                zoom(dif * 0.0003f);
            }
            else if (Input.GetMouseButton(0))
            {
                Vector3 direction = touch - camerah.ScreenToWorldPoint(Input.mousePosition);
                if (camerah.transform.position.x + direction.x * 0.08f < xMax &&
                     camerah.transform.position.x + direction.x * 0.08f > xMin &&
                     camerah.transform.position.y + direction.y * 0.08f > yMin &&
                     camerah.transform.position.y + direction.y * 0.08f < yMax 
                   )
                {
                    direction.Set(direction.x, direction.y, 0);
                    camerah.transform.position += direction * 0.08f;
                }
                else touch = camerah.ScreenToWorldPoint(Input.mousePosition);

          
            }

        }

        if (ClickerMode == true && Input.anyKeyDown)
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                Quaternion rot = Quaternion.Euler(-20, 0, 0);
                Vector3 screenPoint = Input.GetTouch(i).position;
                screenPoint.z = 3.2f;
                touchAnim = camerah.ScreenToWorldPoint(screenPoint);
                Instantiate(cirlce, touchAnim, rot);
                Debug.Log(i);
            }
        }
    }
    
       
   
    void zoom(float increment)
    {
        camerah.orthographicSize = Mathf.Clamp(camerah.orthographicSize - increment, zoomMin, zoomMax);
    }
    public void DefaultCam()
    {
        camerah.transform.position = CamPosition;
    }
    public void Clicker()
    {
       ClickerMode = !ClickerMode;
        DisableClick.SetActive(ClickerMode);
        Click.SetActive(!ClickerMode);

    }
    public void MiniGame()
    {
        MiniGameMode = !MiniGameMode;
    }
    public void ZoomCorrect()
    {
        camerah.orthographicSize = 1.2f;
    }
}


