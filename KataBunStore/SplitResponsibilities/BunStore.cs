﻿namespace SplitResponsibilities
{
    public class BunStore
    {
        public static Bun OrderBun(string bunName)
        {
            return Waiter.DishOut(bunName);

        }
    }
}