using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CometParticle : MonoBehaviour

    {
        // Start is called before the first frame update

        public GameObject aufprall;
        public ParticleSystem[] cometParticle;


        public void Particle()
        {



            for (int i = 0; i < cometParticle.Length; i++)
            {
                var em = cometParticle[i].GetComponent<ParticleSystem>().emission;
                em.enabled = false;
                CometAufprall();

            }
        }

        
    public void CometAufprall()
    {

        aufprall.SetActive(true);


    }


}
