using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanging : MonoBehaviour
{
    [SerializeField]
    private float _scaleCoefficient = 1.5f;
    [SerializeField] 
    private float _scaleTime = 2f;
    [SerializeField]
    private float _unScaleTime = 1f;
    private Vector3 _normalScale;
    private float _currentTime;
    
    
    private void Start()
    {
        _normalScale = transform.localScale;
    }
    
    
    private void Update()
    {
        _currentTime += Time.deltaTime;

        if (_currentTime > _scaleTime)
        {
            transform.localScale *= _scaleCoefficient;
            _currentTime = 0;
            return;
        }

        if (_currentTime > _unScaleTime)
        {
            transform.localScale = _normalScale;
        }
    }
}
