using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MyScriptableObject : ScriptableObject
{
    //the idea of this scriptable object is to hold values that might be important for a unit in a strategy game
    
    //give a unit a name
    public new string name;
    //use an int to check which type of unit it is
    public int type;
    //use an int to check what kind of behavior the unit will have
    public int behaviorType;
    //hold unit's base health
    public float health;
    //set unit's base strength
    public float strength;
    //set unit's move range
    public float moveRange;
    //bool to check what team the unit is on
    public bool goodOrBad;
    //set position of the unit;
    public Vector3 position;
}
