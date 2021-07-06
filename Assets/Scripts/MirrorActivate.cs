using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MirrorActivate : MonoBehaviour
{
    // Start is called before the first frame update
    public EnergyBar energyBar;
    public float maxEnergy;
    public float currentEnergy;
    public float energyCost;
    public bool mirrorActivated;
    int i = 0;

    void Start()
    {
        currentEnergy = maxEnergy;
        energyBar.SetMaxEnergy(maxEnergy);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Q) == true && currentEnergy>energyCost)
         {
            
                ActivateMirror();
                i++;
                Debug.Log(i);
                
        }
    }
    public void ActivateMirror()
    {
        currentEnergy-=energyCost;
       // mirrorActivated = true;
        energyBar.SetEnergy(currentEnergy);
    }
}
