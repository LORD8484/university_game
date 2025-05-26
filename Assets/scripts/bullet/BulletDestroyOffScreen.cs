using UnityEngine;

public class BulletDestroyOffScreen : MonoBehaviour
{
    void OnBecameInvisible()
    {
        Destroy(gameObject); 
    }
}
