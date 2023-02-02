using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject box;
    private float time;
    private float nextTime;
    // Start is called before the first frame update
    void Start()
    {
        time = nextTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>nextTime){
            nextTime = Time.time + 2;
            Instantiate(box);
        }
    }
}
