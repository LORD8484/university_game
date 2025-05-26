using UnityEngine;
using TMPro;

public class BulletCounterUI : MonoBehaviour
{
    public TextMeshProUGUI bulletText;
    public GameManager gameManager;

    void Update()
    {
        if (gameManager != null)
        {
            bulletText.text = "Ammo: " + gameManager.GetAmmo() + " / " + gameManager.maxBullets;
        }
    }
}
