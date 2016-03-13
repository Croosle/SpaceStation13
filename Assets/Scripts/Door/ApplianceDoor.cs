using UnityEngine;
using System.Collections;

public class ApplianceDoor : Appliance
{
    public int passiveEnergy = 1;

    void Start()
    {
        Generator generator = (Generator)GameObject.FindWithTag("generator").GetComponent(typeof(Generator));
        generator.AddPassiveAppliance(gameObject.GetComponent<Appliance>(), passiveEnergy);
    }

    public override void TurnOff()
    {
        Debug.Log(1111);
    }

}
