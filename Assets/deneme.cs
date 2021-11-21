using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class deneme : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 1f;
    private GameObject whiteBall;

    void Start()
    {
        Debug.Log("berkay altay kod ustası");
        whiteBall = GameObject.FindWithTag("whiteBall");
        whiteBall.transform.localPosition = new Vector3(240f, 67.82f, 61.86f);
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // whiteBall.transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, verticalInput * movementSpeed * Time.deltaTime, 0);
        // Debug.Log(transform.position);
    }
}
