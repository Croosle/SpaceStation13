using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour
{

    public float totalEnergy = 50.0f;
    public int passiveEnergys = 0;


    void Start()
    {

    }

    void Update()
    {
        if (totalEnergy > 0)
        {
            totalEnergy -= passiveEnergys * Time.deltaTime;
        }
        else
        {
            totalEnergy = 0;
        }
    }

    public void AddPassiveAppliance(int passiveEnergy) {
        passiveEnergys += passiveEnergy;
    }
    public void SpendEnergy(int energy) {
        totalEnergy -= energy;
    }
}
