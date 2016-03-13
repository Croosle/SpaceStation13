using UnityEngine;
using System.Collections;

public class Action : MonoBehaviour
{
    public bool active = true;
    Generator generator;

    void Start () {
        generator = (Generator)GameObject.FindWithTag("generator").GetComponent(typeof(Generator));
    }

    public void Use()
    {
        if (!active || !generator.HasEnergy())
        {
            return;
        }
        if (gameObject.GetComponent<Animator>().GetBool("IsOpen?") == false)
        {
            gameObject.GetComponent<Animator>().SetBool("IsOpen?", true);
        }
        else
        {
            gameObject.GetComponent<Animator>().SetBool("IsOpen?", false);
        }
        generator.SpendEnergy(5);
    }

    public void ActiveDoor()
    {
        active = true;
        gameObject.transform.GetChild(0).GetChild(0).GetComponent<Light>().color = Color.green;
    }

    public void DisableDoor()
    {
        active = false;
        gameObject.transform.GetChild(0).GetChild(0).GetComponent<Light>().color = Color.red;
    }
}