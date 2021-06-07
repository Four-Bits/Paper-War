using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehaviour : MonoBehaviour
{
    private float xRange = 11;
    private float zRange = 8;
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x > xRange || transform.position.x < -xRange || transform.position.z > zRange || transform.position.z < -zRange)
        {
            //Debug.Log("peloamor");
            Destroy(gameObject);
        }
    }

    /* private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.CompareTag("Enemy"))
        {
            Debug.Log("eita");
        }
    }*/

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("eita");
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
