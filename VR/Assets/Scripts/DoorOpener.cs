using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public float distance;
    public GameObject Door;
    private bool trigger;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         distance = Vector3.Distance(gameObject.transform.position, Door.transform.position);
        if (distance < 2) 
        {
            trigger = true;
            DoorOpening(Door);
        }
        else
        {
            trigger = false;
        }
    }
    public void DoorOpening(GameObject door)
    {
        float timerEnd = 1;
        float time = Time.deltaTime;
        while (time < timerEnd) 
        {
            door.transform.Translate(new Vector3(0, 0, 0));
        }
    }
}
