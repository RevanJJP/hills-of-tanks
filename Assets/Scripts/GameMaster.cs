using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Tools;

public class GameMaster : MonoBehaviour
{
    [SerializeField] public Player playerBlue;
    [SerializeField] public Player playerRed;

    [SerializeField] public int primaryPlayerHealth = 10;
    [SerializeField] public int bulletDamage = 1;
    [SerializeField] public int turnTime = 60;


    private static GameMaster _gameMaster;

    public static GameMaster instance
    {
        get
        {
            if (!_gameMaster)
            {
                _gameMaster = FindObjectOfType(typeof(GameMaster)) as GameMaster;

                if (!_gameMaster)
                {
                    CLog.Error("There needs to be one active GameMaster script on a GameObject in your scene.");
                }
                else
                {
                    _gameMaster.init();
                }
            }

            return _gameMaster;
        }
    }

    private void init()
    {
        
    }

    public void StartGame() {
        playerBlue.Health = primaryPlayerHealth;
        playerRed.Health = primaryPlayerHealth;

        
    }

    
    public void StopTurn() {

    }

    public void NextTurn() {

    }

    public void GameOver() {
        
    }

    public void RestartGame() {

    }
}
