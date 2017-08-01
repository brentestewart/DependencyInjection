using System;
using System.Collections.Generic;

namespace SuperHero.Data
{
    public static class HeroServiceLocator
    {
        private static readonly Dictionary<Type, Func<object>> Services = new Dictionary<Type, Func<object>>();

        public static void Register<T>(Func<T> resolver)
        {
            Services[typeof(T)] = () => resolver();
        }

        public static T Resolve<T>()
        {
            return (T)Services[typeof(T)]();
        }

        public static void Reset()
        {
            Services.Clear();
        }
    }
}
