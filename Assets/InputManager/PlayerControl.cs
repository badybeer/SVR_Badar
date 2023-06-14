// GENERATED AUTOMATICALLY FROM 'Assets/InputManager/PlayerControl.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControl : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""HeadsetPlayer"",
            ""id"": ""266f9223-e0b5-401b-a2d3-81c1bae0c898"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""Value"",
                    ""id"": ""f8f7e9bd-3f0c-4d91-bdc8-f526c4cc3137"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9669a835-963c-456c-ab3d-b71cd342e6e6"",
                    ""path"": ""<Joystick>/stick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""DesktopPlayer"",
            ""id"": ""f5944422-83a0-4e00-8707-60883b7a3d1e"",
            ""actions"": [
                {
                    ""name"": ""move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""da6214c5-d28a-4861-9ad1-8769933f9cfc"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""8b479852-4357-4783-a72f-281ccede3b39"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""19f4f662-edbf-48fc-b781-d07a967269bc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""738622d5-69f6-4b0a-8f85-92e0cc4c9d51"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""08403b89-f198-439a-b92e-132a5796511f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""53a30ba3-9f71-4b16-a8f9-aef324b2fb58"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // HeadsetPlayer
        m_HeadsetPlayer = asset.FindActionMap("HeadsetPlayer", throwIfNotFound: true);
        m_HeadsetPlayer_move = m_HeadsetPlayer.FindAction("move", throwIfNotFound: true);
        // DesktopPlayer
        m_DesktopPlayer = asset.FindActionMap("DesktopPlayer", throwIfNotFound: true);
        m_DesktopPlayer_move = m_DesktopPlayer.FindAction("move", throwIfNotFound: true);
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

    // HeadsetPlayer
    private readonly InputActionMap m_HeadsetPlayer;
    private IHeadsetPlayerActions m_HeadsetPlayerActionsCallbackInterface;
    private readonly InputAction m_HeadsetPlayer_move;
    public struct HeadsetPlayerActions
    {
        private @PlayerControl m_Wrapper;
        public HeadsetPlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_HeadsetPlayer_move;
        public InputActionMap Get() { return m_Wrapper.m_HeadsetPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeadsetPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IHeadsetPlayerActions instance)
        {
            if (m_Wrapper.m_HeadsetPlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_HeadsetPlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_HeadsetPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public HeadsetPlayerActions @HeadsetPlayer => new HeadsetPlayerActions(this);

    // DesktopPlayer
    private readonly InputActionMap m_DesktopPlayer;
    private IDesktopPlayerActions m_DesktopPlayerActionsCallbackInterface;
    private readonly InputAction m_DesktopPlayer_move;
    public struct DesktopPlayerActions
    {
        private @PlayerControl m_Wrapper;
        public DesktopPlayerActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @move => m_Wrapper.m_DesktopPlayer_move;
        public InputActionMap Get() { return m_Wrapper.m_DesktopPlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesktopPlayerActions set) { return set.Get(); }
        public void SetCallbacks(IDesktopPlayerActions instance)
        {
            if (m_Wrapper.m_DesktopPlayerActionsCallbackInterface != null)
            {
                @move.started -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMove;
                @move.performed -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMove;
                @move.canceled -= m_Wrapper.m_DesktopPlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_DesktopPlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @move.started += instance.OnMove;
                @move.performed += instance.OnMove;
                @move.canceled += instance.OnMove;
            }
        }
    }
    public DesktopPlayerActions @DesktopPlayer => new DesktopPlayerActions(this);
    public interface IHeadsetPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface IDesktopPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
