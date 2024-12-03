using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Spell : MonoBehaviour
{
    public virtual void Cast()
    {

    }
    public void Cast(string spell)
    {

    }
    public void Cast(string castTarget, int manaReq)
    {
        
    }
}
