using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    private float _currentTime;
    private float _stopTime;
    
    
    
    void Update()
    {
        if (_stopTime > 0)
        {
            _stopTime -= Time.deltaTime;
            transform.Translate(Vector3.down * 0);
            return;
        }
        
        _currentTime += Time.deltaTime;
        
        var moveSpeed = _moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.down * moveSpeed);

        if (_currentTime > 1.5f)
        {
            _stopTime = 0.5f;
            _currentTime = 0;
        }
    }
}
