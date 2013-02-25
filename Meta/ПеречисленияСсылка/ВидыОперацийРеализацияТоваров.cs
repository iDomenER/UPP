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
	public enum ВидыОперацийРеализацияТоваров
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"e7a01016-3274-4edb-8c23-0a3a72bf8493\", \"Представление\":\"ПродажаКомиссия\"}")]
		ПродажаКомиссия = 0,//продажа, комиссия
		[EnumMember(Value = "{\"Ссылка\":\"e23ce4ce-7422-4824-9f93-1173c43aab84\", \"Представление\":\"Брак\"}")]
		Брак = 1,
		[EnumMember(Value = "{\"Ссылка\":\"917b2262-a04a-4e2f-92bb-783a181ded01\", \"Представление\":\"ОтгрузкаБезПереходаПраваСобственности\"}")]
		ОтгрузкаБезПереходаПраваСобственности = 2,//отгрузка без перехода права собственности
		[EnumMember(Value = "{\"Ссылка\":\"c2f1f1d4-4839-4af2-b585-d31f90409465\", \"Представление\":\"Оборудование\"}")]
		Оборудование = 3,
		[EnumMember(Value = "{\"Ссылка\":\"c35f541f-06a5-4192-88be-60f2c7374f76\", \"Представление\":\"АктВыполненныхРабот\"}")]
		АктВыполненныхРабот = 4,//акт выполненных работ
	}
	public static partial class ВидыОперацийРеализацияТоваров_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПродажаКомиссия = new Guid("3a0a238c-bf72-9384-4edb-3274e7a01016");//продажа, комиссия
		public static readonly Guid Брак = new Guid("7311939f-3ac4-84ab-4824-7422e23ce4ce");
		public static readonly Guid ОтгрузкаБезПереходаПраваСобственности = new Guid("3a78bb92-1d18-01ed-4e2f-a04a917b2262");//отгрузка без перехода права собственности
		public static readonly Guid Оборудование = new Guid("1fd385b5-4090-6594-4af2-4839c2f1f1d4");
		public static readonly Guid АктВыполненныхРабот = new Guid("f260be88-37c7-764f-4192-06a5c35f541f");//акт выполненных работ
		public static ВидыОперацийРеализацияТоваров Получить(this ВидыОперацийРеализацияТоваров Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ВидыОперацийРеализацияТоваров Получить(this ВидыОперацийРеализацияТоваров Значение, Guid Ссылка)
		{
			if(Ссылка == ПродажаКомиссия)
			{
				return ВидыОперацийРеализацияТоваров.ПродажаКомиссия;
			}
			else if(Ссылка == Брак)
			{
				return ВидыОперацийРеализацияТоваров.Брак;
			}
			else if(Ссылка == ОтгрузкаБезПереходаПраваСобственности)
			{
				return ВидыОперацийРеализацияТоваров.ОтгрузкаБезПереходаПраваСобственности;
			}
			else if(Ссылка == Оборудование)
			{
				return ВидыОперацийРеализацияТоваров.Оборудование;
			}
			else if(Ссылка == АктВыполненныхРабот)
			{
				return ВидыОперацийРеализацияТоваров.АктВыполненныхРабот;
			}
			return ВидыОперацийРеализацияТоваров.ПустаяСсылка;
		}
		public static byte[] Ключ(this ВидыОперацийРеализацияТоваров Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ВидыОперацийРеализацияТоваров Значение)
		{
			switch (Значение)
			{
				case ВидыОперацийРеализацияТоваров.ПродажаКомиссия: return ПродажаКомиссия;
				case ВидыОперацийРеализацияТоваров.Брак: return Брак;
				case ВидыОперацийРеализацияТоваров.ОтгрузкаБезПереходаПраваСобственности: return ОтгрузкаБезПереходаПраваСобственности;
				case ВидыОперацийРеализацияТоваров.Оборудование: return Оборудование;
				case ВидыОперацийРеализацияТоваров.АктВыполненныхРабот: return АктВыполненныхРабот;
			}
			return Guid.Empty;
		}
	}
}