﻿using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace FluidPort
{
    public class Particle
    {
        public Vector2 position;
        public Vector2 velocity;
        public bool alive;
        public float[] distances;
        public int[] neighbors;
        public int neighborCount;
        public int ci;
        public int cj;
        public int index;
        public float p;
        public float pnear;

        public Particle(Vector2 position, Vector2 velocity, bool alive)
        {
            this.position = position;
            this.velocity = velocity;
            this.alive = alive;

            distances = new float[FluidSimulation.MAX_NEIGHBORS];
            neighbors = new int[FluidSimulation.MAX_NEIGHBORS];
        }
    }
}
