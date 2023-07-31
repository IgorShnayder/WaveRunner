using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementRotatingObstacle : MonoBehaviour
{
    [SerializeField]
    private float _rotatingSpeed = 70;

    private Vector3 _rotatingVector;
    
    void Start()
    {
      _rotatingVector = new Vector3(0, 0, _rotatingSpeed);
    }

    
    void Update()
    {
        transform.Rotate(_rotatingVector * Time.deltaTime, Space.Self);
    }
}
