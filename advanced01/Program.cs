namespace advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // What is a generic class? Why use generics?
            //allow you to define type-safe classes, interfaces, methods, and delegates without committing to
            //a specific data type until the code is used

            // no dublicate code , Type Safety , best Performance and IntelliSense
            #endregion
            #region Q2
            //Write a generic class Container<T> with Add and Get methods.
            //    Public class play<T>
            //{
            //    public T value;
            //    public T getvalue()
            //    {
            //        return value;
            //    }

            //}


            #endregion
            #region Q3
            //What are multiple type parameters? Write Pair<TKey, TValue>.

            //Generic classes can have multiple type parameters
            /*
                public class Pair<TFirst, TSecond>
                    {
                        public TFirst First { get; set; }
                        public TSecond Second { get; set; }

                        public Pair(TFirst first, TSecond second)
                        {
                            First = first;
                            Second = second;
                        }

                        public void Deconstruct(out TFirst first, out TSecond second)
                        {
                            first = First;
                            second = Second;
                        }
                    }
                */
            #endregion
            #region Q4
            //What is a generic method? Write Swap<T> method.
            //declares its own type parameter(s). It can exist in both generic and non-generic classes. The compiler often infers the type argument.
            //public static class Utilities
            //{
            //    public static void Swap<T>(ref T a, ref T b)
            //    {
            //        T temp = a;
            //        a = b;
            //        b = temp;
            //    }
            //}

            #endregion
            #region Q5
            //Write a generic method FindMax<T> that finds maximum value
            //public static class Utilities
            //{
            //    public static T Max<T>(T a, T b) where T : IComparable<T>
            //{
            //    return a.CompareTo(b) > 0 ? a : b;
            //}
            //}

            #endregion
            #region Q6
            //What is a generic interface? Write IRepository<T>. 
            //define contracts with type parameters
            //    public interface IRepository<T> where T : class
            //{
            //    T? GetById(int id);
            //    IEnumerable<T> GetAll();
            //    void Add(T entity);
            //    void Update(T entity);
            //    void Delete(int id);
            //}

            #endregion
            #region Q7
            //What is the 'struct' constraint? Write an example.
            // T must be a value type
            /*
             public struct Nullable<T> where T : struct
{
    private readonly bool _hasValue;
    private readonly T _value;

    public bool HasValue => _hasValue;
    public T Value => _hasValue ? _value 
        : throw new InvalidOperationException();

    public Nullable(T value)
    {
        _hasValue = true;
        _value = value;
    }
}
             */

            #endregion
            #region Q8
            // What is the 'class' constraint? Write an example.
            // restricts T to reference types only. This allows T to be null and enables reference comparison.
            /*
                             public class Cache<T> where T : class
                {
                    private T? _cachedItem;

                    public T? Get() => _cachedItem;

                    public void Set(T item)
                    {
                        _cachedItem = item;
                    }

                    public void Clear()
                    {
                        _cachedItem = null; // ✅ Allowed because T is class
                    }

                    public bool IsSame(T other)
                    {
                        return ReferenceEquals(_cachedItem, other);
                    }
                }
             */

            #endregion
            #region Q9
            // What is the 'new()' constraint? Write an example.
            //  requires T to have a public parameterless constructor. This allows you to create instances of T inside the generic code.
            /*
             public class Factory<T> where T : new()
                {
                    public T Create()
                    {
                        return new T(); // ✅ Allowed because of new() constraint
                    }

                    public List<T> CreateMany(int count)
                    {
                        var list = new List<T>();
                        for (int i = 0; i < count; i++)
                        {
                            list.Add(new T());
                        }
                        return list;
                    }
                }
             */
            #endregion
            #region Q10
            // What is the interface constraint? Write an example.
            // requires T to implement a specific interface. This enables calling interface methods on type parameter.
            /*
             public class Sorter<T> where T : IComparable<T>
            {
                public void BubbleSort(T[] array)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        for (int j = 0; j < array.Length - i - 1; j++)
                        {
                            // ✅ CompareTo available because of constraint
                            if (array[j].CompareTo(array[j + 1]) > 0)
                            {
                                (array[j], array[j + 1]) = (array[j + 1], array[j]);
                            }
                        }
                    }
                }
            }
             */

            #endregion
            #region Q11
            // What is the base class constraint? Write an example.
            //restrict a generic type so it must inherit from a specific base class.
            /*
             class Animal
                    {
                        public void Eat()
                        {
                            Console.WriteLine("Animal is eating");
                        }
                    }

                    class Dog : Animal { }
                
                    class Cage<T> where T : Animal
                    {
                        public void Feed(T animal)
                        {
                            animal.Eat();
                        }
                    }
             */

            #endregion
            #region Q12
            // How do you apply multiple constraints? Write an example. 
            // can combine multiple constraints for a single type parameter, and have different constraints for different type parameters.
            /*
                             public class EntityManager<T> 
                    where T : class, IEntity, new()
                {
                    public T CreateAndSave()
                    {
                        var entity = new T();      // ✅ new() constraint
                        entity.Id = Guid.NewGuid(); // ✅ IEntity constraint
                        return entity;
                    }
                }
             */

            #endregion
            #region Q13
            //What does the 'default' keyword do in generics 
            // returns the default value for type T: null for reference types, 0/false for value type 

            #endregion
            #region Q14
            // Write a SafeList<T> that returns default when the index is invalid.
            /*
             public class SafeList<T>
{
    private List<T> items = new List<T>();

    public T GetValueOrDefault(int index)
    {
        if (index < 0 || index >= items.Count)
                return default(T);
            return items[index];
    }
}
             */

            #endregion
            #region Q15
            // What is covariance? Explain the 'out' keyword.
            // allows you to use a more derived type than originally specified 
            // T can only appear in output positions.

            #endregion
            #region Q16
            // What is contravariance? Explain the 'in' keyword.
            // allows you to use a less derived type than originally specified 
            // T can only appear in input positions.

            #endregion
            #region Q17
            // What is the difference between covariance and contravariance?
            // covariant => out => (child → parent)
            // Contravariance => in => (parent → child)

            #endregion
            #region Q18
            // How do static members work in generic types?
            // Each closed generic type has its own copy of static fields

            #endregion
            #region Q19
            //  How can you inherit from a generic class
            // can inherit from other generic or non-generic classes

            #endregion
            #region Q20
            // Complete Exercise - Create a generic Cache<TKey, TValue>with Add, Get, Remove, Contains, and expiration support. 


            #endregion

        }
    }
}
