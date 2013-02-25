﻿
using System;
using System.Runtime.Serialization;
using V82;
using V82.Перечисления;//Ссылка;
namespace V82.Перечисления//Ссылка
{
	[DataContract]
	public enum УсловияФильтровЭлектронныхПисем
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"5d5c8a92-61aa-4780-b215-09e009b9b843\", \"Представление\":\"ПолеОтправительСодержит\"}")]
		ПолеОтправительСодержит = 0,//Поле "Отправитель" содержит ...
		[EnumMember(Value = "{\"Ссылка\":\"48008234-67e8-4a77-a78e-34c1fb594885\", \"Представление\":\"ТемаПисьмаСодержит\"}")]
		ТемаПисьмаСодержит = 1,//Тема письма содержит ...
		[EnumMember(Value = "{\"Ссылка\":\"35662ef0-6c9f-4220-879f-b68e46358bea\", \"Представление\":\"ТекстПисьмаСодержит\"}")]
		ТекстПисьмаСодержит = 2,//Текст письма содержит ...
		[EnumMember(Value = "{\"Ссылка\":\"cbd18120-8529-4da8-ba16-a24ce6f665eb\", \"Представление\":\"ПолеКомуСодержит\"}")]
		ПолеКомуСодержит = 3,//Поле "Кому" содержит ...
		[EnumMember(Value = "{\"Ссылка\":\"93056f45-f5f6-4812-bdd6-75734ddcc30a\", \"Представление\":\"ПолеКопииСодержит\"}")]
		ПолеКопииСодержит = 4,//Поле "Копии" содержит ...
	}
	public static partial class УсловияФильтровЭлектронныхПисем_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid ПолеОтправительСодержит = new Guid("e00915b2-b909-43b8-4780-61aa5d5c8a92");//Поле "Отправитель" содержит ...
		public static readonly Guid ТемаПисьмаСодержит = new Guid("c1348ea7-59fb-8548-4a77-67e848008234");//Тема письма содержит ...
		public static readonly Guid ТекстПисьмаСодержит = new Guid("8eb69f87-3546-ea8b-4220-6c9f35662ef0");//Текст письма содержит ...
		public static readonly Guid ПолеКомуСодержит = new Guid("4ca216ba-f6e6-eb65-4da8-8529cbd18120");//Поле "Кому" содержит ...
		public static readonly Guid ПолеКопииСодержит = new Guid("7375d6bd-dc4d-0ac3-4812-f5f693056f45");//Поле "Копии" содержит ...
		public static УсловияФильтровЭлектронныхПисем Получить(this УсловияФильтровЭлектронныхПисем Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static УсловияФильтровЭлектронныхПисем Получить(this УсловияФильтровЭлектронныхПисем Значение, Guid Ссылка)
		{
			if(Ссылка == ПолеОтправительСодержит)
			{
				return УсловияФильтровЭлектронныхПисем.ПолеОтправительСодержит;
			}
			else if(Ссылка == ТемаПисьмаСодержит)
			{
				return УсловияФильтровЭлектронныхПисем.ТемаПисьмаСодержит;
			}
			else if(Ссылка == ТекстПисьмаСодержит)
			{
				return УсловияФильтровЭлектронныхПисем.ТекстПисьмаСодержит;
			}
			else if(Ссылка == ПолеКомуСодержит)
			{
				return УсловияФильтровЭлектронныхПисем.ПолеКомуСодержит;
			}
			else if(Ссылка == ПолеКопииСодержит)
			{
				return УсловияФильтровЭлектронныхПисем.ПолеКопииСодержит;
			}
			return УсловияФильтровЭлектронныхПисем.ПустаяСсылка;
		}
		public static byte[] Ключ(this УсловияФильтровЭлектронныхПисем Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this УсловияФильтровЭлектронныхПисем Значение)
		{
			switch (Значение)
			{
				case УсловияФильтровЭлектронныхПисем.ПолеОтправительСодержит: return ПолеОтправительСодержит;
				case УсловияФильтровЭлектронныхПисем.ТемаПисьмаСодержит: return ТемаПисьмаСодержит;
				case УсловияФильтровЭлектронныхПисем.ТекстПисьмаСодержит: return ТекстПисьмаСодержит;
				case УсловияФильтровЭлектронныхПисем.ПолеКомуСодержит: return ПолеКомуСодержит;
				case УсловияФильтровЭлектронныхПисем.ПолеКопииСодержит: return ПолеКопииСодержит;
			}
			return Guid.Empty;
		}
	}
}