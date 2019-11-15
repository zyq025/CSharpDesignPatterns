using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CSharpFlyweight
{
    /// <summary>
    /// 享元工厂，负责创建和管理享元对象
    /// </summary>
    public class FlyWeightFactory
    {
        public Hashtable flyweights = new Hashtable();

        public FlyWeightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight("A"));
            flyweights.Add("B", new ConcreteFlyweight("B"));
            flyweights.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            return flyweights[key] as Flyweight;
        }

    }
}
