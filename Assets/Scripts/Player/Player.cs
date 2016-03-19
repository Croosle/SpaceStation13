using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour
{
    public new Camera camera;
    RaycastHit hit;

    // Use this for initialization
    void Start()
    {
        if (!isLocalPlayer)
        {
            camera.enabled = false;
            camera.GetComponent<AudioListener>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.tag == "usable" && Input.GetKeyDown(KeyCode.F))
            {
                GameObject usableObject = hit.collider.gameObject;
                Action action = (Action)usableObject.GetComponent(typeof(Action));
                action.Use();
            }
        }
    }
}
