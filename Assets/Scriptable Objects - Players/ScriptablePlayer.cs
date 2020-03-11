using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player", menuName = "NewPlayer", order = 1)]
public class ScriptablePlayer : ScriptableObject
{
    public string playerName;
    public string playerDescription;

    public float playerBaseHealth;
    public float playerBaseAttack;
    public float playerBaseDefense;
           
}
