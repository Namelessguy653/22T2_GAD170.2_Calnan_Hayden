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
        currentXp += xpGained + currentXp;

        // We probably want to check to see if we've gained enough xp to trigger a level up to occur.
        if (currentXp == currentXPThreshold)
        {
            // Debug to ensure trigger has worked
            Debug.Log("currentXP has reached XP threshold");

            // if we do then let's call our level up function.
            LevelUp(GetCurrentXPThreshold());

            // Debug to ensure that the level has increased by 1
            Debug.Log("Level Up!");
        
        }
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
        // So let's increase our current level
        ++currentLevel;

        // Debug to ensure the level has increased by 1
        Debug.Log("Level has been increased");
        
        currentXPThreshold *= currentLevel;

        //
        Debug.Log("The threshold has been increased");
    
    }

    #region No Mods Required.
    public void TestImplementation()
    {
        SetDefaultValues();
        Debug.Log(string.Format("Current Xp is {0} the current level is {1} and the current threshold is {2}", currentXp, currentLevel, currentXPThreshold));
        AddXP(200);
        Debug.Log(string.Format("Current Xp is {0} the current level is {1} and the current threshold is {2}", currentXp, currentLevel, currentXPThreshold));
        myStatSystem.TestDistributePhysicalStatsOnLevelUp(); // in theory if we've distributed our stats they should be different.
    }
    #endregion
}
