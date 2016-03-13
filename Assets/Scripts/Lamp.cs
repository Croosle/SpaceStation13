using UnityEngine;
using System.Collections;

public class Lamp: MonoBehaviour
{

    public int passiveEnergy = 1;

    // Use this for initialization
    void Start()
    {
        Energy energy = (Energy)GameObject.FindWithTag("generator").GetComponent(typeof(Energy));
        energy.AddPassiveAppliance(passiveEnergy);
    }

    // Update is called once per frame
    void Update()
    {

    }
}