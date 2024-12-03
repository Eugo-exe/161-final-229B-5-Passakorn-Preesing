using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;
    public override float CalculateFoodRequirement()
    {
        dailyFoodConsumption = 0.5f;
        activityLevel = 3;
        Debug.Log($"{animalName} eats {dailyFoodConsumption} kg of food daily with activity {activityLevel}");
        Debug.Log($"{animalName}'s weekly food requirement: {(dailyFoodConsumption) * activityLevel * 7}");
        return (dailyFoodConsumption) * activityLevel*7;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("Dog barks: Woof Woof!");
    }
    public override void DisplayName()
    {
        Init("Dog");
        Debug.Log($"This is a {animalName}");
    }
    private void Start()
    {
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();

    }
}
