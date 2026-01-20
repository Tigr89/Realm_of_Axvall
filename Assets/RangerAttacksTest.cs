using UnityEngine;

public class RangerAttacksTest : MonoBehaviour
{
    public GameObject basicArrow;
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
    }

    void BasicAttack()
    {
        Debug.Log("Ranger Attack 1 executed.");
        var new_basic_arrow = Instantiate(basicArrow, transform.position, Quaternion.identity);
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0f; // Set z to 0 since we're in 2D
        Vector2 direction = (mousePosition - transform.position).normalized;
        new_basic_arrow.GetComponent<Arrow>().direction = direction;
    }
}
