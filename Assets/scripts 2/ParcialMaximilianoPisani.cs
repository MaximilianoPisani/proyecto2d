using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcialMaximilianoPisani : MonoBehaviour
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
                Debug.LogError("The resource limit has been reached");

            }
            else
            {


                if (money >= 10)
                {
                    money = money - 10;
                    wood = wood + 1;
                    resources.Add("A unit of wood was purchased");
                    resources.Add($"wood:{wood}");
                    resources.Add($"stone:{stone}");
                    resources.Add($"money:{money}");
                    resources.Add($"mixHouses:{mixHouses}");
                    resources.Add($"woodHouses:{woodHouses}");
                    resources.Add($"stoneHouses:{stoneHouses}");
                }
                else
                {
                    Debug.LogError("Not enough money");
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (stone == 20)
            {
                Debug.LogError("The resource limit has been reached");

            }
            else
            {


                if (money >= 15)
                {


                    money = money - 15;
                    stone = stone + 1;
                    resources.Add("A stone unit was purchased");
                    resources.Add($"wood:{wood}");
                    resources.Add($"stone:{stone}");
                    resources.Add($"money:{money}");
                    resources.Add($"mixHouses:{mixHouses}");
                    resources.Add($"woodHouses:{woodHouses}");
                    resources.Add($"stoneHouses:{stoneHouses}");
                }
                else
                {
                    Debug.LogError("Not enough money");
                }
            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Debug.Log($"The accumulated money is: {money}");
            Debug.Log($"wood units: {wood}");
            Debug.Log($"stone units: {stone}");
            Debug.Log($"houses built: {houses}");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            money = money + 20;
            Debug.Log($"The accumulated money is: {money}");

        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (wood >= 5)
            {
                wood = wood - 5;
                woodHouses = woodHouses + 1;
                houses = houses + 1;
                resources.Add("A wooden house was built");
                resources.Add($"wood:{wood}");
                resources.Add($"stone:{stone}");
                resources.Add($"money:{money}");
                resources.Add($"mixHouses:{mixHouses}");
                resources.Add($"woodHouses:{woodHouses}");
                resources.Add($"stoneHouses:{stoneHouses}");

            }
            else
            {
                Debug.LogError("Insufficient wood");
            }

        }
        if (Input.GetKeyDown(KeyCode.P))
        {

            if (stone >= 5)
            {
                stone = stone - 5;
                stoneHouses = stoneHouses + 1;
                houses = houses + 1;
                resources.Add("A stone house was built");
                resources.Add($"wood:{wood}");
                resources.Add($"stone:{stone}");
                resources.Add($"money:{money}");
                resources.Add($"mixHouses:{mixHouses}");
                resources.Add($"woodHouses:{woodHouses}");
                resources.Add($"stoneHouses:{stoneHouses}");
            }
            else
            {
                Debug.LogError("insufficient stone");
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (stone >= 5 && wood >= 5)
            {
                stone = stone - 5;
                wood = wood - 5;
                mixHouses = mixHouses + 1;
                houses = houses + 1;
                resources.Add("A mixed house was built");
                resources.Add($"wood:{wood}");
                resources.Add($"stone:{stone}");
                resources.Add($"money:{money}");
                resources.Add($"mixHouses:{mixHouses}");
                resources.Add($"woodHouses:{woodHouses}");
                resources.Add($"stoneHouses:{stoneHouses}");

            }
            else
            {
                Debug.LogError("Insufficient resources");
            }


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
            else
            {
                Debug.Log("There are no actions to show");
            }

        }
    }
}

