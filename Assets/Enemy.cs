using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Enemy‚Ì‘Ì—Í—p•Ï”
    private int enemyHp;

    // Start is called before the first frame update
    void Start()
    {
        // ¶¬‚É‘Ì—Í‚ğİ’è‚µ‚Ä‚¨‚­
        enemyHp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        // ‚à‚µ‘Ì—Í‚ª0ˆÈ‰º‚É‚È‚Á‚½‚ç
        if ( enemyHp <= 0)
        {
            // Á‚¦‚é
            Destroy(this.gameObject);
        }
    }

    public void Damage()
    {
        // Enemy‚Ì‘Ì—Í‚ğ1Œ¸‚ç‚·
        enemyHp--;
    }
}
