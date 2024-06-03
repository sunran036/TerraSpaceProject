using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int damage;
    public int zhp;
    public int zdamage;
    public GameObject player;  // 쫓아갈 플레이어 GameObject
    public float chaseRange = 10f;  // 쫓아가는 범위

    public float moveSpeed = 5f;  // 캐릭터의 이동 속도

    private void Update()
    {
        // 플레이어와의 거리 계산
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        // 플레이어가 일정 범위 안에 있으면 쫓아감
        if (distanceToPlayer <= chaseRange)
        {
            // 플레이어 방향을 향해 이동
            Vector3 direction = (player.transform.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
            
            transform.LookAt(player.transform);
        }
    }
}
