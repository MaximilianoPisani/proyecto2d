using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpecial : PickUp // Hereda de PickUp
{
    public int bonusValue = 5; // Valor adicional de esta moneda especial

    // Sobrescribimos el m�todo OnPickup para personalizar el comportamiento
    protected override void OnPickup(GameObject player)
    {
        // Llamamos al m�todo base para agregar el valor base de coinValue
        base.OnPickup(player);

        // A�adimos el valor adicional espec�fico de PickUpSpecial
        GameManager.instance.AddCoins(bonusValue);

        Debug.Log("�Moneda especial recogida! Total monedas: " + (coinValue + bonusValue));
    }
}
