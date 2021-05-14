using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using Tools;

public class GameMaster : MonoBehaviour
{
    [SerializeField] public Player playerBlue;
    [SerializeField] public Player playerRed;

    [SerializeField] public int primaryPlayerHealth = 10;
    [SerializeField] public int bulletDamage = 1;
    [SerializeField] public int turnTime = 60;

    [SerializeField] public Image blueTankTurnIcon;
    [SerializeField] public Image blueTankWinnerIcon;

    [SerializeField] public Image redTankTurnIcon;
    [SerializeField] public Image redTankWinnerIcon;

    [SerializeField] public Text clockText;
    [SerializeField] public Text turnSymbol;

    [SerializeField] public GameObject endScreen;


    private bool _isBreak = false;
    private bool _clockIsRunning = true;
    private Player _currentPlayer = null;
    private int _currentTime=0;

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

    private void Start()
    {
        _currentPlayer = playerBlue;
        turnSymbol.gameObject.SetActive(true);
        blueTankTurnIcon.gameObject.SetActive(true);
        redTankTurnIcon.gameObject.SetActive(false);
        endScreen.SetActive(false);
        StartGame();
    }

    public Player CurrentPlayer {
        get {
            if(_isBreak) return null;
            return _currentPlayer;
        }
    }

    private int clock {
        get {
            return _currentTime;
        }
        set {
            if(value <= 0) {
                _currentTime = 0;
            }
            else {
                _currentTime = value;
            }
            
            clockText.text = _currentTime.ToString();
        }
    }

    public void StartGame() {
        playerBlue.Health = primaryPlayerHealth;
        playerRed.Health = primaryPlayerHealth;
        turnSymbol.gameObject.SetActive(true);
        clockText.gameObject.SetActive(true);
        StartClock(turnTime);
    }

    public void StartClock(int seconds) {
        clock = seconds;
        CLog.Info("Clock starts");
        StartCoroutine(countTime());
    }

    IEnumerator countTime(){
        while (_clockIsRunning)
        {
            clock-=1;
            if(clock <= 0) { 
                NextTurn();
            }
            yield return new WaitForSeconds(1);
        }
    }

    public void StopClock() {
        CLog.Info("Clock stops");
        _clockIsRunning = false;
    }

    public void NextTurn() {
        StopClock();
        _isBreak = true;
        playerBlue.Stop();
        playerRed.Stop();

        if(playerRed.Health <=.0f || playerBlue.Health <=.0f) {
            GameOver();
            return;
        }

        if(GameObject.ReferenceEquals(_currentPlayer, playerBlue)) {
            _currentPlayer = playerRed;
            blueTankTurnIcon.gameObject.SetActive(false);
            redTankTurnIcon.gameObject.SetActive(true);
        }
        else {
            _currentPlayer = playerBlue;
            blueTankTurnIcon.gameObject.SetActive(true);
            redTankTurnIcon.gameObject.SetActive(false);
        };

        playerBlue.Stop();
        playerRed.Stop();

        CLog.Info($"New Turn: {_currentPlayer.gameObject.name}");
        StartCoroutine(startTurnAfterSeconds(3));
    }

    private IEnumerator startTurnAfterSeconds(int seconds){
        yield return new WaitForSeconds(2);
        _isBreak = false;
        StartClock(turnTime);
    }

    public void GameOver() {
        if(playerRed.Health <= 0) blueTankWinnerIcon.gameObject.SetActive(true);
        else redTankWinnerIcon.gameObject.SetActive(true);
        endScreen.SetActive(true);
        
        turnSymbol.gameObject.SetActive(false);
        clockText.gameObject.SetActive(false);
    }

    public void RestartGame() {

    }
}
