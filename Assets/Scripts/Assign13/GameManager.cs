using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Attach GameManager to a game object in your Unity scene.
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Instantiate two Player objects.
        Player player1 = new Player();
        Player player2 = new Player();

        /*Call InitializePlayer() to set playerName and health for each
        Player object.*/
        player1.InitializePlayer("KIDO", 100);
        player2.InitializePlayer("MO", 100);

        /*Use both versions of the Heal() method to demonstrate method
        overloading.*/
        player1.health = 90;
        player2.health = 85;

        player1.Heal(10);
        player2.Heal(15);

        player1.health = 90;
        player2.health = 85;

        player1.Heal(true);
        player2.Heal(true);

        /*Call ShowPlayerCount() to display the total number of Player
        objects.*/
        Player.ShowPlayerCount();


    }

    // Update is called once per frame
    void Update()
    {

    }
}
