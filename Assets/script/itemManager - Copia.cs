using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemManager : itemCollectableBase
{
    public static itemManager Instance;
    public int coins;

    void Awake()
    {
        if (Instance == null) 
            Instance = this;
        else
            Destroy(gameObject);
    }

    void restart()
    {
        coins = 0;
    }

    public void addCoins(int amount = 1)
    {
        coins += amount;
    }

}
