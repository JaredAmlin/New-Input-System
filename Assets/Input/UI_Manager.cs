using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    private UiInputActions _uiInput;
    [SerializeField] private Image _radialFillImage;
    private bool _isCharging = false;
    private bool _isCharged = false;

    // Start is called before the first frame update
    void Start()
    {
        UiInputInitialization();
    }

    private void UiInputInitialization()
    {
        _uiInput = new UiInputActions();
        if (_uiInput != null)
            _uiInput.UI.Enable();

        _uiInput.UI.RadialChargeMeter.started += RadialChargeMeter_started;
        _uiInput.UI.RadialChargeMeter.canceled += RadialChargeMeter_canceled;
    }

    private void RadialChargeMeter_started(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        //start charging meter
        _isCharging = true;
        _isCharged = false;
        StartCoroutine(ChargingRoutine());
    }

    private void RadialChargeMeter_canceled(UnityEngine.InputSystem.InputAction.CallbackContext context)
    {
        //decharge meter
        _isCharging = false;
    }

    private IEnumerator ChargingRoutine()
    {
        while (_isCharging)
        {
            if (_radialFillImage.fillAmount < 1f)
            {
                _radialFillImage.fillAmount += (1.0f * Time.deltaTime) / 3f;

                if (_radialFillImage.fillAmount == 1f)
                {
                    Debug.Log("charged and ready to fire");
                    _isCharged = true;
                }
            }

            yield return null;
        }

        while (_isCharging == false)
        {
            if (_radialFillImage.fillAmount > 0f)
            {
                _radialFillImage.fillAmount -= 1.0f * Time.deltaTime;
            }

            yield return null;
        }
    }

    public bool IsCharged()
    {
        return _isCharged;
    }

    private void OnDisable()
    {
        _uiInput.UI.RadialChargeMeter.started -= RadialChargeMeter_started;
        _uiInput.UI.RadialChargeMeter.canceled -= RadialChargeMeter_canceled;
    }
}
