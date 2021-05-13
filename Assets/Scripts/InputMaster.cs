// GENERATED AUTOMATICALLY FROM 'Assets/InputMaster.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""1faa5fa9-e10a-4bd4-9e78-f51df24a24ca"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""e9a27fcf-dcda-4e4e-8225-94f569a54080"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TankMovement"",
                    ""type"": ""Button"",
                    ""id"": ""7a280c5e-4908-423d-9069-b79738fa328a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GunMovement"",
                    ""type"": ""Button"",
                    ""id"": ""91cd1a10-2ed0-4c3c-9415-88a9c58070a8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""32100781-d73c-4c6f-9fc7-d548318d9afd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8fb40c74-2245-41ee-8b85-e8df0b4927bd"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Horizontal"",
                    ""id"": ""c6df6d7f-4cba-40ef-af6e-7515f513d1b6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TankMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""542a158d-7f04-472d-b145-6d4ce7f9b6a1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""TankMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""3cdf0409-7d94-4564-b822-dcdc5b92ed6f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""TankMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Vertical"",
                    ""id"": ""0fb6d95b-a743-41fc-b5d2-43c56ca33198"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GunMovement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""5106a401-2f44-4e97-9b59-73a30bc922f9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GunMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""62fb5eba-70d1-4270-8663-3afa13da3fd9"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""GunMovement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7187fa7f-3b38-462b-8a12-e1762ef24810"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_TankMovement = m_Player.FindAction("TankMovement", throwIfNotFound: true);
        m_Player_GunMovement = m_Player.FindAction("GunMovement", throwIfNotFound: true);
        m_Player_Menu = m_Player.FindAction("Menu", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_TankMovement;
    private readonly InputAction m_Player_GunMovement;
    private readonly InputAction m_Player_Menu;
    public struct PlayerActions
    {
        private @InputMaster m_Wrapper;
        public PlayerActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @TankMovement => m_Wrapper.m_Player_TankMovement;
        public InputAction @GunMovement => m_Wrapper.m_Player_GunMovement;
        public InputAction @Menu => m_Wrapper.m_Player_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @TankMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTankMovement;
                @TankMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTankMovement;
                @TankMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnTankMovement;
                @GunMovement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunMovement;
                @GunMovement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunMovement;
                @GunMovement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnGunMovement;
                @Menu.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @TankMovement.started += instance.OnTankMovement;
                @TankMovement.performed += instance.OnTankMovement;
                @TankMovement.canceled += instance.OnTankMovement;
                @GunMovement.started += instance.OnGunMovement;
                @GunMovement.performed += instance.OnGunMovement;
                @GunMovement.canceled += instance.OnGunMovement;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnTankMovement(InputAction.CallbackContext context);
        void OnGunMovement(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
