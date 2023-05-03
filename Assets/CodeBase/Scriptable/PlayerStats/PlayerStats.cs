using UnityEngine;

namespace CodeBase.Scriptable.PlayerStats
{
    public enum Weapon
    {
        Shield,
        Sword,
        Stick,
        Book,
        Blade,
        Bow
    }
    
    [CreateAssetMenu(fileName = FileName, menuName = MenuName)]
    public class PlayerStats : ScriptableObject
    {
        private const string FileName = "PlayerStats";
        private const string MenuName = "PlayerStats/PlayerStats";
        
        public int health;
        public int damage;
        public int endurance;
        public int healthRegen;
        public int attackSpeed;
        public int moveSpeed;
        public int armor;
        public int luck;
        public int criticalDamage;
        public int money;
        public int numberOfAlies;
        public Weapon firstWeapon;
        public Weapon secondWeapon;
    }
}
