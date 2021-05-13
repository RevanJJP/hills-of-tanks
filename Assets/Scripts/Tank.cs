using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] public Rigidbody2D avatar;
    [SerializeField] private float enginePower = 1.0f;
    void Start()
    {
        
    }

    public void Move(float axisRatio) {
        //avatar.AddForce(transform.right * axisRatio * enginePower, mode: ForceMode2D.Force);
        avatar.AddRelativeForce(transform.right * axisRatio * enginePower, mode: ForceMode2D.Force);
    }
}
