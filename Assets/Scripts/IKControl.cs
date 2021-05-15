using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IKControl : MonoBehaviour
{
    [SerializeField]
    private float _watchArea = 5f;
    [SerializeField]
    protected Animator _animation;
    private Transform _rightArm = null;
    [SerializeField]
    private float _weight;
    [SerializeField]
    private GameObject _target;

    private void OnAnimatorIK(int layerIndex)
    {
        if (Vector3.Distance(transform.position, _target.transform.position) <= _watchArea)
        {
        _weight = (Vector3.Dot(transform.forward, transform.position - _target.transform.position) > 0) ? 0 : 0.5f;
        _animation.SetIKPositionWeight(AvatarIKGoal.RightHand, _weight);
        _animation.SetIKRotationWeight(AvatarIKGoal.RightHand, _weight);
        _animation.SetIKPosition(AvatarIKGoal.RightHand, _target.transform.position);
        _animation.SetIKRotation(AvatarIKGoal.RightHand, _target.transform.rotation);

        _animation.SetIKPositionWeight(AvatarIKGoal.LeftHand, _weight);
        _animation.SetIKRotationWeight(AvatarIKGoal.LeftHand, _weight);
        _animation.SetIKPosition(AvatarIKGoal.LeftHand, _target.transform.position);
        _animation.SetIKRotation(AvatarIKGoal.LeftHand, _target.transform.rotation);

          
        _animation.SetLookAtWeight(_weight);
        _animation.SetLookAtPosition(_target.transform.position);
        }
       
    }
}
