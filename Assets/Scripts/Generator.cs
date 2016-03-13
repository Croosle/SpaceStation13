using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour
{

    public float totalEnergy = 50.0f;
    public int passiveEnergys = 0;
    public ArrayList appliances = new ArrayList();


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

    public void AddPassiveAppliance(Appliance appliance, int passiveEnergy) {
        appliances.Add(appliance);
        passiveEnergys += passiveEnergy;
    }
    public void SpendEnergy(int energy) {
        totalEnergy -= energy;
    }
    public bool HasEnergy() {
        if (totalEnergy > 0) {
            return true;
        }
        return false;
    }
}