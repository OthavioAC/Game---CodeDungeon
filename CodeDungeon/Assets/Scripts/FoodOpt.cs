using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodOpt : MonoBehaviour
{
    public GameObject foodObj;
    public GameObject GiveFood;
    public bool foodAberto = false;

    void Start()
    {
        foodObj.SetActive(false);
    }

    public void ToggleFood() 
    {
        if(foodAberto)
        {
            foodAberto=false;
            foodObj.SetActive(false);
        }
        else
        {
            GiveFood.GetComponent<GiveFood>().ResetFoodCount();
            foodAberto =true;
            foodObj.SetActive(true);
        }
    }
}
