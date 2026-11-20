using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public static int coinAmount;
    public TMP_Text coinText;
    public GameObject boss;
    public GameObject deadBoss;
    public static int bosshealth = 3;
    public TMP_Text bossText;
    void Update()
    {
        coinText.text = coinAmount.ToString();
        bossText.text = "Health: " + bosshealth;
        if (coinAmount >= 3) 
        {
            boss.SetActive(false);
            deadBoss.SetActive(true);
        }
    }
}
