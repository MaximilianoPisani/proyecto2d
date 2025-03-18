using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    private Slider _slider;

    void Start()
    {
        _slider = GetComponent<Slider>();
    }

    public void ChangeMaxHealth(float _maxHealth) 
    {
      _slider.value = _maxHealth;
    
    }
    public void ChangeCurrentHealt(float quantityHealth) 
    {
      _slider.value = quantityHealth;
    }

    public void InitializeLifeBar(float quantityHealth) 
    {
        ChangeMaxHealth(quantityHealth);
        ChangeCurrentHealt(quantityHealth);
    }
}