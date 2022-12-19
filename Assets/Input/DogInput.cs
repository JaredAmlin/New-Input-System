using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class DogInput : MonoBehaviour
{
    //reference to input action class
    private DogInputActions _dogInput;
    [SerializeField] private AudioClip _barkClip;
    [SerializeField] private AudioSource _audioSource;
    private Action<InputAction.CallbackContext> _barkEvent;
    private float _walkSpeed = 5f;
    private float _rotateSpeed = 50f;
    private bool _isJumping = false;
    private bool _hasJumped = false;
    private float _jumpForce = 15f;
    private float _jumpForce2 = 25f;
    private Rigidbody _rb;

    //enable action map

    //register perform functions

    private void Start()
    {
        InputInitialization();
    }

    private void Update()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
            return;
        DogMovement();
    }

    private void DogMovement()
    {
        //player rotation
        Debug.Log("Current rotation is " + _dogInput.Dog.Rotate.ReadValue<float>());
        float rotateDirection = _dogInput.Dog.Rotate.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * _rotateSpeed * rotateDirection);

        float mouseRotation = _dogInput.FlyingDog.MouseRotation.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * _rotateSpeed * mouseRotation);

        //player movement
        Vector2 _dogMovement = _dogInput.Dog.Walk.ReadValue<Vector2>();
        transform.Translate(new Vector3(_dogMovement.x, 0, _dogMovement.y) * Time.deltaTime * _walkSpeed);
        //transform.Translate(_dogMovement * Time.deltaTime * _walkSpeed);

        Vector2 _flyingDog = _dogInput.FlyingDog.Fly.ReadValue<Vector2>();
        transform.Translate(_flyingDog * Time.deltaTime * _walkSpeed);

        //player jump
        if (_isJumping == true)
            _rb.AddForce(Vector3.up, ForceMode.Impulse);
            //_rb.AddForce(transform.up * _jumpForce);
    }

    private void InputInitialization()
    {
        _rb = GetComponent<Rigidbody>();
        if (_rb == null)
            Debug.LogError("The Rigidbody is NULL!");

        //initialize Dog Action Map
        _dogInput = new DogInputActions();
        if (_dogInput != null)
            _dogInput.Dog.Enable();

        //subscribe to action events
        _dogInput.Dog.Bark.started += Bark_started;

        //_dogInput.Dog.Bark.performed += Bark_performed;
        _barkEvent = (InputAction.CallbackContext context) =>
        {
            Debug.Log("Bark! Bark! " + context);
            _audioSource.PlayOneShot(_barkClip);
        };

        if (_barkEvent != null)
            _dogInput.Dog.Bark.performed += _barkEvent;
       
        //_dogInput.Dog.Bark.performed += (InputAction.CallbackContext context) => 
        //{ 
        //    Debug.Log("Bark! Bark! " + context);
        //    _audioSource.PlayOneShot(_barkClip);
        //};

        _dogInput.Dog.Bark.canceled += Bark_canceled;

        _dogInput.Dog.Walk.performed += Walk_performed;

        _dogInput.Dog.Run.started += Run_started;
        _dogInput.Dog.Run.performed += Run_performed;
        _dogInput.Dog.Run.canceled += Run_canceled;

        _dogInput.Dog.Death.performed += Death_performed;

        _dogInput.FlyingDog.Fly.performed += Fly_performed;

        _dogInput.Dog.ChangeToFlyingActionMap.performed += ChangeToFlyingActionMap_performed;

        _dogInput.FlyingDog.ChangeToWalkingActionMap.performed += ChangeToWalkingActionMap_performed;

        _dogInput.FlyingDog.FlyingJump.started += FlyingJump_started;
        _dogInput.FlyingDog.FlyingJump.canceled += FlyingJump_canceled;

        _dogInput.Dog.Jump.performed += Jump_performed;
        _dogInput.Dog.Jump.canceled += Jump_canceled;
    }

    private void Jump_canceled(InputAction.CallbackContext context)
    {
        //stop jumping
        Debug.Log("Jump Duration " + context.duration);
        double forceMultiplier = context.duration;
        _rb.AddForce(Vector3.up * (_jumpForce * (float)forceMultiplier), ForceMode.Impulse);
    }

    private void Jump_performed(InputAction.CallbackContext context)
    {
        //full jump
        _hasJumped = true;
        _rb.AddForce(Vector3.up * _jumpForce2, ForceMode.Impulse);
    }

    private IEnumerator JumpingRoutine()
    {
        yield return new WaitForSeconds(1f);
        _isJumping = false;
    }

    private void FlyingJump_canceled(InputAction.CallbackContext obj)
    {
        //stop jumping
        _isJumping = false;
    }

    private void FlyingJump_started(InputAction.CallbackContext context)
    {
        //enable jumping
        _isJumping = true;
        StartCoroutine(JumpingRoutine());
    }

    private void Fly_performed(InputAction.CallbackContext context)
    {
        //flying
    }

    private void ChangeToWalkingActionMap_performed(InputAction.CallbackContext context)
    {
        //change to walking action map
        _dogInput.FlyingDog.Disable();
        _dogInput.Dog.Enable();
        Debug.Log("This dog is walking.");
    }

    private void ChangeToFlyingActionMap_performed(InputAction.CallbackContext context)
    {
        //change to flying action map
        _dogInput.Dog.Disable();
        _dogInput.FlyingDog.Enable();
        Debug.Log("This dog is flying!!");
    }

    private void Run_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Dog stopped running " + context);
    }

    private void Run_started(InputAction.CallbackContext context)
    {
        Debug.Log("Dog started running " + context);
    }

    private void Death_performed(InputAction.CallbackContext context)
    {
        Debug.Log("The poor dog is dead " + context);
    }

    private void Run_performed(InputAction.CallbackContext context)
    {
        Debug.Log("The dog is running! " + context);
    }

    private void Walk_performed(InputAction.CallbackContext context)
    {
        Debug.Log("Taking the dog for a walk " + context);
        Debug.Log($"X value: {context.ReadValue<Vector2>().x} Y value: {context.ReadValue<Vector2>().y}");

        //Vector2 _dogMovement = context.ReadValue<Vector2>();
        //transform.Translate(_dogMovement * Time.deltaTime * _walkSpeed);
    }

    private void Bark_started(InputAction.CallbackContext context)
    {
        Debug.Log("Started Barking " + context);
    }

    //Get Key Up
    private void Bark_canceled(InputAction.CallbackContext context)
    {
        Debug.Log("Stop Barking " + context);
    }

    //Get Key Down
    //private void Bark_performed(InputAction.CallbackContext context)
    //{
    //    Debug.Log("Bark! Bark! " + context);
    //    _audioSource.PlayOneShot(_barkClip);
    //}

    private void OnDisable()
    {
        _dogInput.Dog.Bark.started -= Bark_started;
        //_dogInput.Dog.Bark.performed -= Bark_performed;
        _dogInput.Dog.Bark.performed -= _barkEvent;
        _dogInput.Dog.Bark.canceled -= Bark_canceled;
        _dogInput.Dog.Walk.performed -= Walk_performed;
        _dogInput.Dog.Run.started -= Run_started;
        _dogInput.Dog.Run.performed -= Run_performed;
        _dogInput.Dog.Run.performed -= Run_canceled;
        _dogInput.Dog.Death.performed -= Death_performed;
        _dogInput.FlyingDog.Fly.performed -= Fly_performed;
        _dogInput.Dog.ChangeToFlyingActionMap.performed -= ChangeToFlyingActionMap_performed;
        _dogInput.FlyingDog.ChangeToWalkingActionMap.performed -= ChangeToWalkingActionMap_performed;
    }
}
