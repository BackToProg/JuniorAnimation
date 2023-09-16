using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   [SerializeField] private float _speed;
   [SerializeField] private int _angle;

   private void Update()
   {
      transform.Rotate(Vector3.down, _angle * Time.deltaTime * _speed);
   }
}
