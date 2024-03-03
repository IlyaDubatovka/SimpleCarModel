using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class CarSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _car;
    // Start is called before the first frame update
    void Awake()
    {
        Instantiate(_car,new Vector3(2.5f,0,0),Quaternion.Euler(0,0,0));
    }
}
