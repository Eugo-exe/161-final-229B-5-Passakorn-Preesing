using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{

    private float dailyFoodConsumption;
    private float weight;
    public override float CalculateFoodRequirement()
    {
        dailyFoodConsumption = 0.1f;
        weight = 0.5f;
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily and weights {weight}");
        Debug.Log($"{animalName}'s weekly food requirement: {(dailyFoodConsumption) * weight * 7}");
        return (dailyFoodConsumption) * weight * 7;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Bird chirps: Tweet Tweet!");
    }
    public override void DisplayName()
    {
        Init("Bird");
        Debug.Log($"This is a {animalName}");
    }
    private void Start()
    {
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();

    }
}
