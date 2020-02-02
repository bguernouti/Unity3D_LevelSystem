using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 2;

    void Update() {
        
        if (Input.GetKey(KeyCode.UpArrow)){

            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)){

            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other) {
        
    }
}
