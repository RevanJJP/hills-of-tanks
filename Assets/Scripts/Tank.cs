using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;
public class Tank : MonoBehaviour
{
    [SerializeField] public Rigidbody2D avatar;
    [SerializeField] private float _enginePower = 1.0f;
    [SerializeField] public Transform gun;
    [SerializeField] public float gunRotationPower = 1.0f;
    [SerializeField] public float minRotateAngle = 0.0f;
    [SerializeField] public float maxRotateAngle = 180.0f;
    
    private float _horizontalVelocityRatio = .0f;
    private float _gunRotationRatio = .0f;

    private void Awake() {
        if(avatar==null) CLog.Error("Tank's avatar has not been assigned!");
        if(gun==null) CLog.Error("Tank's gun has not been assigned!");
    }
    private void Update() {
        rotateGunUpdate(_gunRotationRatio);
    }

    private void FixedUpdate() {
        avatar.velocity += (Vector2)this.transform.right * _horizontalVelocityRatio * _enginePower/1000.0f;
    }

    public void Move(float axisRatio) {
        _horizontalVelocityRatio = axisRatio;
    }

    public void RotateGun(float rotateRatio) {
        _gunRotationRatio = rotateRatio;
    }

    private void rotateGunUpdate(float rotateRatio) {
        if(rotateRatio == .0f) return;

        float rotationDelta = gunRotationPower * rotateRatio;
        float newAngle = gun.transform.localRotation.eulerAngles.z + rotationDelta;

        if(newAngle < minRotateAngle || newAngle > maxRotateAngle)
            if(rotationDelta < .0f)
                gun.transform.localEulerAngles = new Vector3(0,0, minRotateAngle);
            else
                gun.transform.localEulerAngles = new Vector3(0,0, maxRotateAngle);
        else
            gun.transform.localEulerAngles = new Vector3(0,0, newAngle);
    }
}
