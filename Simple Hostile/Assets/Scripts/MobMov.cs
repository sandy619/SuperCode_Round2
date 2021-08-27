using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace sandy619
{
    public class MobMov : MonoBehaviour
    {
        public FixedJoystick MoveJoystick;
        //public DynamicJoystick dynamicJoystick;
        public FixedButton JumpButton;
        public FixedButton FireButton;
        public FixedButton SprintButton;
        public FixedTouchField TouchField;
        // Start is called before the first frame update
        void Start()
        {
            //dynamicJoystick = GameObject.Find("Dynamic Joystick").GetComponent<DynamicJoystick>();
            MoveJoystick = GameObject.Find("Fixed Joystick").GetComponent<FixedJoystick>();
            JumpButton = GameObject.Find("Jump").GetComponent<FixedButton>();
            TouchField = GameObject.Find("TouchInput").GetComponent<FixedTouchField>();
            SprintButton = GameObject.Find("Sprint").GetComponent<FixedButton>();
            FireButton = GameObject.Find("Shoot").GetComponent<FixedButton>();

        }

        // Update is called once per frame
        void Update()
        {
            var fps = GetComponent<Player>();
            var look = GetComponent<Look>();
            var weapon = GetComponent<Weapon>();
            var sway = GameObject.FindWithTag("Pistol");
            //var swaylook = sway.GetComponent<WeaponSway>();

            fps.RunAxis.x = MoveJoystick.Horizontal;
            fps.RunAxis.y = MoveJoystick.Vertical;
            //fps.RunAxis.x = dynamicJoystick.Horizontal;
            //fps.RunAxis.y = dynamicJoystick.Vertical;
            //fps.RunAxis = MoveJoystick.Direction;


            fps.jumping = JumpButton.Pressed;
            look.LookAxis = TouchField.TouchDist;
            fps.SPRINT = SprintButton.Pressed;
            weapon.Fire = FireButton.Pressed;
            //swaylook.LookAxis = TouchField.TouchDist;
        }
    }
}
