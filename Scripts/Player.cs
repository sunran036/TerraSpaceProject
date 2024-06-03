using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Player : MonoBehaviour
{   
    float hx;
    float vy;
    public float moveSpeed = 5.0f;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hx = Input.GetAxisRaw("Horizontal");
        vy = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(hx, vy, 0);
        transform.position += moveDirection * moveSpeed * Time.deltaTime;

        
    }
}
