using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "ScriptableObjects/CharacterStats", order = 1)]
public class CharacterStats : ScriptableObject
{
    [SerializeField]private int _moveSpeed;
    [SerializeField]private int _comboCount;
    [SerializeField] private int _health;
    [SerializeField]private int _damage;
    public int MoveSpeed => this._moveSpeed;
    public int ComboCount => this._comboCount;
    public int Health => this._health;
    public int Damage => this._damage;

}
