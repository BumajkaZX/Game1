using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawn : MonoBehaviour
{
    public GameObject road;
    public Vector3 start;
    public Vector3 endPoint;
    public float mult;
    // Start is called before the first frame update
    void Awake()
    {
        start = road.transform.localPosition;
        endPoint = new Vector3(start.x + 25.72468f, start.y, start.z);

    }

    // Update is called once per frame
    void Update()
    {

        if (road.transform.localPosition.x + Time.deltaTime * mult >= endPoint.x)
        {
            road.transform.localPosition = start;
        }
        else
        {
            road.transform.localPosition = new Vector3(road.transform.localPosition.x + Time.deltaTime * mult, road.transform.localPosition.y, road.transform.localPosition.z);
        }

    }
}






