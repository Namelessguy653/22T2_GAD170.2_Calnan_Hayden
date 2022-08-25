using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Functions to complete:
/// - ReturnMyDancePowerLevel
/// - ReturnChanceToWin
/// </summary>
public class PowerLevel : MonoBehaviour
{
    public StatsSystem myStats; // a reference to our stats system
    int myPowerLevel;

    /// <summary>
    /// Used to generate a number of battle points that is used in combat.
    /// </summary>
    /// <returns></returns>
    public int ReturnMyDancePowerLevel()
    {
        // let's set our player power levels, using an algorithm, the simpliest would be luck + style + rhythm
        int myLuck = myStats.luck;
        int myStyle = myStats.style;
        int myRhthm = myStats.rhythm;

        return ((myLuck) + (myStyle) + (myRhthm)); // instead of returning 0 we probably want to return our current power level
    }

    /// <summary>
    /// Returns the chance to win a fight given the two powerlevels 
    /// </summary>
    /// <param name="myPowerLevel"></param>
    /// <param name="opponentPowerLevel"></param>
    /// <returns></returns>
    public float ReturnChanceToWin(int myPowerLevel, int opponentPowerLevel)
    {
        // let's first calculate the total power level overall.
        int totalPower = myPowerLevel + opponentPowerLevel;

        // Then let's then do a fraction of my power level and the overall power level.
        int myChanceToWin = (myPowerLevel / totalPower);
        // This will give us a decimal number, i.e. 3/4 will give us 0.75 we probably want to turn that into the percentage value.
        decimal amt = myChanceToWin;
        //myChanceToWin = (Value.ToString) * 100 + ("%"); 
        //double value = myChanceToWin; string result = value.ToString("P")
        //Frankly I am very stuck here

        return myChanceToWin; // Instead of returning 0 here we probably want to return our percentage chance to win.
    }
}
