using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animtest : MonoBehaviour
{
    [SerializeField]
    private Animator _ragdoll;

    public void OnAnimationEnded()
    {
        _ragdoll.enabled = false;
    }
}
