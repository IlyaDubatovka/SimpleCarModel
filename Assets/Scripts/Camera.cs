using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private CarController _car;

    [SerializeField] private Vector3 _offset;

    private void Start()
    {
        _car = FindObjectOfType<CarController>();
    }

    void Update()
    {
        transform.position=_car.transform.position+_offset;
    }
}