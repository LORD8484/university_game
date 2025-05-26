using UnityEngine;

public class ShootScript : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 5f;
    public float spawnOffsetX = 1f;

    public GameManager gameManager;  

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (!gameManager.CanShoot())
        {
            Debug.Log("خشاب خالیه!");
            return;
        }

        
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;

        
        Vector3 direction = (mousePosition - transform.position).normalized;
        Vector3 spawnPosition = transform.position + new Vector3(spawnOffsetX, 0, 0);

        
        GameObject bullet = Instantiate(bulletPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletSpeed;

        
        gameManager.UseBullet();
    }
}
