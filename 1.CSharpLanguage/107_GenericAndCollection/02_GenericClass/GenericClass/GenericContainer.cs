using System;
using System.Collections.Generic;

namespace SmartLin.LearningCSharp.GenericTypeAndCollection
{
    /// <summary>
    /// 通用容器；
    /// </summary>
    /// <typeparam name="T">元素类型</typeparam>
    public class GenericContainer<T> where T : IEntity                                  //约束该泛型类型必须实现指定接口；
    {
        /// <summary>
        /// 初始元素个数；
        /// </summary>
        private int _InitialElementCount = 5;
        /// <summary>
        /// 当前元素个数；
        /// </summary>                         
        private int _CurrentElementCount = 0;
        /// <summary>
        /// 多个元素；
        /// </summary>
        private T[] Elements
        {
            get;
            set;
        }
        /// <summary>
        /// 添加元素；
        /// </summary>
        /// <param name="newElement">新元素</param>
        public void Add(T newElement)
        {
            if (this._CurrentElementCount >= this._InitialElementCount)
            {
                this._InitialElementCount *= 2;
                T[] newElements = new T[this._InitialElementCount];
                this.Elements.CopyTo(newElements, 0);
                this.Elements = newElements;
            }
            this.Elements[this._CurrentElementCount] = newElement;
            this._CurrentElementCount++;
        }
        /// <summary>
        /// 添加多个元素；
        /// </summary>
        /// <param name="newElements">多个元素</param>
        public void Add(T[] newElements)
        {
            foreach (T element in newElements)
            {
                this.Add(element);
            }
        }
        /// <summary>
        /// 按指定条件查找；
        /// </summary>
        /// <param name="match">匹配</param>
        /// <returns>通用容器</returns>
        public GenericContainer<T> Find(Func<T, bool> match)
        {
            T[] tempResults = new T[this.Elements.Length];
            int tempResultCount = 0;
            foreach (T element in this.Elements)
            {
                if (match(element))
                {
                    tempResults[tempResultCount] = element;
                    tempResultCount++;
                }
            }
            T[] results = new T[tempResultCount];
            int resultsCount = 0;
            foreach (T element in tempResults)
            {
                if (element != null)
                {
                    results[resultsCount] = element;
                    resultsCount++;
                }
            }
            return new GenericContainer<T>(results);
        }
        /// <summary>
        /// 遍历；
        /// </summary>
        /// <param name="operate">操作</param>
        /// <returns>通用容器</returns>
        public GenericContainer<T> ForEach(Action<T> operate)
        {
            foreach (T element in this.Elements)
            {
                operate(element);
            }
            return this;
        }
        /// <summary>
        /// 获取枚举器；
        /// </summary>
        /// <returns>枚举器</returns>
        public IEnumerator<T> GetEnumerator()                                           //使用IEnumerator的泛型版本，实现枚举器；           
        {
            foreach (T element in this.Elements)
            {
                yield return element;
            }
        }
        /// <summary>
        /// 根据编号访问元素；
        /// </summary>
        /// <param name="number">编号</param>
        /// <returns>元素</returns>
        public T this[string number]
        {
            get
            {
                foreach (T element in this.Elements)
                {
                    if (element.Number == number)
                    {
                        return element;
                    }
                }
                return default(T);                                                      //泛型类型可能为值类型，故不能使用null，必须使用default，从而分别将值类型、引用类型初始化为0或null；
            }
            set
            {
                for (int i = 0; i < this.Elements.Length; i++)
                {
                    if (this.Elements[i].Number == number)
                    {
                        this.Elements[i] = value;
                        return;
                    }
                }
                this.Add(value);
            }
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        public GenericContainer()
        {
            this.Elements = new T[this._InitialElementCount];
            this._CurrentElementCount = 0;
        }
        /// <summary>
        /// 构造函数；
        /// </summary>
        /// <param name="elements">多个元素</param>
        public GenericContainer(T[] elements)
            : this()
        {
            this.Elements = elements;
            this._InitialElementCount = elements.Length;
            this._CurrentElementCount = elements.Length;
        }
    }
}
