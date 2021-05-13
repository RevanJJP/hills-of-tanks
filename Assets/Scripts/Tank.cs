using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] public Rigidbody2D avatar;
    [SerializeField] private float enginePower = 1.0f;
    private float _horizontalVelocityRatio = .0f;
    void Start()
    {
        
    }

    public void Move(float axisRatio) {
        //avatar.AddForce(transform.right * axisRatio * enginePower, mode: ForceMode2D.Force);
        _horizontalVelocityRatio = axisRatio;
    }

    private void FixedUpdate() {
        avatar.velocity += (Vector2)this.transform.right * _horizontalVelocityRatio * enginePower/1000.0f;
    }
}
