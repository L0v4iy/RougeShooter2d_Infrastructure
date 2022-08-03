// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""f3c3c334-0e27-45c2-b9fd-8d0838ca84a0"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""df86f99f-df9c-4035-8d4c-85f78df2372c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""c4b148d0-2cbb-4765-a5b7-7919f3d14b53"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fd906e0a-d7e6-4d4f-9e59-10d941577f7b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""98f74f32-6ca9-434d-a986-a6919eb8ba91"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""06c5fe28-e9b8-4c32-8180-5e194e65b76d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d0719e68-2d1e-4061-8e47-aea669ded4ed"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Skills"",
            ""id"": ""3be6a940-88a7-4bbb-b4f9-c89c7b81274f"",
            ""actions"": [
                {
                    ""name"": ""Skill0"",
                    ""type"": ""Button"",
                    ""id"": ""7c441e59-c9ab-4e96-a6c8-3cf79610038f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill1"",
                    ""type"": ""Button"",
                    ""id"": ""591966e6-a44f-4314-b543-f4be716234a3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill2"",
                    ""type"": ""Button"",
                    ""id"": ""40b7c8bb-c373-4803-b123-d5fc9f790951"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill3"",
                    ""type"": ""Button"",
                    ""id"": ""876f1c5d-fe29-415b-967f-45d173717210"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill4"",
                    ""type"": ""Button"",
                    ""id"": ""6b73e3c3-2064-4d31-8ebb-beaf455c0279"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Skill5"",
                    ""type"": ""Button"",
                    ""id"": ""5e12cb34-14e7-4f22-8ce5-626a827e36a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1b087005-9777-40d1-a060-cab1379f28db"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f6f406b-504e-44d9-b714-b45aa71f1ddb"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc2b0838-7e92-491f-b9a4-72146c6dc0aa"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""feddfa6f-6eef-4043-8a77-af9bc2ac67b8"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d9756ac-bf4b-4ad2-86f2-ae1b1759508e"",
                    ""path"": ""<Keyboard>/5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b64d2705-7355-453f-8a71-e77d3a995794"",
                    ""path"": ""<Keyboard>/6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Skill5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Move = m_Player.FindAction("Move", throwIfNotFound: true);
        // Skills
        m_Skills = asset.FindActionMap("Skills", throwIfNotFound: true);
        m_Skills_Skill0 = m_Skills.FindAction("Skill0", throwIfNotFound: true);
        m_Skills_Skill1 = m_Skills.FindAction("Skill1", throwIfNotFound: true);
        m_Skills_Skill2 = m_Skills.FindAction("Skill2", throwIfNotFound: true);
        m_Skills_Skill3 = m_Skills.FindAction("Skill3", throwIfNotFound: true);
        m_Skills_Skill4 = m_Skills.FindAction("Skill4", throwIfNotFound: true);
        m_Skills_Skill5 = m_Skills.FindAction("Skill5", throwIfNotFound: true);
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
    private readonly InputAction m_Player_Move;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Player_Move;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Skills
    private readonly InputActionMap m_Skills;
    private ISkillsActions m_SkillsActionsCallbackInterface;
    private readonly InputAction m_Skills_Skill0;
    private readonly InputAction m_Skills_Skill1;
    private readonly InputAction m_Skills_Skill2;
    private readonly InputAction m_Skills_Skill3;
    private readonly InputAction m_Skills_Skill4;
    private readonly InputAction m_Skills_Skill5;
    public struct SkillsActions
    {
        private @PlayerInputActions m_Wrapper;
        public SkillsActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Skill0 => m_Wrapper.m_Skills_Skill0;
        public InputAction @Skill1 => m_Wrapper.m_Skills_Skill1;
        public InputAction @Skill2 => m_Wrapper.m_Skills_Skill2;
        public InputAction @Skill3 => m_Wrapper.m_Skills_Skill3;
        public InputAction @Skill4 => m_Wrapper.m_Skills_Skill4;
        public InputAction @Skill5 => m_Wrapper.m_Skills_Skill5;
        public InputActionMap Get() { return m_Wrapper.m_Skills; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SkillsActions set) { return set.Get(); }
        public void SetCallbacks(ISkillsActions instance)
        {
            if (m_Wrapper.m_SkillsActionsCallbackInterface != null)
            {
                @Skill0.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill0;
                @Skill0.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill0;
                @Skill0.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill0;
                @Skill1.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill1;
                @Skill1.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill1;
                @Skill1.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill1;
                @Skill2.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill2;
                @Skill2.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill2;
                @Skill2.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill2;
                @Skill3.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill3;
                @Skill3.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill3;
                @Skill3.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill3;
                @Skill4.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill4;
                @Skill4.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill4;
                @Skill4.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill4;
                @Skill5.started -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill5;
                @Skill5.performed -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill5;
                @Skill5.canceled -= m_Wrapper.m_SkillsActionsCallbackInterface.OnSkill5;
            }
            m_Wrapper.m_SkillsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Skill0.started += instance.OnSkill0;
                @Skill0.performed += instance.OnSkill0;
                @Skill0.canceled += instance.OnSkill0;
                @Skill1.started += instance.OnSkill1;
                @Skill1.performed += instance.OnSkill1;
                @Skill1.canceled += instance.OnSkill1;
                @Skill2.started += instance.OnSkill2;
                @Skill2.performed += instance.OnSkill2;
                @Skill2.canceled += instance.OnSkill2;
                @Skill3.started += instance.OnSkill3;
                @Skill3.performed += instance.OnSkill3;
                @Skill3.canceled += instance.OnSkill3;
                @Skill4.started += instance.OnSkill4;
                @Skill4.performed += instance.OnSkill4;
                @Skill4.canceled += instance.OnSkill4;
                @Skill5.started += instance.OnSkill5;
                @Skill5.performed += instance.OnSkill5;
                @Skill5.canceled += instance.OnSkill5;
            }
        }
    }
    public SkillsActions @Skills => new SkillsActions(this);
    public interface IPlayerActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
    public interface ISkillsActions
    {
        void OnSkill0(InputAction.CallbackContext context);
        void OnSkill1(InputAction.CallbackContext context);
        void OnSkill2(InputAction.CallbackContext context);
        void OnSkill3(InputAction.CallbackContext context);
        void OnSkill4(InputAction.CallbackContext context);
        void OnSkill5(InputAction.CallbackContext context);
    }
}
