using UnityEngine;

public class Tree : MonoBehaviour
{
    private MeshRenderer rd;

    void Start()
    {
        rd = GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
            rd.material.color = Color.red;
            Player player = collision.gameObject.GetComponent<Player>();

            if (player == null) 
                return;

        player.Hp -= 15;
        UIManager.instance.ShowNotiText($"Hurt -15\nHP: {player.Hp}");

        if (player.Hp <= 0)
        { 
            player.Hp = 0;
            UIManager.instance.ShowNotiText($"Game Over!\n Point : {player.Point}");
            Time.timeScale = 0f;
            UIManager.instance.ShowHideRestartButton(true);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        rd.material.color = new Color32(104, 50, 50, 255);
    }
}
