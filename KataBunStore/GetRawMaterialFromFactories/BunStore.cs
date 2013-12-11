﻿namespace GetRawMaterialFromFactories
{
    public class BunStore
    {
        public Bun OrderQfStyleBun(string bunName)
        {
            Cook qfStyleCook = new QfStyleCook();
            Waiter waiter = new Waiter(qfStyleCook);
            return waiter.DishOut(bunName);
        }

        public Bun OrderGblStyleBun(string bunName)
        {
            return new GblStylePorkBun();
        }
    }
}