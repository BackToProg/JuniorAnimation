using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growing : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _targetScale;
    
    private Vector3 _sourceScale;
    private bool _isGrowing = true;
    private float _scaleSpeed;

    private void Start()
    {
        _scaleSpeed = _speed * Time.deltaTime;
        _sourceScale = transform.localScale;
    }

    private void Update()
    {
        Vector3 scaleChange = new Vector3(_scaleSpeed, _scaleSpeed, _scaleSpeed);

        if (_isGrowing)
        {
            transform.localScale += scaleChange;

            if (transform.localScale.x > _targetScale.x)
            {
                _isGrowing = false;
            }
        }
        else
        {
            transform.localScale -= scaleChange;

            if (transform.localScale.x < _sourceScale.x)
            {
                _isGrowing = true;
            }
        }
    }
}