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
	public enum ПорядокПогашенияЗаймаПроцентов
	{
		[NonSerialized]
		ПустаяСсылка = - 1,
		[EnumMember(Value = "{\"Ссылка\":\"b634b956-0dec-42c1-97b7-ac83602cb797\", \"Представление\":\"Ежемесячно\"}")]
		Ежемесячно = 0,
		[EnumMember(Value = "{\"Ссылка\":\"d91b3353-e907-422c-bc3f-ab6e37694374\", \"Представление\":\"ПоОкончанииСрока\"}")]
		ПоОкончанииСрока = 1,//По окончании срока
	}
	public static partial class ПорядокПогашенияЗаймаПроцентов_Значения//:ПеречислениеСсылка
	{
		public static readonly Guid Ежемесячно = new Guid("83acb797-2c60-97b7-42c1-0decb634b956");
		public static readonly Guid ПоОкончанииСрока = new Guid("6eab3fbc-6937-7443-422c-e907d91b3353");//По окончании срока
		public static ПорядокПогашенияЗаймаПроцентов Получить(this ПорядокПогашенияЗаймаПроцентов Значение, byte[] Ссылка)
		{
			return Получить(Значение, new Guid(Ссылка));
		}
		public static ПорядокПогашенияЗаймаПроцентов Получить(this ПорядокПогашенияЗаймаПроцентов Значение, Guid Ссылка)
		{
			if(Ссылка == Ежемесячно)
			{
				return ПорядокПогашенияЗаймаПроцентов.Ежемесячно;
			}
			else if(Ссылка == ПоОкончанииСрока)
			{
				return ПорядокПогашенияЗаймаПроцентов.ПоОкончанииСрока;
			}
			return ПорядокПогашенияЗаймаПроцентов.ПустаяСсылка;
		}
		public static byte[] Ключ(this ПорядокПогашенияЗаймаПроцентов Значение)
		{
			return Ссылка(Значение).ToByteArray();
		}
		public static Guid Ссылка(this ПорядокПогашенияЗаймаПроцентов Значение)
		{
			switch (Значение)
			{
				case ПорядокПогашенияЗаймаПроцентов.Ежемесячно: return Ежемесячно;
				case ПорядокПогашенияЗаймаПроцентов.ПоОкончанииСрока: return ПоОкончанииСрока;
			}
			return Guid.Empty;
		}
	}
}