using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class Player : MonoBehaviour
{
    [SerializeField] public InputMaster controls;
    [SerializeField] public Tank tank;
    [SerializeField] public Gun gun;
    [SerializeField] public HealthBar healthBar;
    
    
    private int _defaultHealth;
    private int  _health;

    private void Awake() {
        controls = new InputMaster();
        controls.Player.Fire.performed += context => Fire(context.duration);
        controls.Player.TankMovement.performed += context => Move(context.ReadValue<float>());
        controls.Player.GunMovement.performed += context => MoveGun(context.ReadValue<float>());

        _defaultHealth = GameMaster.instance.primaryPlayerHealth;
        _health = _defaultHealth;
        healthBar.Health = (float) _health/_defaultHealth;
    }

    public int Health {
        get {
           return _health;
        }
        set {
            _health = value;
            healthBar.Health = (float) _health/_defaultHealth;
            if(_health <= .0f) GameMaster.instance.GameOver();
        }
    }

    public bool IsMyTurn {
        get {
            return GameObject.ReferenceEquals(GameMaster.instance.CurrentPlayer, this);
        }
    }

    private void OnEnable() {
        controls.Enable();
    }

    private void OnDisable() {
        controls.Disable();
    }


    private void Move(float axisRatio) {
        if(IsMyTurn != true) return;
        CLog.Info($"Moving with {axisRatio.ToString()} ratio");
        tank.Move(axisRatio);
    }

    private void MoveGun(float axisRatio) {
        if(IsMyTurn != true) return;
        CLog.Info($"Moving Gun with {axisRatio.ToString()} ratio");
        gun.RotateGun(axisRatio);
    }

    private void Fire(double fireTime) {
        if(IsMyTurn != true) return;
        
        if(fireTime == .0f) {
            CLog.Info($"Loading gun");
            gun.Load();
            return;
        }

        CLog.Info($"Fired after loading {fireTime.ToString()}s");
        gun.Fire((float) fireTime);
        GameMaster.instance.NextTurn();
    }

    public void Stop() {
        tank.Move(0);
        tank.avatar.velocity = new Vector2(.0f, .0f);
    }
}
