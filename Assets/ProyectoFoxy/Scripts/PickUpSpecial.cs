using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSpecial : PickUp // Hereda de PickUp
{
    public int bonusValue = 5; // Valor adicional de esta moneda especial

    // Sobrescribimos el método OnPickup para personalizar el comportamiento
    protected override void OnPickup(GameObject player)
    {
        // Llamamos al método base para agregar el valor base de coinValue
        base.OnPickup(player);

        // Añadimos el valor adicional específico de PickUpSpecial
        GameManager.instance.AddCoins(bonusValue);

        Debug.Log("¡Moneda especial recogida! Total monedas: " + (coinValue + bonusValue));
    }
}
