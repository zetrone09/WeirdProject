using UnityEngine;

public class CharacterMotionManager : MonoBehaviour
{  
    public void HandleAllMovement()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("HitEnemy");
            UIBattleInfo.Instance.ShowBattleInfo();
        }
    }
}
