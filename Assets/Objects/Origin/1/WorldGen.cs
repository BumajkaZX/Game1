
using System.Collections.Generic;
using UnityEngine;

public class WorldGen : MonoBehaviour
{
    public float perlinNoise = 0f;
    public float refinement = 0f;
    public float multiplier = 0f;
    public int cubes = 0;
    public float tsx;
    public float tsy;
    public float transLocal;
    public GameObject cube;
    public GameObject parent;
    public GameObject terrain;
    public List<GameObject> world = new List<GameObject>();
    // Start is called before the first frame update
    public void Generate()
    {
        terrain.transform.rotation = new Quaternion(0, 0, 0, 0);
        terrain.transform.position = new Vector3(28f, -10f, -20f);
        for (int v = 0; v < world.Count; v++)
        {
            Destroy(world[v].gameObject);
        }
        world.Clear();
        float offsetx = Random.Range(0f, 99999f);
        float offsety = Random.Range(0f, 99999f);
        for (int i = 0; i < cubes; i++)
        {
            tsx += transLocal;
            tsy = 0;
            for (int j = 0; j < cubes; j++)
            {
                perlinNoise = Mathf.PerlinNoise(i * refinement + offsetx, j * refinement + offsety);
                GameObject cubesp = Instantiate(cube);
                world.Add(cubesp);
                cubesp.transform.parent = parent.transform;
                cubesp.transform.localPosition = new Vector3(tsx, perlinNoise * multiplier, tsy);
                if (j == 5 || j == 6 || j == 7)
                {
                    cubesp.transform.localPosition = new Vector3(tsx, 2f, tsy);
                    world.Add(cubesp);
                    GameObject cubel = Instantiate(cube);
                    world.Add(cubel);
                    cubel.transform.parent = parent.transform;
                    cubel.transform.localPosition = new Vector3(tsx + 0.5f, 2f, tsy);
                }
                if ( j == 5)
                {
                    GameObject cuber = Instantiate(cube);
                    world.Add(cuber);
                    cuber.transform.parent = parent.transform;
                    cuber.transform.localPosition = new Vector3 (tsx , 2f, tsy - 0.51f);
                    GameObject cubel = Instantiate(cube);
                    world.Add(cubel);
                    cubel.transform.parent = parent.transform;
                    cubel.transform.localPosition = new Vector3(tsx + 0.5f, 2f, tsy - 0.51f);
                }
                if ( j == 7)
                {
                    GameObject cuber = Instantiate(cube);
                    world.Add(cuber);
                    cuber.transform.parent = parent.transform;
                    cuber.transform.localPosition = new Vector3(tsx, 2f, tsy + 0.51f);
                    GameObject cubel = Instantiate(cube);
                    world.Add(cubel);
                    cubel.transform.parent = parent.transform;
                    cubel.transform.localPosition = new Vector3(tsx + 0.5f, 2f, tsy + 0.51f);

                }
                tsy += transLocal;
               
            }
            
        }
        tsy = 0f;
        tsx = 0f;
        
        //-0,43514
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
