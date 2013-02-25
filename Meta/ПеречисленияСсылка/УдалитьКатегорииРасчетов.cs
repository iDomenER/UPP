﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	///<summary>
	///(Общ)
	///</summary>
	[DataContract]
	public enum УдалитьКатегорииРасчетов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"87b3a7c4-0032-440b-96d8-b44667725afb\", \"Представление\":\"Первичное\"}")]
		Первичное = 0,
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"95411917-abb6-4000-b1ce-e484676aac7a\", \"Представление\":\"ЗависимоеПервогоУровня\"}")]
		ЗависимоеПервогоУровня = 1,//Зависимое первого уровня
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"5c089321-96ba-4288-96e2-8d484e1a69aa\", \"Представление\":\"ЗависимоеВторогоУровня\"}")]
		ЗависимоеВторогоУровня = 2,//Зависимое второго уровня
	///<summary>
	///(Общ)
	///</summary>
		[EnumMember(Value = "{\"Ссылка\":\"bea203cb-ee16-4bf4-98a1-b5cd8c8bcb51\", \"Представление\":\"ЗависимоеТретьегоУровня\"}")]
		ЗависимоеТретьегоУровня = 3,//Зависимое третьего уровня
	}
	public static partial class УдалитьКатегорииРасчетов_Значения//:ПеречислениеСсылка
	{
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid Первичное = new Guid("46b4d896-7267-fb5a-440b-003287b3a7c4");
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ЗависимоеПервогоУровня = new Guid("84e4ceb1-6a67-7aac-4000-abb695411917");//Зависимое первого уровня
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ЗависимоеВторогоУровня = new Guid("488de296-1a4e-aa69-4288-96ba5c089321");//Зависимое второго уровня
		///<summary>
		///(Общ)
		///</summary>
		public static readonly Guid ЗависимоеТретьегоУровня = new Guid("cdb5a198-8b8c-51cb-4bf4-ee16bea203cb");//Зависимое третьего уровня
		public static УдалитьКатегорииРасчетов Получить(this УдалитьКатегорииРасчетов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static УдалитьКатегорииРасчетов Получить(this УдалитьКатегорииРасчетов Значение, Guid Ссылка)
		{
			if(Ссылка == Первичное)
			{
				return УдалитьКатегорииРасчетов.Первичное;
			}
			else if(Ссылка == ЗависимоеПервогоУровня)
			{
				return УдалитьКатегорииРасчетов.ЗависимоеПервогоУровня;
			}
			else if(Ссылка == ЗависимоеВторогоУровня)
			{
				return УдалитьКатегорииРасчетов.ЗависимоеВторогоУровня;
			}
			else if(Ссылка == ЗависимоеТретьегоУровня)
			{
				return УдалитьКатегорииРасчетов.ЗависимоеТретьегоУровня;
			}
			return УдалитьКатегорииРасчетов.ПустаяСсылка;
		}
		public static byte[] Ключ(this УдалитьКатегорииРасчетов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this УдалитьКатегорииРасчетов Значение)
		{
			switch (Значение)
			{
				case УдалитьКатегорииРасчетов.Первичное: return Первичное;
				case УдалитьКатегорииРасчетов.ЗависимоеПервогоУровня: return ЗависимоеПервогоУровня;
				case УдалитьКатегорииРасчетов.ЗависимоеВторогоУровня: return ЗависимоеВторогоУровня;
				case УдалитьКатегорииРасчетов.ЗависимоеТретьегоУровня: return ЗависимоеТретьегоУровня;
			}
			return Guid.Empty;
		}
	}
}