using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    
    private Vector3 _source;
    private readonly float _minDistance = 0.01f;
    private bool _isMoveForward = true;

    private void Start()
    {
        _source = transform.position;
    }

    private void Update()
    {
        if (_isMoveForward)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, _target.position) < _minDistance)
            {
                _isMoveForward = false;
            }
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _source, _speed * Time.deltaTime);
            
            if (Vector3.Distance(transform.position, _source) < _minDistance)
            {
                _isMoveForward = true;
            }
        }
    }
}
