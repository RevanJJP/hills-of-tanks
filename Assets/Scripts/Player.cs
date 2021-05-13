using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class Player : MonoBehaviour
{
    [SerializeField] public InputMaster controls;
    [SerializeField] public Tank tank;

    private void Awake() {
        controls = new InputMaster();
        controls.Player.Fire.performed += context => Fire(context.duration);
        controls.Player.TankMovement.performed += context => Move(context.ReadValue<float>());
        controls.Player.GunMovement.performed += context => MoveGun(context.ReadValue<float>());
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }

    private void Fire(double fireTime) {
        CLog.Info($"Fired for {fireTime.ToString()}s");
    }

    private void Move(float axisRatio) {
        CLog.Info($"Moving with {axisRatio.ToString()} ratio");
        tank.Move(axisRatio);
    }

    private void MoveGun(float axisRatio) {
        CLog.Info($"Moving Gun with {axisRatio.ToString()} ratio");
        tank.RotateGun(axisRatio);
    }
}
