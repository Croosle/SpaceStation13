using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public Camera camera1;
    RaycastHit hit;


    // Update is called once per frame
    void Update()
    {
        Ray ray = camera1.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "usable" && Input.GetKeyUp(KeyCode.F))
            {
                GameObject usableObject = hit.collider.gameObject;
                Action action = (Action)usableObject.GetComponent(typeof(Action));
                action.Use();
            }
        }
    }
}
