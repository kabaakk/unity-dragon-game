using UnityEngine;

public class platformmovement : MonoBehaviour
{
    public float speed;

    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x < -10)
        {
            transform.position += new Vector3(20, 0, 0);
            ShowRandomSprite();
            enemy?.respawn();
        }
    }

    private void ShowRandomSprite()
    {
        int index = UnityEngine.Random.Range(0, 3);
        int childcount = transform.childCount;

        for (int i = 0; i < childcount; i++)
        {
            Transform child = transform.GetChild(i);
            bool shouldshow = index == i;

            child.gameObject.SetActive(shouldshow);
        }
    }

    private void OnEnable()
    {
        ShowRandomSprite();
    }
}
