using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationBot : MonoBehaviour
{
    [SerializeField] [Range(0, 3)]
    private float _speed = 0;
    [SerializeField] [Range(0, 2)]
    private float _direction = 1;
    [SerializeField]
    private Animator _animator;

    protected void Update()
    {
        
        _animator.SetFloat("Speed", _speed);
        _animator.SetFloat("Direction", _direction);
        if (Input.GetKey(KeyCode.A))
        {
            _direction = -1;
        }

        if (Input.GetKey(KeyCode.W))
           {
               _speed = 2;
            if (Input.GetKey(KeyCode.LeftShift))
            {
                _speed = 3;
            }
           }
           else if (!Input.GetKey(KeyCode.W))
           {
               _speed = 0;
           }

        if (Input.GetKey(KeyCode.A))
           {
                _direction = 0;
           }
           else if (Input.GetKey(KeyCode.D))
           {
            _direction = 2;
           }
           else if (!Input.GetKey(KeyCode.A) || !Input.GetKey(KeyCode.D))
           {
               _direction = 1;
           }


      
       

    }

}
