using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObserverableFloat : MonoBehaviour
{
    private float _value;

    public float Value
    {
        get =>
            _value;
        set
        {
            _value = value;
            _onValueChanged?.Invoke(_value);
        }
    }

    public System.Action<float> _onValueChanged;

    public ObserverableFloat(float value) =>
        _value = value;
}
