using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace DM
{
    public class PlayerInventory : MonoBehaviour
    {

        WeaponSlotManager weaponSlotManager;
        public WeaponItem rightWeapon;
        public WeaponItem leftWeapon;
        
        private void Awake()
        {
            weaponSlotManager = GetComponentInChildren<WeaponSlotManager>();
            
        }

        private void Start()
        {
            weaponSlotManager.LoadWeaponSlot(rightWeapon,false);
            weaponSlotManager.LoadWeaponSlot(leftWeapon, true);

        }
    }


}
