using UnityEngine;

public class Healing : PowerUp
{
    GameObject player;
    PlayerHealth playerHealth;
    public AudioSource healingAudio;

    public override void Awake()
    {
        //Mencari game object dengan tag "Player"
        player = GameObject.FindGameObjectWithTag("Player");

        //mendapatkan komponen player health
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    //Callback jika ada suatu object masuk kedalam trigger
    public override void OnTriggerEnter(Collider other)
    {
        //Set player in range
        float dist = Vector3.Distance(other.transform.position, transform.position);
        if ((other.tag == "Player") && (dist < 1.5))
        {
            playerHealth.Healing();
            this.gameObject.SetActive(false);
        }
    }
}
