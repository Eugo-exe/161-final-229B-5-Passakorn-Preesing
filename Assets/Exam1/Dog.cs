using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private float dailyFoodConsumption;
    private int activityLevel;
    public override float CalculateFoodRequirement()
    {
        return (dailyFoodConsumption) * activityLevel*7;
    }
    public override void MakeSound()
    {
        base.MakeSound();
        Debug.Log("The animal makes a sound");
    }
    public override void DisplayName()
    {
        
        DisplayName();
    }
    private void Start()
    {
        DisplayName();
        MakeSound();
        CalculateFoodRequirement();
    }
}
