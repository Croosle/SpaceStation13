using UnityEngine;
using System.Collections;

public abstract class Appliance : MonoBehaviour {

    public int passiveEnergy = 0;

    // Use this for initialization
    public virtual void Start () {
        Generator energy = (Generator)GameObject.FindWithTag("generator").GetComponent(typeof(Generator));
        energy.AddPassiveAppliance(gameObject.GetComponent<Appliance>(), passiveEnergy);
    }
}
