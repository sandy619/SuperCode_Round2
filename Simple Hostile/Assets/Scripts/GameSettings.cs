using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sandy619
{
    public enum GameMode
    {
        FFA = 0,
        TDM = 1
    }

    public class GameSettings : MonoBehaviour
    {
        public static GameMode GameMode = GameMode.FFA;
        public static bool IsAwayTeam = false;
    }
}