using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthController : MonoBehaviour
{
    public int health = 3;
    public Collider headCollider;
    // Start is called before the first frame update
    void Start()
    {
        headCollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other) {
        health--;
        Destroy(other.gameObject);
        if(health >= 0){
            Debug.Log("You are dead");
        }
    }
}
