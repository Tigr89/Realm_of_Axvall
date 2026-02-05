using System.Collections;
using UnityEngine;


public class AttacksClass : MonoBehaviour
{
    [Header("Attacks cooldowns")]
    public float basicAttackCooldown = 1;
    public int specialAttackCooldown = 3;
    public int ultimateAttackCooldown = 10;

    [Header("Common Attack bools")]
    bool canBasicAttack = true;
    bool canSpecialAttack = true;
    bool canUltimateAttack = true;

    [Header("Mage Attacks stats")]
    // Mage attack stats would go here
    // projectile speed, damage, area of effect, etc.
    public int boltDamage = 0;
    public float boltSpeed = 5f;
    public float boltLifetime = 2f;
    public int fireballDamage = 0;
    public float fireballSpeed = 2f;
    public float fireballLifetime = 5f;
    public float lightningBoltDamagePerSecond = 0f;
    public float lightningBoltDuration = 05f;
    public GameObject basicBolt;
    public GameObject basicFireball;
    public GameObject LightningBolt;

    [Header("Warrior Attacks stats")]
    // Warrior attack stats would go here
    // swing speed, damage, etc.
    public int swingDamage = 0;
    public int slamDamage = 0;
    public float slamKnockback = 0f;
    public int whirlwindDamagePerSecond = 0;
    public float whirlwindDuration = 0f;

    [Header("Ranger Attacks stats")]
    public int arrowDamage = 10;
    public float arrowSpeed = 10f;
    public float arrowLifetime = 2f;
    public float arrowRainDuration = 5f;
    public int arrowRainDamagePerSecond = 5;
    // References to ranger attack prefabs
    public GameObject basicArrow;
    public GameObject arrowRain;

    private Vector3 mousePos;

    public void SelectBasicAttack(string _klass)
    {
        if (canBasicAttack)
        {
            canBasicAttack = false;
            StartCoroutine(BasicCooldown());
            if (_klass == "WARRIOR")
            {
                WarriorBasicAttack();
            }
            else if (_klass == "ROGUE")
            {
                RangerBasicAttack();
            }
            else if (_klass == "MAGE")
            {
                MageBasicAttack();
            }
        }
    }
    public void SelectSpecialAttack(string _klass)
    {
        if (canSpecialAttack)
        {
            canSpecialAttack = false;
            StartCoroutine(SpecialCooldown());
            if (_klass == "WARRIOR")
            {
                WarriorSpecialAttack();
            }
            else if (_klass == "ROGUE")
            {
                RangerSpecialAttack();
            }
            else if (_klass == "MAGE")
            {
                MageSpecialAttack();
            }
        }
    }
    public void SelectUltimateAttack(string _klass)
    {
        if (canUltimateAttack)
        {
            canUltimateAttack = false;
            StartCoroutine(UltimateCooldown());
            if (_klass == "WARRIOR")
            {
                WarriorUltimateAttack();
            }
            else if (_klass == "ROGUE")
            {
                RangerUltimateAttack();
            }
            else if (_klass == "MAGE")
            {
                MageUltimateAttack();
            }
        }
    }

    protected void RangerBasicAttack()
    {
        Debug.Log("Ranger Attack 1 executed.");
        var new_basic_arrow = Instantiate(basicArrow, transform.position, Quaternion.identity);
        new_basic_arrow.GetComponent<Arrow>().projectileSpeed = arrowSpeed;
        new_basic_arrow.GetComponent<Arrow>().lifetimeSeconds = arrowLifetime;
        new_basic_arrow.GetComponent<Arrow>().damage = arrowDamage;

    }
    protected void RangerSpecialAttack()
    {
        Debug.Log("Ranger Attack 2 executed.");
        var new_special_arrow = Instantiate(basicArrow, transform.position, Quaternion.identity);
        var new_special_arrow2 = Instantiate(basicArrow, transform.position + new Vector3(0.2f,0.2f), Quaternion.identity);
        var new_special_arrow3 = Instantiate(basicArrow, transform.position + new Vector3(-0.2f,0.2f), Quaternion.identity);
        new_special_arrow.GetComponent<Arrow>().projectileSpeed = arrowSpeed;
        new_special_arrow2.GetComponent<Arrow>().projectileSpeed = arrowSpeed;
        new_special_arrow3.GetComponent<Arrow>().projectileSpeed = arrowSpeed;
        new_special_arrow.GetComponent<Arrow>().lifetimeSeconds = arrowLifetime;
        new_special_arrow2.GetComponent<Arrow>().lifetimeSeconds = arrowLifetime;
        new_special_arrow3.GetComponent<Arrow>().lifetimeSeconds = arrowLifetime;
        new_special_arrow.GetComponent<Arrow>().damage = arrowDamage;
        new_special_arrow2.GetComponent<Arrow>().damage = arrowDamage;
        new_special_arrow3.GetComponent<Arrow>().damage = arrowDamage;
    }
    protected void RangerUltimateAttack()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Ranger Ultimate executed.");
        var new_ultimate_arrow = Instantiate(arrowRain,mousePos,Quaternion.identity);
        new_ultimate_arrow.transform.position = new Vector3(new_ultimate_arrow.transform.position.x, new_ultimate_arrow.transform.position.y, 0f);
        new_ultimate_arrow.GetComponent<ArrowRain>().damagePerSecond = arrowRainDamagePerSecond;
        new_ultimate_arrow.GetComponent<ArrowRain>().lifetimeSeconds = arrowRainDuration;
    }

    protected void WarriorBasicAttack()
    {
        //do warrior basic attack
    }
    protected void WarriorSpecialAttack()
    {
        //do warrior special attack
    }
    protected void WarriorUltimateAttack()
    {
        //do warrior ultimate attack
    }

    protected void MageBasicAttack()
    {

        var new_basic_bolt = Instantiate(basicBolt, transform.position, Quaternion.identity);
        new_basic_bolt.GetComponent<Bolt>().projectileSpeed = boltSpeed;
        new_basic_bolt.GetComponent<Bolt>().lifetimeSeconds = boltLifetime;
        new_basic_bolt.GetComponent<Bolt>().damage = boltDamage;
    }
    protected void MageSpecialAttack()
    {
        //do mage special attack
        Debug.Log("Mage Attack 2 executed.");
        var new_special_arrow = Instantiate(basicFireball, transform.position, Quaternion.identity);
        new_special_arrow.GetComponent<FireBall>().projectileSpeed = fireballSpeed;
        new_special_arrow.GetComponent<FireBall>().lifetimeSeconds = fireballLifetime;
        new_special_arrow.GetComponent<FireBall>().damage = fireballDamage;
         
    }
    protected void MageUltimateAttack()
    {
        //do mage ultimate attack
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Ranger Ultimate executed.");
        var new_ultimate_LightningBolt = Instantiate(LightningBolt, mousePos, Quaternion.identity);
        new_ultimate_LightningBolt.transform.position = new Vector3(new_ultimate_LightningBolt.transform.position.x, new_ultimate_LightningBolt.transform.position.y, 0f);
        new_ultimate_LightningBolt.GetComponent<LightningBolt>().damagePerSecond = arrowRainDamagePerSecond;
        new_ultimate_LightningBolt.GetComponent<LightningBolt>().lifetimeSeconds = arrowRainDuration;
    }
    private IEnumerator BasicCooldown()
    {
        yield return new WaitForSeconds(basicAttackCooldown);
        canBasicAttack = true;
    }
    private IEnumerator SpecialCooldown()
    {
        yield return new WaitForSeconds(specialAttackCooldown);
        canSpecialAttack = true;
    }
    private IEnumerator UltimateCooldown()
    {
        yield return new WaitForSeconds(ultimateAttackCooldown);
        canUltimateAttack = true;
    }
}
