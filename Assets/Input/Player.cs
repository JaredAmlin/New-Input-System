using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private PlayerInputActions _playerInput;
    [SerializeField] private GameObject _projectile;
    [SerializeField] private GameObject _spreadShot;
    private Rigidbody _rb;
    [SerializeField] private UI_Manager _uiManager;
    private bool _isCharged = false;

    // Start is called before the first frame update
    void Start()
    {
        _playerInput = new PlayerInputActions();
        if (_playerInput != null)
            _playerInput.Player.Enable();

        _rb = GetComponent<Rigidbody>();
        if (_rb == null)
            Debug.LogError("The Player Rigidbody is NULL!");
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Fire();
        Jump();
    }

    private void Movement()
    {
        var keyboard = Keyboard.current;
        if (keyboard == null)
            return;

        Vector2 playerMovement = _playerInput.Player.Movement.ReadValue<Vector2>();
        transform.Translate(new Vector3(playerMovement.x, 0, playerMovement.y) * Time.deltaTime * 5f);

        float mouseRotation = _playerInput.Player.Rotate.ReadValue<float>();
        transform.Rotate(Vector3.up * Time.deltaTime * 20f * mouseRotation);
    }
    private void Fire()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(_projectile, this.transform.position, this.transform.rotation);
        }

        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            _isCharged = _uiManager.IsCharged();

            if (_isCharged)
            {
                Debug.Log("Bring out the big guns!!");
                //fire special weapon
                Instantiate(_spreadShot, this.transform.position, this.transform.rotation);
            }
        }
    }

    private void Jump()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            _rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
