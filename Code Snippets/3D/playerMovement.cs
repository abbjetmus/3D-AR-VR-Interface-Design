using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
[SerializeField] float speed;    
Rigidbody rb;
void Start() {
    rb = GetComponent<Rigidbody>();
}

void Update() {
    float x = Input.GetAxisRaw("Horizontal");
    float z = Input.GetAxisRaw("Vertical");
    Vector3 moveBy = transform.right * x + transform.forward * z;
    rb.MovePosition(transform.position + moveBy.normalized * speed * Time.deltaTime);
    }
}
