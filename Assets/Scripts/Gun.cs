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

    [SerializeField] public Missle misslePrefab;
    [SerializeField] public Transform missleSpawner;

    [SerializeField] public Transform cloudPrefab;
    [SerializeField] public Transform cloudSpawner;


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
}
