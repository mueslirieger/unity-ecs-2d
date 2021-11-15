using System;
using Components;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

namespace Systems
{
    public class PlayerSystem : SystemBase
    {
        protected override void OnUpdate()
        {
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");
            var jump = Input.GetButton("Jump");

            Entities
                .WithAll<Player>()
                .ForEach((ref Movable movable) =>
                {
                    movable.direction = new float3(x, Convert.ToInt32(jump), 0);
                }).Run();
        }
    }
}