﻿using Components;
using Unity.Entities;
using Unity.Physics;

namespace Systems
{
    public class MovableSystem: SystemBase
    {
        protected override void OnUpdate()
        {
            Entities.ForEach((ref PhysicsVelocity physicsVelocity, in Movable movable) =>
            {
                var step = movable.direction * movable.speed;
                physicsVelocity.Linear = step;
            }).Schedule();
        }
    }
}