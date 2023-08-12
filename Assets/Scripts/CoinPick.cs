using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinPick : MonoBehaviour
{
    [SerializeField] private int _howMuchCoins = 8;
    private int _coins = 0;
    private SpriteRenderer _spriteRenderer;
    public TMP_Text CoinsText;

    public Transform player;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag != "Coin") return;

        _coins++;
        CoinsText.text = $"{_coins.ToString()}/{_howMuchCoins}";
        Destroy(collider2D.gameObject);
        if(_coins==_howMuchCoins)
        {
            SceneLoader();
        } 
    }

    private void SceneLoader()
    {
        SceneManager.LoadScene("00_ChoiseRound");
    }


}