using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class projectile_motion : MonoBehaviour
{
    public float force;
    public float angle;
    public InputField forceinput;
    public InputField angleinput;
    public Text scoretext;
    public Text triestext;
    public float score;
    public float tries;
    public Rigidbody2D projectile;
    public Collider2D Target;
    public Collider2D Projectilecollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void GetForce(string a){
        force = float.Parse(a);
    }
    void GetAngle(string b){
        angle = float.Parse(b);
    }
    void Reset(){
        projectile.gravityScale = 0;
        projectile.velocity = Vector2.zero;
    }
}
