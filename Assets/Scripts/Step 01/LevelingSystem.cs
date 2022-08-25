using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - SetDefaultValues
/// - AddXP
/// - LevelUp
/// </summary>
public class LevelingSystem : MonoBehaviour
{
    public StatsSystem myStatSystem; // a reference to our stats system

    public int currentLevel; // Our current level.

    public int currentXp; // The current amount of xp we have accumulated.

    public int currentXPThreshold = 10; // The amount of xp required to level up.

    private int xpGained;

    /// <summary>
    /// sets our script to default values
    /// </summary>
    public void SetDefaultValues()
    {
        // set our current level to 1
        currentLevel = 1;

        // set our current XP to zero
        currentXp = 0;

        // set our current XP Threshold to be our level multiplied by our 100.
        currentXPThreshold = currentLevel * 100;

    }

    /// <summary>
    /// A function called when the battle is completed and some xp is to be awarded.
    /// The amount of xp gained is coming into this function
    /// </summary>
    public void AddXP(int xpGained)
    {
        // We want to be able to add on the xpGained onto our currentXp.
        // The equation for it would be xpGained + currentXP = NEWcurrentXP
        // We probably want to check to see if we've gained enough xp to trigger a level up to occur.
        if ((currentXp + xpGained) >= currentXPThreshold)
        {
            Debug.Log("Level up!");
        }
        //return xpGained;
        //^ Unity does not like this for some reason?
    }

    private int GetCurrentXPThreshold()
    {
        return currentXPThreshold;
    }

    /// <summary>
    /// A function used to handle actions associated with levelling up.
    /// </summary>
    private void LevelUp(int currentXPThreshold)
    {
        if ((currentXp + xpGained) >= currentXPThreshold)
        {
            int currentLevel = (this.currentLevel + 1);
        }

        // Debug to ensure the level has increased by 1
        Debug.Log("Level has been increased");
        
        currentXPThreshold *= currentLevel;

        //
        Debug.Log("The threshold has been increased");
    
    }
}
