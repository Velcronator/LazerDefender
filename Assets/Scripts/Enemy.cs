using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject explosionPrefab = null;
    [SerializeField] GameObject enemyLaserPrefab = null;
    [SerializeField] float health = 300;
    [SerializeField] float shotCounter;
    [SerializeField] float minTimeBetweenShots = 0.2f;
    [SerializeField] float maxTimeBetweenShots = 3f;
    [SerializeField] float projectileSpeed = 10f;
    [SerializeField] float durationOfExplosion = 2f;

    [Header("Sounds")]
    [SerializeField] AudioClip deathSoundClip = null;
    [SerializeField] AudioClip laserSoundClip = null;
    [SerializeField] [Range(0, 1)] float laserClipVolume = 0.2f;
    [SerializeField] [Range(0, 1)] float deathClipVolume = 0.3f;


    // Start is called before the first frame update
    void Start()
    {
        shotCounter = Random.Range(minTimeBetweenShots,maxTimeBetweenShots);
    }

    // Update is called once per frame
    void Update()
    {
        CountDownAndShoot();
    }

    private void CountDownAndShoot()
    {
        shotCounter -= Time.deltaTime;
        if(shotCounter <= 0f)
        {
            Fire();
        }
    }

    private void Fire()
    {
        shotCounter = Random.Range(minTimeBetweenShots, maxTimeBetweenShots);
        GameObject laser = Instantiate(enemyLaserPrefab, transform.position, Quaternion.identity) as GameObject;
        laser.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -projectileSpeed);
        AudioSource.PlayClipAtPoint(laserSoundClip, Camera.main.transform.position, laserClipVolume);

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        DamageDealer damageDealer = col.gameObject.GetComponent<DamageDealer>();
        if (!damageDealer) { return; }
        ProcessHit(damageDealer);
    }

    private void ProcessHit(DamageDealer damageDealer)
    {
        health -= damageDealer.GetDamage();
        damageDealer.Hit();
        if (health <= 0)
        {
            ProcessDeath();
        }
    }

    private void ProcessDeath()
    {
        GameObject explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity) as GameObject;
        Destroy(explosion, durationOfExplosion);
        Destroy(gameObject);
        AudioSource.PlayClipAtPoint(deathSoundClip, Camera.main.transform.position, deathClipVolume);
    }
}
