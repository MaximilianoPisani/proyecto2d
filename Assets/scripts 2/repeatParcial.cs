using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class repeatParcial : MonoBehaviour
{
    int wood;
    int stone;
    int money = 100;
    int houses;
    int woodHouses;
    int stoneHouses;
    int mixHouses;
   List<string> resources = new List<string>();
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (wood == 20)
            {
                Debug.LogError("se alcanzo el limite ");
            }
            if (money >= 10)
            {
                wood = wood + 1;
                money = money - 10;
                Debug.Log("se compro una unidad de madera ");
                resources.Add($"Madera: {wood}");
                resources.Add($"Piedra: {stone}");
                resources.Add($"Plata: {money}");
                resources.Add($"Casas de madera: {woodHouses}");
                resources.Add($"Casas de piedra: {stoneHouses}");
                resources.Add($"Casas mixtas: {mixHouses}");

            }
            else
            {
                Debug.LogError("no alcanza el dinero ");
            }
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            if (stone == 20)
            {
                Debug.LogError("se alcanzo el limite ");
            }
            if (money >= 15)
            {
                stone = stone + 1;
                money = money - 15;
                Debug.Log("se compro una unidad de piedra ");
                resources.Add($"Piedra: {stone}");          
                resources.Add($"Madera: {wood}");
                resources.Add($"Plata: {money}");
                resources.Add($"Casas de madera: {woodHouses}");
                resources.Add($"Casas de piedra: {stoneHouses}");
                resources.Add($"Casas mixtas: {mixHouses}");
            }
            else
            {
                Debug.LogError("no alcanza el dinero ");
            }

        }


        if (Input.GetKeyDown(KeyCode.E)) 
        {
            money = money + 20;
            Debug.Log($"se ha ganado dinero!!! {money}");
        }


        if (Input.GetKeyDown(KeyCode.H))
        {
            if (wood >= 5)
            {
                wood = wood - 5;
                woodHouses = woodHouses + 1;
                houses = houses + 1;
                Debug.Log("se construyo una casa de madera");
                resources.Add($"Casas de madera: {woodHouses}");
                resources.Add($"Madera: {wood}");
                resources.Add($"Piedra: {stone}");
                resources.Add($"Plata: {money}");
                resources.Add($"Casas mixtas: {mixHouses}");
                resources.Add($"Casas de piedra: {stoneHouses}");


            }
            else
            {
                Debug.LogError("Faltan recursos");
            }
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (stone >= 5)
            {
                stone = stone - 5;
                stoneHouses = stoneHouses + 1;
                houses = houses + 1;
                Debug.Log("se construyo una casa de piedra");
                resources.Add($"Casas de piedra: {stoneHouses}");
                resources.Add($"Madera: {wood}");
                resources.Add($"Piedra: {stone}");
                resources.Add($"Plata: {money}");
                resources.Add($"Casas mixtas: {mixHouses}");
                resources.Add($"Casas de madera: {woodHouses}");
            }
            else
            {
                Debug.LogError("Faltan recursos");
            }
        }


        if (Input.GetKeyDown (KeyCode.M))
        {
            if (wood >= 5 && stone >= 5)
            {
                wood = wood - 5;
                stone = stone - 5;
                mixHouses = mixHouses + 1;
                houses = houses + 1;
                Debug.Log("se construyo una casa mixta");
                resources.Add($"Casas mixtas: {mixHouses}");
                resources.Add($"Madera: {wood}");
                resources.Add($"Piedra: {stone}");
                resources.Add($"Plata: {money}");
                resources.Add($"Casas de madera: {woodHouses}");
                resources.Add($"Casas de piedra: {stoneHouses}");


            }
            else
            {
                Debug.LogError("Faltan recursos");
            }
        }
        if (Input.GetKeyDown (KeyCode.R))
        {

            Debug.Log($"La cantidad total de madera es: {wood}");
            Debug.Log($"La cantidad total de piedra es: {stone}");
            Debug.Log($"La cantidad total de plata es: {money}");
            Debug.Log($"La cantidad total de casas construidas es: {houses}");
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (resources.Count > 0) 
            {
                foreach (string resource in resources)
                {
                    Debug.Log(resource);
                }
            }
        
        }
            
           
          
         




    }
}
