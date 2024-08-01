using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingWeapons : MonoBehaviour
{
    [SerializeField] private GameObject [] weaponArray = new GameObject [4];

    private int weapon, lengthArray;

    private void Awake()
    {
        weapon = 0;
        lengthArray = weaponArray.Length;
    }
        
    void Update()
    {
        float wheelInput = Input.GetAxis("Mouse ScrollWheel");
        
        if (wheelInput > 0)
        {
            if (weapon >= 0 && weapon < lengthArray - 1)
            {
                weapon++;
            }
            else
            {
                weapon = 0;
            }

            ResetWeapons();
            
            weaponArray[weapon].SetActive(true);
        }
        else if (wheelInput < 0)
        {
            if (weapon > 0 && weapon <= lengthArray - 1)
            {
                weapon--;                
            }
            else
            {                
                weapon = lengthArray - 1;
            }
            
            ResetWeapons();

            weaponArray[weapon].SetActive(true);
        }
    }

    private void ResetWeapons()
    {
        for (int i = 0; i < weaponArray.Length; i++)
        {
            weaponArray[i].SetActive(false);
        }
    }
}
