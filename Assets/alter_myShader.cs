using UnityEngine;
using System.Collections;

public class alter_myShader : MonoBehaviour {

    public Renderer rend;

	void Update () 
    {
        rend = GetComponent<Renderer>();
        Color ColourA = Color.blue;
        Color ColourB = Color.yellow;
        ColourA.r = Mathf.PingPong(Time.time, 1f);
        ColourB.r = Mathf.PingPong(Time.time, 1f);

        var rnd = Random.Range(0, 5);
        if (rnd == 0)
        {
            rend.material.SetColor("_Color", ColourA);
        }
        else if (rnd == 4){
            rend.material.SetColor("_Color", ColourB);
        }
	}
}
