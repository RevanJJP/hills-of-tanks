using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;
public class Tank : MonoBehaviour
{
    [SerializeField] public Rigidbody2D avatar;
    [SerializeField] private float _enginePower = 1.0f;
    private float _horizontalVelocityRatio = .0f;
    
    private void Awake() {
        if(avatar==null) CLog.Error("Tank's avatar has not been assigned!");
    }

    private void FixedUpdate() {
        avatar.velocity += (Vector2) this.transform.right * _horizontalVelocityRatio * _enginePower/1000.0f;
    }


    public void Move(float axisRatio) {
        _horizontalVelocityRatio = axisRatio;
    }
}
