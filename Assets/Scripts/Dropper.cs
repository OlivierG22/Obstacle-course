using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody dropperrb;
    [SerializeField] float timer = 3f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        dropperrb = GetComponent<Rigidbody>();

        renderer.enabled = false;
        dropperrb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > timer)
        {
            renderer.enabled = true;
            dropperrb.useGravity = true;
        }
    }
}
