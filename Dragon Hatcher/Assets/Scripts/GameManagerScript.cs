using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public static GameManagerScript instance;

    // Use this for initialization
    public float moneyCurrent;
    
    public Text moneyIndicator;

    public int Level1Current;
    public Text Level1CostIndicator;
    public float Level1Cost;
    public float Level1XPosition;

    public int Level2Current;
    public Text Level2CostIndicator;
    public float Level2Cost;
    public float Level2XPosition;

    public GameObject Level1Icon;
	void Start () {
        Level1Cost = 10;
        instance = this;

        Level2Cost = 20;
        instance = this;
		
	}
	
	// Update is called once per frame
	void Update () {
        moneyIndicator.text = "" + (int)moneyCurrent;
        
        moneyCurrent += 0.0165f * Level1Current;
        moneyCurrent += 1.0165f * Level2Current;

        Level1CostIndicator.text = "" + Level1Cost;
        Level2CostIndicator.text = "" + Level2Cost;
	}

    public void GetMoney()
    {
        moneyCurrent += 1;

    }

    public void GetLevel1()
    {
        if (moneyCurrent >= Level1Cost)

        {
            Level1Current += 1;
            moneyCurrent -= Level1Cost;
            Level1Cost = Level1Cost * 1.15f;

            Instantiate(Level1Icon, new Vector3(Level1XPosition, 0, 0), Quaternion.identity);
            Level1XPosition += 0.5f; 
        }
    }

    public void GetLevel2()
    {
        if (moneyCurrent >= Level2Cost)

        {
            Level2Current += 1;
            moneyCurrent -= Level2Cost;
            Level2Cost = Level2Cost * 2.15f;

            Instantiate(Level1Icon, new Vector3(Level1XPosition, 0, 0), Quaternion.identity);
            Level1XPosition += 0.5f;
        }
    }

}
