//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/InputMaster.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @InputMaster : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMaster"",
    ""maps"": [
        {
            ""name"": ""Konami"",
            ""id"": ""204da6e2-4402-4dda-8125-219ec50322c9"",
            ""actions"": [
                {
                    ""name"": ""Directions"",
                    ""type"": ""Value"",
                    ""id"": ""057af927-ef2c-488d-a99b-1719ff4cff1e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""930156ac-40d1-48c8-9784-241a957d911c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""B"",
                    ""type"": ""Button"",
                    ""id"": ""831a6164-3c2a-4aa4-bdf9-bdf54169270a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""35904640-7101-43c3-85e2-c95e7050be0e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""22092e80-844b-49fa-b835-e7a07464ae39"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""da4ae559-a2b5-4c00-8a87-e199b216e134"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a57fdd5-6639-4f44-bfcb-63f1f9e52c30"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""903edb2e-33da-4974-83c4-38c5d76cc6a6"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""XboxGamePad"",
                    ""id"": ""32b56554-f21d-4252-a03c-42eb76d2b726"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""f3bcfb80-9952-40a6-bbdf-1db99a574a7f"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d1da8ed2-7548-4aba-9563-0cd4adf9b72f"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6e4b2c2b-1612-4d57-ab7c-cf0647020afc"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1407b0b8-c0a1-4961-a012-dce371c169eb"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Directions"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bc46e9a4-df54-4ef6-b2eb-9c5fd8bf1659"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d89b71a2-4fdf-4a8f-8060-843d5eef4ee1"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""173a16ea-9787-415b-a8f0-a0fd11e5e73d"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51669f36-90c9-4510-9d37-e99aba4c0ae2"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""B"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Konami
        m_Konami = asset.FindActionMap("Konami", throwIfNotFound: true);
        m_Konami_Directions = m_Konami.FindAction("Directions", throwIfNotFound: true);
        m_Konami_A = m_Konami.FindAction("A", throwIfNotFound: true);
        m_Konami_B = m_Konami.FindAction("B", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Konami
    private readonly InputActionMap m_Konami;
    private IKonamiActions m_KonamiActionsCallbackInterface;
    private readonly InputAction m_Konami_Directions;
    private readonly InputAction m_Konami_A;
    private readonly InputAction m_Konami_B;
    public struct KonamiActions
    {
        private @InputMaster m_Wrapper;
        public KonamiActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Directions => m_Wrapper.m_Konami_Directions;
        public InputAction @A => m_Wrapper.m_Konami_A;
        public InputAction @B => m_Wrapper.m_Konami_B;
        public InputActionMap Get() { return m_Wrapper.m_Konami; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KonamiActions set) { return set.Get(); }
        public void SetCallbacks(IKonamiActions instance)
        {
            if (m_Wrapper.m_KonamiActionsCallbackInterface != null)
            {
                @Directions.started -= m_Wrapper.m_KonamiActionsCallbackInterface.OnDirections;
                @Directions.performed -= m_Wrapper.m_KonamiActionsCallbackInterface.OnDirections;
                @Directions.canceled -= m_Wrapper.m_KonamiActionsCallbackInterface.OnDirections;
                @A.started -= m_Wrapper.m_KonamiActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_KonamiActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_KonamiActionsCallbackInterface.OnA;
                @B.started -= m_Wrapper.m_KonamiActionsCallbackInterface.OnB;
                @B.performed -= m_Wrapper.m_KonamiActionsCallbackInterface.OnB;
                @B.canceled -= m_Wrapper.m_KonamiActionsCallbackInterface.OnB;
            }
            m_Wrapper.m_KonamiActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Directions.started += instance.OnDirections;
                @Directions.performed += instance.OnDirections;
                @Directions.canceled += instance.OnDirections;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @B.started += instance.OnB;
                @B.performed += instance.OnB;
                @B.canceled += instance.OnB;
            }
        }
    }
    public KonamiActions @Konami => new KonamiActions(this);
    public interface IKonamiActions
    {
        void OnDirections(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnB(InputAction.CallbackContext context);
    }
}