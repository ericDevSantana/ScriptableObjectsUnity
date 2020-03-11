using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBehaviour : MonoBehaviour
{
    public ScriptablePlayer player;
    public Text description;

    private void OnMouseDown()
    {
        description.text = "Player's Name: " + player.playerName +
            "\nPlayer's description: " + player.playerDescription +
            "\nPlayer's health: " + player.playerBaseHealth +
            "\nPlayer's base attack: " + player.playerBaseAttack +
            "   \nPlayer's base defense: " + player.playerBaseDefense;
    }
}
