using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;
public class Gun : MonoBehaviour
{
    [SerializeField] public Transform avatar;
    [SerializeField] public float gunRotationPower = 1.0f;
    [SerializeField] public float minRotateAngle = 0.0f;
    [SerializeField] public float maxRotateAngle = 180.0f;

    [SerializeField] public Missile missilePrefab;
    [SerializeField] public Transform missileSpawner;
    [SerializeField] public float gunFirePower = 100.0f;
    [SerializeField] public float gunMaxForcePressDuration = 1.0f;

    [SerializeField] public Animator gunAnimator;

    private float _gunRotationRatio = .0f;

    private void Awake() {
        if(avatar==null) CLog.Error("Tank's gun has not been assigned!");
    }
    private void Update() {
        rotateGunUpdate(_gunRotationRatio);
    }

    public void RotateGun(float rotateRatio) {
        _gunRotationRatio = rotateRatio;
    }

    private void rotateGunUpdate(float rotateRatio) {
        if(rotateRatio == .0f) return;

        float rotationDelta = gunRotationPower * rotateRatio;
        float newAngle = avatar.transform.localRotation.eulerAngles.z + rotationDelta;

        if(newAngle < minRotateAngle || newAngle > maxRotateAngle)
            if(rotationDelta < .0f)
                avatar.transform.localEulerAngles = new Vector3(0,0, minRotateAngle);
            else
                avatar.transform.localEulerAngles = new Vector3(0,0, maxRotateAngle);
        else
            avatar.transform.localEulerAngles = new Vector3(0,0, newAngle);
    }
    
    public void Load() {
        gunAnimator.SetTrigger("Loading");
    }
    public void Fire(float pressDuration) {
        if(pressDuration > gunMaxForcePressDuration) pressDuration = 1.0f;
        else pressDuration /= gunMaxForcePressDuration;

        gunAnimator.SetTrigger("Release");
        Missile missile = Instantiate(missilePrefab, missileSpawner.position, missileSpawner.rotation);
        missile.missileRigidbody.AddRelativeForce(Vector2.right * pressDuration * gunFirePower);
    }
}
