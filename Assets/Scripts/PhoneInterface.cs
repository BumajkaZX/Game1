using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneInterface : MonoBehaviour
{
    public GameObject PhoneInt;
    public GameObject MainInt;
    public GameObject level;
    public GameObject Phone;
    public GameObject ClocksIF;
    public bool i;
    public bool b;
    public bool j;

   public  void SettingsUI()
    {
        level = Camera.main.GetComponent<LevelChange>().NewLevel;
        
            if (b == false)
            {


                if (i == false)
                {
                    MainInt.SetActive(false);
                    level.SetActive(false);
                    PhoneInt.SetActive(true);
                    Phone.SetActive(true);
                    i = true;
                }
                else if (i == true)
                {
                    Phone.SetActive(false);
                    PhoneInt.SetActive(false);
                    level.SetActive(true);
                    MainInt.SetActive(true);
                    i = false;
                }
            }
            else if (b == true)
            {
                level.SetActive(false);
                MainInt.SetActive(false);
                Phone.SetActive(true);
                ClocksIF.SetActive(true);
                b = false;
                i = true;
            }
        
            //Если не будет телефона, удалить
    }
 
}
