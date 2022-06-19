using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScripts : MonoBehaviour
{
    public GameObject IFClocks;
    public GameObject IFPhone;
    public GameObject Phone;
    public void Level1Clock()
    {
        IFClocks.SetActive(false);
        IFPhone.SetActive(true);
    }
   public void FirstTimePhone()
    {
       Phone.GetComponent<PhoneInterface>().b = true;
    }
}
