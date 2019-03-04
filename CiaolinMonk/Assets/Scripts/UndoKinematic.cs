using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoKinematic : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject explosion;
    public GameObject[] cometTiles;
    public ParticleSystem[] cometParticle;


    private void Start()
    {
       
    }

    public void Notkinematic()
    {

        for (int i = 0; i < cometTiles.Length; i++)
        {
            cometTiles[i].GetComponent<Rigidbody>().isKinematic = false;
        }
        Particle();
    }



    public void Particle(){



        for (int i = 0; i < cometParticle.Length; i++)
        {
            var em = cometParticle[i].GetComponent<ParticleSystem>().emission;
            em.enabled = false;

        }
    }

    public void CometExplosion()
    {

        explosion.SetActive(true);


    }

  
}
