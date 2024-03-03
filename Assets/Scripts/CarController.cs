using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private int _speed;
    [SerializeField] private int _maneuverability;


        void Update()
    {
        var position = gameObject.transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            position.z += _speed * Time.deltaTime;
        }

        else if (Input.GetKey(KeyCode.S))
        {
            position.z -= _speed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            position.x -= _maneuverability * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            position.x += _maneuverability * Time.deltaTime;
        }

        transform.position = position;
    }
}