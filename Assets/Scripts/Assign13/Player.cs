using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.Rendering;

/*1. Create a C# script named Player without “: MonoBehaviour” and
remove the Start() and Update() methods.*/
public class Player 
{

/*2. Define the following public fields:
a. playerName (string)
b. health (int)*/
public string playerName;
public int health;
int maxHealth;

/*Implement a method InitializePlayer(string name, int initialHealth)
to set the playerName and health.*/
public void InitializePlayer(string name, int initialHealth)
{
/*Increment playerCount within the InitializePlayer() method.*/
playerCount+=1;
playerName=name;
health=initialHealth;
maxHealth=initialHealth;
}
/*Add a method Heal(int amount) to increase health by a specified
amount and print the update using Debug.Log().*/
public void Heal(int amount)
{
    health+=amount;
    UnityEngine.Debug.Log(health);
}
/*Overload the Heal() method to accept a bool fullRestore parameter
to fully restore health when set to true.*/
public void Heal(bool fullRestore)
{
    if (fullRestore==true)
    {
        health=maxHealth;
        UnityEngine.Debug.Log(health);
    }
}
/*Add a static field playerCount to keep track of the number of Player
objects.*/
public static int playerCount;
/*Create a static method ShowPlayerCount() to print playerCount
using Debug.Log().*/
public static void ShowPlayerCount()
{
    UnityEngine.Debug.Log(playerCount);
}


}
