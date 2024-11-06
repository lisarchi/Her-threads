//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Scripts/PlayerController/InputController.inputactions
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

public partial class @InputController: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputController()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputController"",
    ""maps"": [
        {
            ""name"": ""Move"",
            ""id"": ""40608be8-63fd-45d4-a088-eef1e9aba586"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f664f8cc-59d3-46e6-a484-9177f29a5d4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Value"",
                    ""id"": ""54835b65-c680-4707-ad2d-99e2e9edfc79"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Using"",
                    ""type"": ""Button"",
                    ""id"": ""15d0f306-e039-4dab-900b-7897d3a28e25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interation"",
                    ""type"": ""Button"",
                    ""id"": ""1f79840b-e179-4a85-b8d9-ea08ce165373"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""58512b71-2f9c-47c2-bd76-b823c2e46f21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)"",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Hint"",
                    ""type"": ""Button"",
                    ""id"": ""7e696110-a380-4c10-9456-f9be179da23b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""94c5b747-943d-4de0-80f8-3742fa7d114a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MainMenu"",
                    ""type"": ""Button"",
                    ""id"": ""48b032d8-da0f-4657-940e-077c174c5702"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""c83a758c-e8e0-4c52-a115-b337e803d79d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9306b80d-10ff-448d-abdd-73f850ee0d96"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6a61129-da3b-414f-94e2-d5d2958ae843"",
                    ""path"": ""<Keyboard>/numpad8"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""e31684a2-94c9-4993-b624-1210f4a25295"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c013a531-5a0a-4087-b15b-79858b618a5f"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1701f297-cf32-43a4-baac-2021ab293389"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1436e618-4cb2-442e-9f5c-40c5a474537f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6a747e1e-872e-4009-b42c-d6fb086e0769"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b18783d7-35fc-405c-8685-6772e95fd3f7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""956b648c-0771-4a27-89cb-3dc1d5e1baf1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fed8c41f-68aa-47aa-8f41-bf5f5035e693"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""4998c3bd-1035-49ba-b508-e79994d01943"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""16d97f57-1eb4-4c32-b105-70b51b67f54e"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Using"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""908eff67-7923-43fc-8ccc-d686cda49bff"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Using"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""acf6ab6e-fbca-4390-8376-002e26386850"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Interation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ee72f74e-d2e8-476f-8e3d-1c4723c87ca8"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b18fa8b1-9d9e-4709-87e6-49128271a0c7"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eeedc7f6-cc40-4ac6-9369-a60f3a46c892"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4d9b6ee9-d258-4eea-bd92-f2b5df1eba80"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d732e3c-0ef7-47b7-9e43-e1e1ac771843"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Hint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""511fbe90-98cf-447d-a4e5-b52792af06c8"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11f9033a-2413-45dc-958f-b3960ec375e3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyBoard"",
                    ""action"": ""MainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9cdf59d4-a511-4388-8e50-1ba0bbc85178"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MainMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KeyBoard"",
            ""bindingGroup"": ""KeyBoard"",
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
        // Move
        m_Move = asset.FindActionMap("Move", throwIfNotFound: true);
        m_Move_Jump = m_Move.FindAction("Jump", throwIfNotFound: true);
        m_Move_Horizontal = m_Move.FindAction("Horizontal", throwIfNotFound: true);
        m_Move_Using = m_Move.FindAction("Using", throwIfNotFound: true);
        m_Move_Interation = m_Move.FindAction("Interation", throwIfNotFound: true);
        m_Move_Sprint = m_Move.FindAction("Sprint", throwIfNotFound: true);
        m_Move_Hint = m_Move.FindAction("Hint", throwIfNotFound: true);
        m_Move_Newaction = m_Move.FindAction("New action", throwIfNotFound: true);
        m_Move_MainMenu = m_Move.FindAction("MainMenu", throwIfNotFound: true);
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

    // Move
    private readonly InputActionMap m_Move;
    private List<IMoveActions> m_MoveActionsCallbackInterfaces = new List<IMoveActions>();
    private readonly InputAction m_Move_Jump;
    private readonly InputAction m_Move_Horizontal;
    private readonly InputAction m_Move_Using;
    private readonly InputAction m_Move_Interation;
    private readonly InputAction m_Move_Sprint;
    private readonly InputAction m_Move_Hint;
    private readonly InputAction m_Move_Newaction;
    private readonly InputAction m_Move_MainMenu;
    public struct MoveActions
    {
        private @InputController m_Wrapper;
        public MoveActions(@InputController wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Move_Jump;
        public InputAction @Horizontal => m_Wrapper.m_Move_Horizontal;
        public InputAction @Using => m_Wrapper.m_Move_Using;
        public InputAction @Interation => m_Wrapper.m_Move_Interation;
        public InputAction @Sprint => m_Wrapper.m_Move_Sprint;
        public InputAction @Hint => m_Wrapper.m_Move_Hint;
        public InputAction @Newaction => m_Wrapper.m_Move_Newaction;
        public InputAction @MainMenu => m_Wrapper.m_Move_MainMenu;
        public InputActionMap Get() { return m_Wrapper.m_Move; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MoveActions set) { return set.Get(); }
        public void AddCallbacks(IMoveActions instance)
        {
            if (instance == null || m_Wrapper.m_MoveActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_MoveActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Horizontal.started += instance.OnHorizontal;
            @Horizontal.performed += instance.OnHorizontal;
            @Horizontal.canceled += instance.OnHorizontal;
            @Using.started += instance.OnUsing;
            @Using.performed += instance.OnUsing;
            @Using.canceled += instance.OnUsing;
            @Interation.started += instance.OnInteration;
            @Interation.performed += instance.OnInteration;
            @Interation.canceled += instance.OnInteration;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @Hint.started += instance.OnHint;
            @Hint.performed += instance.OnHint;
            @Hint.canceled += instance.OnHint;
            @Newaction.started += instance.OnNewaction;
            @Newaction.performed += instance.OnNewaction;
            @Newaction.canceled += instance.OnNewaction;
            @MainMenu.started += instance.OnMainMenu;
            @MainMenu.performed += instance.OnMainMenu;
            @MainMenu.canceled += instance.OnMainMenu;
        }

        private void UnregisterCallbacks(IMoveActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Horizontal.started -= instance.OnHorizontal;
            @Horizontal.performed -= instance.OnHorizontal;
            @Horizontal.canceled -= instance.OnHorizontal;
            @Using.started -= instance.OnUsing;
            @Using.performed -= instance.OnUsing;
            @Using.canceled -= instance.OnUsing;
            @Interation.started -= instance.OnInteration;
            @Interation.performed -= instance.OnInteration;
            @Interation.canceled -= instance.OnInteration;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @Hint.started -= instance.OnHint;
            @Hint.performed -= instance.OnHint;
            @Hint.canceled -= instance.OnHint;
            @Newaction.started -= instance.OnNewaction;
            @Newaction.performed -= instance.OnNewaction;
            @Newaction.canceled -= instance.OnNewaction;
            @MainMenu.started -= instance.OnMainMenu;
            @MainMenu.performed -= instance.OnMainMenu;
            @MainMenu.canceled -= instance.OnMainMenu;
        }

        public void RemoveCallbacks(IMoveActions instance)
        {
            if (m_Wrapper.m_MoveActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IMoveActions instance)
        {
            foreach (var item in m_Wrapper.m_MoveActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_MoveActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public MoveActions @Move => new MoveActions(this);
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    private int m_KeyBoardSchemeIndex = -1;
    public InputControlScheme KeyBoardScheme
    {
        get
        {
            if (m_KeyBoardSchemeIndex == -1) m_KeyBoardSchemeIndex = asset.FindControlSchemeIndex("KeyBoard");
            return asset.controlSchemes[m_KeyBoardSchemeIndex];
        }
    }
    public interface IMoveActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnUsing(InputAction.CallbackContext context);
        void OnInteration(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnHint(InputAction.CallbackContext context);
        void OnNewaction(InputAction.CallbackContext context);
        void OnMainMenu(InputAction.CallbackContext context);
    }
}
