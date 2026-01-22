using UnityEngine;

public class RangerAttacksTest : MonoBehaviour
{
    public GameObject basicArrow;
    public GameObject arrowRain;

    private Vector3 mousePos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            BasicAttack();
        }
        if (Input.GetMouseButtonDown(1))
        {
            SpecialAttack();
        }
        if (Input.GetMouseButtonDown(2))
        {
            UltimateAttack();
        }
    }

    void BasicAttack()
    {
        Debug.Log("Ranger Attack 1 executed.");
        var new_basic_arrow = Instantiate(basicArrow, transform.position, Quaternion.identity);
        
    }
    void SpecialAttack()
    {
        Debug.Log("Ranger Attack 2 executed.");
        var new_special_arrow = Instantiate(basicArrow, transform.position, Quaternion.identity);
        var new_special_arrow2 = Instantiate(basicArrow, transform.position + new Vector3(0.2f,0.2f), Quaternion.identity);
        var new_special_arrow3 = Instantiate(basicArrow, transform.position + new Vector3(-0.2f,0.2f), Quaternion.identity);

    }
    void UltimateAttack()
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Ranger Ultimate executed.");
        var new_ultimate_arrow = Instantiate(arrowRain,mousePos,Quaternion.identity);
        new_ultimate_arrow.transform.position = new Vector3(new_ultimate_arrow.transform.position.x, new_ultimate_arrow.transform.position.y, 0f);
    }
}
