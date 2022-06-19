using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueFistMeet : MonoBehaviour
{
    [SerializeField]
    public List<string> FstMeet = new List<string>();
    public GameObject dialBlock;
    public GameObject meet;
    public GameObject Level1;
    public AudioClip stmeet;
    public AudioSource CamSpot;
    public void Awake()
    {
        CamSpot.loop = true;
        CamSpot.clip = stmeet;
        CamSpot.Play();

        dialBlock.GetComponent<Dialogue>().text = FstMeet;
    }


    // Update is called once per frame
    void Update()
    {
        if (dialBlock.GetComponent<Dialogue>().isover)
        {
            CamSpot.Stop();
            meet.SetActive(false);
            Level1.SetActive(true);
        }
        

    }
}
