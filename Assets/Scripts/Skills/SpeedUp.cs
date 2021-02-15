using UnityEngine;

public class SpeedUp : PowerUp
{
    GameObject player;
    PlayerMovement playerMovement;
    public AudioSource speedUpAudio;

    public override void Awake()
    {
        //Mencari game object dengan tag "Player"
        player = GameObject.FindGameObjectWithTag("Player");

        //mendapatkan komponen player health
        playerMovement = player.GetComponent<PlayerMovement>();
    }

    //Callback jika ada suatu object masuk kedalam trigger
    public override void OnTriggerEnter(Collider other)
    {
        //Set player in range
        float dist = Vector3.Distance(other.transform.position, transform.position);
        if ((other.tag == "Player") && (dist < 1.5))
        {
            playerMovement.SpeedUp();
            this.gameObject.SetActive(false);
        }
    }
}
