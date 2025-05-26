using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int maxBullets = 5;
    public TextMeshProUGUI bulletText;
    public GameObject gameOverPanel;

    private int bulletsLeft;

    void Start()
    {
        bulletsLeft = maxBullets;
        UpdateBulletUI();
        gameOverPanel.SetActive(false);
    }

    public bool CanShoot()
    {
        return bulletsLeft > 0;
    }

    public void UseBullet()
    {
        bulletsLeft--;
        UpdateBulletUI();

        if (bulletsLeft <= 0)
        {
            CheckGameOver();
        }
    }

    void UpdateBulletUI()
    {
        bulletText.text = "Ammo: " + bulletsLeft.ToString();
    }

    void CheckGameOver()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");

        if (enemies.Length > 0)
        {
            gameOverPanel.SetActive(true);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public int GetAmmo()
    {
        return bulletsLeft;
    }
    


}
