using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public void Init(string Name)
    {
       animalName = Name;
    }
    public abstract float CalculateFoodRequirement();
    public virtual void MakeSound()
    {
        Debug.Log("The animal makes a sound.");
    }
    public virtual void DisplayName()
    {
       
    }
}
