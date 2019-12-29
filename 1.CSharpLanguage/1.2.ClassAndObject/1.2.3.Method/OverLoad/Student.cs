﻿using System;
using static System.Console;

namespace SmartLin.LearningCSharp.ClassAndObject
{
	public class Student
	{
		/// <summary>
		/// 姓名；
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 姓名；
		/// </summary>
		public Class Class { get; private set; }                            //将set访问器的访问性定义为私有，实现只读属性；
		/// <summary>
		/// 是否有班级；
		/// </summary>
		private bool HasClass                                               
		=>	this.Class != null;
		/// <summary>
		/// 验证转专业；
		/// </summary>
		/// <returns>是否能转专业</returns>
		private bool ValidateTransferToMajor()								//定义私有方法；
        {
            if (!this.HasClass)
            {
				WriteLine($"{this.Name}尚未被任何专业录取，无法转专业。");
            }
            return this.HasClass;
        }
		/// <summary>
		/// 介绍；
		/// </summary>
        public void Intro()                                                 
        =>	WriteLine														
				($"我叫{this.Name}"
				+ $"{(this.HasClass ? "，来自" + this.Class.ShortName : "")}。");
		/// <summary>
		/// 录取专业；
		/// </summary>
		/// <param name="newMajor">新专业</param>
        public void EnrollByMajor(Major newMajor)
        {
            if (this.HasClass)                                              
            {
				WriteLine($"{this.Name}已被{this.Class.Major.Name}专业录取，不得重复录取。");
            }
            else
            {
                Class newClass = new Class();
                newClass.Year = DateTime.Now.Year;
                newClass.Major = newMajor;
                this.Class = newClass;                                      //访问属性的私有访问器；实现封装；
				WriteLine($"{this.Name}被{newMajor.Name}专业录取，并分配至{newClass.ShortName}班。");
            }
        }
		/// <summary>
		/// 转专业；
		/// </summary>
		/// <param name="newMajor">新专业</param>
		/// <param name="year">年级</param>
		public void TransferToMajor(Major newMajor, int year)               //定义公有方法（重载1）
		{
            if (this.ValidateTransferToMajor())								//调用私有方法，提高代码复用；
            {
                Class newClass = new Class();
                newClass.Major = newMajor;
                newClass.Year = year;
                this.Class = newClass;
				WriteLine($"{this.Name}已转至{newMajor.Name}专业，并分配至{newClass.ShortName}班。");
            }
        }
		/// <summary>
		/// 转专业；
		/// </summary>
		/// <param name="newMajor">新专业</param>
		public void TransferToMajor(Major newMajor)                         //定义公有方法（重载2）
		{
            if (this.ValidateTransferToMajor())                             //调用私有方法，提高代码复用；
			{
                int newClassYear = this.Class.Year + 1;
                this.TransferToMajor(newMajor, newClassYear);               //调用另一重载方法，提高代码复用；
			}
        }
    }
}
