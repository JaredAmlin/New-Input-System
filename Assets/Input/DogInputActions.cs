//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Input/DogInputActions.inputactions
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

public partial class @DogInputActions : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @DogInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""DogInputActions"",
    ""maps"": [
        {
            ""name"": ""Dog"",
            ""id"": ""b1e379c9-aa3b-462b-8a52-bfb48eefbf9a"",
            ""actions"": [
                {
                    ""name"": ""Bark"",
                    ""type"": ""Button"",
                    ""id"": ""789c8a8d-5bd4-4d26-9a7f-dd7351735bd9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""5c671a0c-fdce-49b4-b77f-30e510970895"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""5c041728-5558-40a3-9b19-1f377ee40269"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Death"",
                    ""type"": ""Button"",
                    ""id"": ""77cf57ea-9998-4fc7-8952-e566d127df4c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ChangeToFlyingActionMap"",
                    ""type"": ""Button"",
                    ""id"": ""bcfec612-15c5-4251-8d5e-16213f6adf60"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""9dead4b1-3787-4e58-a53f-fb8fe8f8930a"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""72e26183-fd3e-414a-8cf2-f9eacef91eee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""40382ffc-739b-4279-b263-da6a1746f476"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bark"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""5a1714d6-5836-4b3e-bf87-ea89f1b84edb"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""042fbdfa-fb11-49c0-91e9-76ce1b1bc3f2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d782b90a-08e8-44d6-b005-76db7b4729aa"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""63ab56d4-36e9-4ffb-82b6-5f9f45e1a360"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a2f50601-ebf6-4b64-b3d8-99dde516d3a0"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7fe0c891-ebb0-4803-a90d-db66899548d5"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""4f05fd56-5150-4c4d-98fb-07df5f2bfadf"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Death"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""406803cc-b5ac-45bf-9764-daf8d7866798"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Death"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""36484a74-b608-49aa-a526-3fcf3dfad60f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Death"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7e92f6b4-b9a6-4f6d-9007-c6e8b6254e45"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeToFlyingActionMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrow Keys"",
                    ""id"": ""f9afeead-6ad0-4dc4-9a38-85f655aa725a"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""afde3313-1324-4771-bd36-82d950c3bcb8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9d0a7271-08ac-4bb5-95cc-704075c518f0"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""7cc1a76f-edf9-406a-bbed-286bdf1777ce"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold(duration=1)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FlyingDog"",
            ""id"": ""9dfdfce9-3b18-4772-86d3-e88424b26ef7"",
            ""actions"": [
                {
                    ""name"": ""Fly"",
                    ""type"": ""Value"",
                    ""id"": ""fec9e37e-0cee-4844-a9cf-3a6565adf2c8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeToWalkingActionMap"",
                    ""type"": ""Button"",
                    ""id"": ""3eca33fd-c354-4d46-9d64-3117fe45ea44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MouseRotation"",
                    ""type"": ""Value"",
                    ""id"": ""e7109ef8-598c-4b62-9b99-28348c69af13"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""FlyingJump"",
                    ""type"": ""Button"",
                    ""id"": ""36cf6aaa-367f-454d-b04f-e0f32d3fdf98"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8c352d71-146b-4e44-8103-eb617d7d51d3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5641c09a-e6a3-477d-a1a9-e56c51fe7963"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f5d365a3-aefb-4d9c-9eac-d84f32ddbaf2"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e45c9c81-9c96-418b-a8f5-38e98a30dd18"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7534e1c-1a06-4d47-a9dc-bae42cdd7673"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""ca79da0b-e77a-48ba-9b0a-c78bc9b36f22"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeToWalkingActionMap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17ba2de1-bf87-41db-9e64-146d9a086d0a"",
                    ""path"": ""<Pointer>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseRotation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdc25fc4-22c3-4fc2-a903-1c111b262328"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlyingJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Dog
        m_Dog = asset.FindActionMap("Dog", throwIfNotFound: true);
        m_Dog_Bark = m_Dog.FindAction("Bark", throwIfNotFound: true);
        m_Dog_Walk = m_Dog.FindAction("Walk", throwIfNotFound: true);
        m_Dog_Run = m_Dog.FindAction("Run", throwIfNotFound: true);
        m_Dog_Death = m_Dog.FindAction("Death", throwIfNotFound: true);
        m_Dog_ChangeToFlyingActionMap = m_Dog.FindAction("ChangeToFlyingActionMap", throwIfNotFound: true);
        m_Dog_Rotate = m_Dog.FindAction("Rotate", throwIfNotFound: true);
        m_Dog_Jump = m_Dog.FindAction("Jump", throwIfNotFound: true);
        // FlyingDog
        m_FlyingDog = asset.FindActionMap("FlyingDog", throwIfNotFound: true);
        m_FlyingDog_Fly = m_FlyingDog.FindAction("Fly", throwIfNotFound: true);
        m_FlyingDog_ChangeToWalkingActionMap = m_FlyingDog.FindAction("ChangeToWalkingActionMap", throwIfNotFound: true);
        m_FlyingDog_MouseRotation = m_FlyingDog.FindAction("MouseRotation", throwIfNotFound: true);
        m_FlyingDog_FlyingJump = m_FlyingDog.FindAction("FlyingJump", throwIfNotFound: true);
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

    // Dog
    private readonly InputActionMap m_Dog;
    private IDogActions m_DogActionsCallbackInterface;
    private readonly InputAction m_Dog_Bark;
    private readonly InputAction m_Dog_Walk;
    private readonly InputAction m_Dog_Run;
    private readonly InputAction m_Dog_Death;
    private readonly InputAction m_Dog_ChangeToFlyingActionMap;
    private readonly InputAction m_Dog_Rotate;
    private readonly InputAction m_Dog_Jump;
    public struct DogActions
    {
        private @DogInputActions m_Wrapper;
        public DogActions(@DogInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Bark => m_Wrapper.m_Dog_Bark;
        public InputAction @Walk => m_Wrapper.m_Dog_Walk;
        public InputAction @Run => m_Wrapper.m_Dog_Run;
        public InputAction @Death => m_Wrapper.m_Dog_Death;
        public InputAction @ChangeToFlyingActionMap => m_Wrapper.m_Dog_ChangeToFlyingActionMap;
        public InputAction @Rotate => m_Wrapper.m_Dog_Rotate;
        public InputAction @Jump => m_Wrapper.m_Dog_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Dog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DogActions set) { return set.Get(); }
        public void SetCallbacks(IDogActions instance)
        {
            if (m_Wrapper.m_DogActionsCallbackInterface != null)
            {
                @Bark.started -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Bark.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnBark;
                @Walk.started -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnWalk;
                @Run.started -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnRun;
                @Death.started -= m_Wrapper.m_DogActionsCallbackInterface.OnDeath;
                @Death.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnDeath;
                @Death.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnDeath;
                @ChangeToFlyingActionMap.started -= m_Wrapper.m_DogActionsCallbackInterface.OnChangeToFlyingActionMap;
                @ChangeToFlyingActionMap.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnChangeToFlyingActionMap;
                @ChangeToFlyingActionMap.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnChangeToFlyingActionMap;
                @Rotate.started -= m_Wrapper.m_DogActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnRotate;
                @Jump.started -= m_Wrapper.m_DogActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_DogActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_DogActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_DogActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Bark.started += instance.OnBark;
                @Bark.performed += instance.OnBark;
                @Bark.canceled += instance.OnBark;
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Death.started += instance.OnDeath;
                @Death.performed += instance.OnDeath;
                @Death.canceled += instance.OnDeath;
                @ChangeToFlyingActionMap.started += instance.OnChangeToFlyingActionMap;
                @ChangeToFlyingActionMap.performed += instance.OnChangeToFlyingActionMap;
                @ChangeToFlyingActionMap.canceled += instance.OnChangeToFlyingActionMap;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public DogActions @Dog => new DogActions(this);

    // FlyingDog
    private readonly InputActionMap m_FlyingDog;
    private IFlyingDogActions m_FlyingDogActionsCallbackInterface;
    private readonly InputAction m_FlyingDog_Fly;
    private readonly InputAction m_FlyingDog_ChangeToWalkingActionMap;
    private readonly InputAction m_FlyingDog_MouseRotation;
    private readonly InputAction m_FlyingDog_FlyingJump;
    public struct FlyingDogActions
    {
        private @DogInputActions m_Wrapper;
        public FlyingDogActions(@DogInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fly => m_Wrapper.m_FlyingDog_Fly;
        public InputAction @ChangeToWalkingActionMap => m_Wrapper.m_FlyingDog_ChangeToWalkingActionMap;
        public InputAction @MouseRotation => m_Wrapper.m_FlyingDog_MouseRotation;
        public InputAction @FlyingJump => m_Wrapper.m_FlyingDog_FlyingJump;
        public InputActionMap Get() { return m_Wrapper.m_FlyingDog; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlyingDogActions set) { return set.Get(); }
        public void SetCallbacks(IFlyingDogActions instance)
        {
            if (m_Wrapper.m_FlyingDogActionsCallbackInterface != null)
            {
                @Fly.started -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFly;
                @Fly.performed -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFly;
                @Fly.canceled -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFly;
                @ChangeToWalkingActionMap.started -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnChangeToWalkingActionMap;
                @ChangeToWalkingActionMap.performed -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnChangeToWalkingActionMap;
                @ChangeToWalkingActionMap.canceled -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnChangeToWalkingActionMap;
                @MouseRotation.started -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnMouseRotation;
                @MouseRotation.performed -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnMouseRotation;
                @MouseRotation.canceled -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnMouseRotation;
                @FlyingJump.started -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFlyingJump;
                @FlyingJump.performed -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFlyingJump;
                @FlyingJump.canceled -= m_Wrapper.m_FlyingDogActionsCallbackInterface.OnFlyingJump;
            }
            m_Wrapper.m_FlyingDogActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fly.started += instance.OnFly;
                @Fly.performed += instance.OnFly;
                @Fly.canceled += instance.OnFly;
                @ChangeToWalkingActionMap.started += instance.OnChangeToWalkingActionMap;
                @ChangeToWalkingActionMap.performed += instance.OnChangeToWalkingActionMap;
                @ChangeToWalkingActionMap.canceled += instance.OnChangeToWalkingActionMap;
                @MouseRotation.started += instance.OnMouseRotation;
                @MouseRotation.performed += instance.OnMouseRotation;
                @MouseRotation.canceled += instance.OnMouseRotation;
                @FlyingJump.started += instance.OnFlyingJump;
                @FlyingJump.performed += instance.OnFlyingJump;
                @FlyingJump.canceled += instance.OnFlyingJump;
            }
        }
    }
    public FlyingDogActions @FlyingDog => new FlyingDogActions(this);
    public interface IDogActions
    {
        void OnBark(InputAction.CallbackContext context);
        void OnWalk(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnDeath(InputAction.CallbackContext context);
        void OnChangeToFlyingActionMap(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IFlyingDogActions
    {
        void OnFly(InputAction.CallbackContext context);
        void OnChangeToWalkingActionMap(InputAction.CallbackContext context);
        void OnMouseRotation(InputAction.CallbackContext context);
        void OnFlyingJump(InputAction.CallbackContext context);
    }
}
